using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using System.IO; 
using System.Configuration;
using Microsoft.Office.Interop.Excel;
using System.Windows.Forms;
using System.Data.OleDb;

//treba doraditi da izgleda bolje.

namespace iflib
{
    public class ExcelIE
    {
        public static void ExportXLS(/*DataSet dbDataSet, string MyConnString, string MyStoredProcedure,*/
            object[] Parametri, /*string sheetName,*/ string prvaCelija, string styleName,
            bool vidljivo, ProgressBar pbar, string savePath)
        {
            SqlConnection con = null;
            SqlDataAdapter ada = null;
            System.Data.DataTable tbl = null;

            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook exWorkBook = null;
            Microsoft.Office.Interop.Excel.Worksheet exWorkSheet = null;

            System.Diagnostics.Stopwatch t = new System.Diagnostics.Stopwatch();

            pbar.Value = 0;
            pbar.Minimum = 0;
            pbar.Maximum = Parametri.Length * 7 + 1;
            pbar.Visible = true;
            pbar.Step = 1;


            for (int i = 0; i < Parametri.Length; i++)
            {
                t.Start();
                //Step 1: Run stored procedure and generate output in a DataTable
                //SqlCeConnection con = new SqlCeConnection();
                /*SqlConnection*/ con = new SqlConnection();
                //con.ConnectionString = MyConnString;
                dtParametri dtp = (dtParametri)Parametri[i];
                con.ConnectionString = dtp.ConnectionString;
                con.Open();

                t.Stop();
                Console.WriteLine($"Opening Connection time: {t.Elapsed}");

                pbar.PerformStep();

                //SqlCeDataAdapter ada = new SqlCeDataAdapter(MyStoredProcedure, con);
                //ada.SelectCommand = new SqlCeCommand();
                /*SqlDataAdapter*/ ada = new SqlDataAdapter(dtp.StoredProcedure, con);
                ada.SelectCommand = new SqlCommand();
                ada.SelectCommand.Connection = con;
                ada.SelectCommand.CommandType = CommandType.Text;
                ada.SelectCommand.CommandText = /*MyStoredProcedure*/dtp.StoredProcedure;

                /*System.Data.DataTable */tbl = new System.Data.DataTable();
                ada.Fill(tbl);

                pbar.PerformStep();

                //Step 2: copy datatable to array
                int rowcount = tbl.Rows.Count;
                int columncount = tbl.Columns.Count;



                var data = new object[rowcount, columncount];
                for (var row = 1; row <= rowcount; row++)
                {
                    for (var column = 1; column <= columncount; column++)
                    {
                        data[row - 1, column - 1] = tbl.Rows[row - 1].ItemArray[column - 1];
                    }
                }

                pbar.PerformStep();

                //Step 3: Create xls variables
                /*Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();*/
                /*Microsoft.Office.Interop.Excel.Workbook exWorkBook = excel.Application.Workbooks.Add(true);*/
                Microsoft.Office.Interop.Excel.Worksheets newWorkSheet = excel.Worksheets.Add();
                //treba dodati novi sheet ali ovo ne radi. pogledati quipie, tu bi trebalo da postoji ova klasa, mozda je treba i preuzeti.

                /*Microsoft.Office.Interop.Excel.Worksheet*/ exWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)excel.ActiveSheet;

                object missing = System.Reflection.Missing.Value;

                //Create Header in xls
                int iCol = 0;
                foreach (DataColumn c in tbl.Columns)
                {
                    excel.Cells[1, iCol + 1] = c.ColumnName;
                    iCol++;
                }

                pbar.PerformStep();

                //Copy array named 'data' to xls
                var startCell = (Microsoft.Office.Interop.Excel.Range)exWorkSheet.Cells[2, 1];
                var endCell = (Microsoft.Office.Interop.Excel.Range)exWorkSheet.Cells[rowcount + 1, columncount];
                var writeRange = exWorkSheet.get_Range(startCell, endCell);
                writeRange.Value2 = data;
                Microsoft.Office.Interop.Excel.Range exCellRange;
                Microsoft.Office.Interop.Excel.Range exRang2;

                //Activate Excel
                ((Microsoft.Office.Interop.Excel._Worksheet)exWorkSheet).Activate();
                excel.Visible = vidljivo;

                exWorkSheet.Name = /*sheetName*/dtp.DataTableName;

                //podesavanje Excela

                //prvi red
                //exWorkSheet.Cells[1, 1] = prvaCelija;
                //exWorkSheet.Cells[1, 2] = "Datum: " + DateTime.Now.ToShortDateString();

                //Granice za sve redove
                exCellRange = exWorkSheet.Range[exWorkSheet.Cells[1, 1], exWorkSheet.Cells[rowcount + 1, columncount]];
                exCellRange.EntireColumn.AutoFit();
                Microsoft.Office.Interop.Excel.Borders border = exCellRange.Borders;
                border.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                border.Weight = 2d;

                pbar.PerformStep();

                //Font za prva 2 reda
                exRang2 = exWorkSheet.Range[exWorkSheet.Cells[1, 1], exWorkSheet.Cells[1, columncount]];
                Microsoft.Office.Interop.Excel.Style stil = exWorkBook.Styles.Add(styleName);
                stil.Font.Name = "Calibri";
                stil.Font.Size = 11;
                stil.Font.Bold = true;
                exRang2.Style = stil;

                //Granice za prva 2 reda
                exRang2.Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                exRang2.Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlMedium;

                pbar.PerformStep();

                //Smrzavanje prva 2 reda
                exRang2.Activate();
                exRang2.Application.ActiveWindow.SplitRow = 1; //zamrznut samo prvi red u ovom slucaju
                exRang2.Application.ActiveWindow.FreezePanes = true;

                //postavljanje kolone kao tip DATUM
                exRang2 = exWorkSheet.Range[exWorkSheet.Cells[1, 19], exWorkSheet.Cells[rowcount + 1, 19]];
                exRang2.NumberFormat = "dd.MM.yyyy";

                pbar.PerformStep();
            }

            //zatvaranje excela i procesa u pozadini
            exWorkBook.SaveAs(savePath, XlFileFormat.xlExcel8); //cuva kao *.xls sa unicode karakterima
            exWorkBook.Close(true);
            excel.Quit();

            pbar.PerformStep();

            System.Runtime.InteropServices.Marshal.ReleaseComObject(exWorkSheet);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(exWorkBook);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excel);

            //Cleanup
            tbl.Dispose();
            ada.Dispose();
            con.Close();

            pbar.Visible = false;
        }


        public static void ImportXLS(string imeFajla, string naziv_tabele, ProgressBar pBar, DataGridView dgv, string dbConnectionString /*System.Windows.Forms.Label procLab,
            System.Windows.Forms.Label procLab2, System.Data.DataTable dataTabela*/)
        {
            string connstr = "Provider=Microsoft.Jet.Oledb.4.0;Data Source=" + imeFajla + ";Extended Properties=Excel 8.0;";
            OleDbConnection conn = new OleDbConnection(connstr);
            string strSQL = "SELECT * FROM [Servis$]"; //[Sheet1$]


            OleDbCommand cmd = new OleDbCommand(strSQL, conn);
            DataSet ds = new DataSet();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(ds);

            System.Data.DataTable dt = new System.Data.DataTable();
            dt = ds.Tables[0];

            dgv.DataSource = dt;

            pBar.Value = 0;
            pBar.Minimum = 0;
            pBar.Maximum = dgv.Rows.Count;
            pBar.Visible = true;
            pBar.Step = 1;
            //procLab.Visible = true;
            //procLab2.Text = "/ " + dgv.Rows.Count;
            //procLab2.Visible = true;

            //SqlCeConnection connection = new SqlCeConnection(Properties.Settings.Default.servisdbConnectionString);
            SqlConnection connection = new SqlConnection(dbConnectionString);
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                //kod SQL CE komandi, razlicite komande se pisu u razlicitim stringovima
                //SQL komanda da se omoguci unos identiteta
                //SqlCeCommand identChange = connection.CreateCommand();
                //identChange.CommandText = "SET IDENTITY_INSERT " + naziv_tabele + " ON";
                //SqlCeCommand com = connection.CreateCommand();
                SqlCommand com = connection.CreateCommand();

                //Uvoz iz DataGridView u bazu
                //Ovaj deo mora da se promeni kod svakog programa

                /*com.CommandText = "INSERT INTO " + naziv_tabele + " ([Broj naloga], [Ime i Prezime], [Telefon], [Proizvodjac], " +
                    "[Model], [Serijski broj], [Opis kvara], [Izvesaj], [Punjac], [Baterija], [Torba], [Mis], [ostalo], [Na cekanju], " +
                "[Zavrseno], [Korisnik odustao], [Servis neuspesan], [Korisnik odbio placanje], [Datum], [Napomena], [Status], " +
                "[e-mail]) VALUES (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10, @p11, @p12, @p13, @p14, @p15, @p16, @p17, " +
                "@p18, @p19, @p20, @p21, @p22)";*/

                com.CommandText = @"INSERT INTO NaloziP
                  (brojNaloga, Datum, imePrezime, Kontakt, eMail, Uredjaj, Proizvodjac, Model, serijskiBroj, Oprema, opisKvara, Izvestaj, 
cenaDelova, cenaServis, ukupnaCena, Status, naCekanju, Zavrseno, korisnikOdustao, servisOdustao, korisnikOdbioPlacanje, Napomena)
VALUES(@brojNaloga, @Datum, @imePrezime, @Kontakt, @eMail, @Uredjaj, @Proizvodjac, @Model, @serijskiBroj, @Oprema, @opisKvara, @Izvestaj, 
@cenaDelova, @cenaServis, @ukupnaCena, @Status, @naCekanju, @Zavrseno, @korisnikOdustao, @servisOdustao, @korisnikOdbioPlacanje, @Napomena)";

                //ovde sam stao. idetii kako ovo resiti ako mora za svaku tabelu da se radi ponaosob
                com.Parameters.AddWithValue("@p1", dgv.Rows[i].Cells[0].Value);
                com.Parameters.AddWithValue("@p2", dgv.Rows[i].Cells[2].Value);
                com.Parameters.AddWithValue("@p3", dgv.Rows[i].Cells[3].Value);
                com.Parameters.AddWithValue("@p4", dgv.Rows[i].Cells[5].Value);
                com.Parameters.AddWithValue("@p5", dgv.Rows[i].Cells[6].Value);
                com.Parameters.AddWithValue("@p6", dgv.Rows[i].Cells[7].Value);
                com.Parameters.AddWithValue("@p7", dgv.Rows[i].Cells[8].Value);
                com.Parameters.AddWithValue("@p8", dgv.Rows[i].Cells[9].Value);
                com.Parameters.AddWithValue("@p9", dgv.Rows[i].Cells[10].Value);
                com.Parameters.AddWithValue("@p10", dgv.Rows[i].Cells[11].Value);
                com.Parameters.AddWithValue("@p11", dgv.Rows[i].Cells[12].Value);
                com.Parameters.AddWithValue("@p12", dgv.Rows[i].Cells[13].Value);
                com.Parameters.AddWithValue("@p13", dgv.Rows[i].Cells[14].Value);
                com.Parameters.AddWithValue("@p14", dgv.Rows[i].Cells[15].Value);
                com.Parameters.AddWithValue("@p15", dgv.Rows[i].Cells[16].Value);
                com.Parameters.AddWithValue("@p16", dgv.Rows[i].Cells[17].Value);
                com.Parameters.AddWithValue("@p17", dgv.Rows[i].Cells[18].Value);
                com.Parameters.AddWithValue("@p18", dgv.Rows[i].Cells[19].Value);
                com.Parameters.AddWithValue("@p19", dgv.Rows[i].Cells[1].Value);
                com.Parameters.AddWithValue("@p20", dgv.Rows[i].Cells[20].Value);
                com.Parameters.AddWithValue("@p21", dgv.Rows[i].Cells[21].Value);
                com.Parameters.AddWithValue("@p22", dgv.Rows[i].Cells[4].Value);

                try
                {
                    connection.Open();
                    //identChange.ExecuteNonQuery();
                    com.ExecuteNonQuery();

                    pBar.PerformStep();
                    //procLab.Text = i.ToString();

                }

                //catch (SqlCeException ex)
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    connection.Close();
                }
            }
            pBar.Visible = false;
            //procLab.Visible = false;
            //procLab2.Visible = false;


            /*pBar.Value = 0;
             pBar.Minimum = 0;
             pBar.Maximum = dt.Rows.Count;
             pBar.Visible = true;
             pBar.Step = 1;

             f_servis fs = new f_servis();
             int r = 0;
             dataTabela.Clear();
             foreach (DataRow dr in dt.Rows)
             {
                 dataTabela.ImportRow(dt.Rows[r]);
                 pBar.PerformStep();
                 r++;
             }*/
        }
    }

    public class dtParametri
    {
        public string ConnectionString { get; set; }
        public string DataTableName { get; set; }
        public string StoredProcedure { get; set; }
    }
}