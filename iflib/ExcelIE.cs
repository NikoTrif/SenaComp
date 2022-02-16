using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace fun
{
    public class ExcelIE
    {
        //TD26
        public void ExportToExcel(ProgressBar pb, System.Windows.Forms.Label l1, System.Windows.Forms.Label l2,
            string styleName, bool vidljivostExcela, string savePath, DataSet ds)
        {
            pb.Minimum = 0;
            pb.Maximum = 0;
            pb.Step = 1;

            foreach (System.Data.DataTable dt in ds.Tables)
            {
                pb.Maximum = pb.Maximum + dt.Rows.Count;
            }

            l1.Text = "Izvoz podataka u Excel tabelu";
            l2.Text = string.Format("{0} / {1}", pb.Maximum, pb.Minimum);
            //l2.Visible = false;

            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Workbook exWorkBook = excel.Workbooks.Add(true);
            Worksheet exWorkSheet = excel.ActiveSheet;
            Range exRange;

            Style stil = exWorkBook.Styles.Add(styleName);
            stil.Font.Name = "Calibri";
            stil.Font.Size = 11;
            stil.Font.Bold = true;
            stil.HorizontalAlignment = XlHAlign.xlHAlignCenter;

            int iCol = 1;
            int iTab = 0;
            foreach (System.Data.DataTable dt in ds.Tables)
            {
                foreach (DataColumn c in ds.Tables[iTab].Columns)
                {
                    excel.Cells[1, iCol] = c.ColumnName; //postavljanje naziva kolona
                    iCol++;
                }

                int rwCount = dt.Rows.Count;
                int colCount = dt.Columns.Count;

                // kopiranje podataka iz tabele u Array
                var data = new object[rwCount, colCount];
                for (int row = 0; row < rwCount; row++)
                {
                    for (int col = 0; col < colCount; col++)
                    {
                        data[row, col] = dt.Rows[row].ItemArray[col];
                    }
                    pb.PerformStep();
                    l2.Text = string.Format("{0} / {1}", pb.Maximum, pb.Value);
                    //l2.Refresh();
                }

                var startCell = (Range)exWorkSheet.Cells[2, 1];
                var endCell = (Range)exWorkSheet.Cells[rwCount + 1, colCount];
                var writeRange = exWorkSheet.get_Range(startCell, endCell);
                writeRange.Value2 = data; //kopiranje data u Worksheet

                //podesavanje prvog reda
                exRange = exWorkSheet.Range[exWorkSheet.Cells[1, 1], exWorkSheet.Cells[1, colCount]];
                exRange.Style = stil;
                //exRange.Activate();
                exRange.Application.ActiveWindow.SplitRow = 1;
                exRange.Application.ActiveWindow.FreezePanes = true;
                exRange.EntireColumn.AutoFit();
                exRange.Borders.LineStyle = XlLineStyle.xlContinuous;
                exRange.Borders.Weight = XlBorderWeight.xlMedium;

                //podesavanje cele tabele
                exRange = exWorkSheet.Range[exWorkSheet.Cells[2, 1], exWorkSheet.Cells[rwCount + 1, colCount]];
                exRange.Borders.LineStyle = XlLineStyle.xlContinuous;
                exRange.Borders.Weight = XlBorderWeight.xlThin;
                exRange.EntireColumn.AutoFit();

                //podesavanje prikaza datuma
                //switch (iTab)
                //{
                //    case 0:
                //        exWorkSheet.Name = "Artikli";
                //        break;
                //    case 1:
                //        exRange = exWorkSheet.Range[exWorkSheet.Cells[2, 1], exWorkSheet.Cells[rwCount + 1, 1]];
                //        exRange.NumberFormat = "dd.MM.yyyy";
                //        exWorkSheet.Name = "Privatni prihod";
                //        break;
                //    case 2:
                //        exRange = exWorkSheet.Range[exWorkSheet.Cells[2, 1], exWorkSheet.Cells[rwCount + 1, 1]];
                //        exRange.NumberFormat = "dd.MM.yyyy";
                //        exWorkSheet.Name = "Privatna dugovanja";
                //        break;
                //    case 3:
                //        exRange = exWorkSheet.Range[exWorkSheet.Cells[2, 2], exWorkSheet.Cells[rwCount + 1, 2]];
                //        exRange.NumberFormat = "dd.MM.yyyy";
                //        exRange = exWorkSheet.Range[exWorkSheet.Cells[2, 11], exWorkSheet.Cells[rwCount + 1, 11]];
                //        exRange.NumberFormat = "dd.MM.yyyy";
                //        exWorkSheet.Name = "Poslovni izlaz";
                //        break;
                //    case 4:
                //        exRange = exWorkSheet.Range[exWorkSheet.Cells[2, 1], exWorkSheet.Cells[rwCount + 1, 1]];
                //        exRange.NumberFormat = "dd.MM.yyyy";
                //        exWorkSheet.Name = "Privatni trošak";
                //        break;
                //    case 5:
                //        exRange = exWorkSheet.Range[exWorkSheet.Cells[2, 2], exWorkSheet.Cells[rwCount + 1, 2]];
                //        exRange.NumberFormat = "dd.MM.yyyy";
                //        exRange = exWorkSheet.Range[exWorkSheet.Cells[2, 10], exWorkSheet.Cells[rwCount + 1, 10]];
                //        exRange.NumberFormat = "dd.MM.yyyy";
                //        exWorkSheet.Name = "Poslovni ulaz";
                //        break;
                //    case 6:
                //        exRange = exWorkSheet.Range[exWorkSheet.Cells[2, 2], exWorkSheet.Cells[rwCount + 1, 2]];
                //        exRange.NumberFormat = "dd.MM.yyyy";
                //        exWorkSheet.Name = "Poslovni ulaz rate";
                //        break;
                //    case 7:
                //        exRange = exWorkSheet.Range[exWorkSheet.Cells[2, 3], exWorkSheet.Cells[rwCount + 1, 3]];
                //        exRange.NumberFormat = "dd.MM.yyyy";
                //        exWorkSheet.Name = "Poslovni izlaz rate";
                //        break;
                //    case 8:
                //        exRange = exWorkSheet.Range[exWorkSheet.Cells[2, 2], exWorkSheet.Cells[rwCount + 1, 2]];
                //        exRange.NumberFormat = "dd.MM.yyyy";
                //        exWorkSheet.Name = "Privatna dugovanja rate";
                //        break;
                //}

                //G16
                //exWorkSheet.Name = ds.Tables[iTab].TableName; //promena naziva Sheeta
                exWorkBook.Sheets.Add(After: exWorkBook.Sheets[exWorkBook.Sheets.Count]); //dodavanje novog sheeta
                exWorkSheet = exWorkBook.Sheets[exWorkBook.Sheets.Count]; //da sledeci bude aktivan
                iTab++;
                iCol = 1;
            }

            exWorkSheet.Delete(); //brisanje poslednjeg sheeta
            exWorkSheet = exWorkBook.Sheets[1];
            exWorkSheet.Activate();

            exWorkBook.SaveAs(savePath, XlFileFormat.xlExcel8); //cuvanje kao xls sa unicode karakterima
            exWorkBook.Close(true);
            excel.Quit();

            System.Runtime.InteropServices.Marshal.ReleaseComObject(exWorkSheet);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(exWorkBook);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excel);

        }

        public void ImportFromExcel(DataSet dbQDS, string fileName, ProgressBar pb, System.Windows.Forms.Label lt, 
            System.Windows.Forms.Label lb, string conString)
        {
            if (MessageBox.Show("OPREZ!" + "\n" + "Ukoliko vratite ovu bazu, baza podataka koju trenutno koristite će biti obrisana" +
                "\n" + "Da li ste sigurni da želite da nastavite?", "PAŽNJA!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) ==
                DialogResult.Yes)
            {
                pb.Style = ProgressBarStyle.Marquee;
                lt.Text = "Uvoz baze podataka iz Excel tabela";
                lb.Visible = false;

                string sheetName = string.Empty;
                string connStr = "Provider=Microsoft.Jet.Oledb.4.0;Data Source=" + fileName + ";Extended Properties=Excel 8.0;";
                string commStr = string.Empty; //string.Format("SELECT * FROM [{0}$]", sheetName);
                string tabName = string.Empty;

                StringBuilder sb = new StringBuilder();

                OleDbConnection oleConn = new OleDbConnection(connStr);
                OleDbCommand oleComm = new OleDbCommand(commStr, oleConn);
                OleDbDataAdapter oleDta = new OleDbDataAdapter(oleComm);
                //System.Data.DataTable dt = new System.Data.DataTable();

                SqlConnection sqlConn = new SqlConnection(conString);
                SqlCommand sqlComm = new SqlCommand(commStr, sqlConn);
                sqlConn.Open();

                for (int sheetNum = 0; sheetNum < 9; sheetNum++)
                {
                    //Brisanje tabele u bazi
                    tabName = dbQDS.Tables[sheetNum].TableName;
                    commStr = "TRUNCATE TABLE " + tabName;
                    sqlComm.CommandText = commStr;
                    sqlComm.ExecuteNonQuery();

                    switch (sheetNum)
                    {
                        case 0:
                            //upisivanje u OleDB
                            sheetName = "Artikli";
                            commStr = string.Format("SELECT * FROM [{0}$]", sheetName);
                            oleComm.CommandText = commStr;
                            oleDta.SelectCommand = oleComm;
                            break;
                        case 1:
                            sheetName = "Privatni prihod";
                            commStr = string.Format("SELECT * FROM [{0}$]", sheetName);
                            oleComm.CommandText = commStr;
                            oleDta.SelectCommand = oleComm;
                            break;
                        case 2:
                            sheetName = "Privatna dugovanja";
                            commStr = string.Format("SELECT * FROM [{0}$]", sheetName);
                            oleComm.CommandText = commStr;
                            oleDta.SelectCommand = oleComm;
                            break;
                        case 3:
                            sheetName = "Poslovni izlaz";
                            commStr = string.Format("SELECT * FROM [{0}$]", sheetName);
                            oleComm.CommandText = commStr;
                            oleDta.SelectCommand = oleComm;
                            break;
                        case 4:
                            sheetName = "Privatni trošak";
                            commStr = string.Format("SELECT * FROM [{0}$]", sheetName);
                            oleComm.CommandText = commStr;
                            oleDta.SelectCommand = oleComm;
                            break;
                        case 5:
                            sheetName = "Poslovni ulaz";
                            commStr = string.Format("SELECT * FROM [{0}$]", sheetName);
                            oleComm.CommandText = commStr;
                            oleDta.SelectCommand = oleComm;
                            break;
                        case 6:
                            sheetName = "Poslovni ulaz rate";
                            commStr = string.Format("SELECT * FROM [{0}$]", sheetName);
                            oleComm.CommandText = commStr;
                            oleDta.SelectCommand = oleComm;
                            break;
                        case 7:
                            sheetName = "Poslovni izlaz rate";
                            commStr = string.Format("SELECT * FROM [{0}$]", sheetName);
                            oleComm.CommandText = commStr;
                            oleDta.SelectCommand = oleComm;
                            break;
                        case 8:
                            sheetName = "Privatna dugovanja rate";
                            commStr = string.Format("SELECT * FROM [{0}$]", sheetName);
                            oleComm.CommandText = commStr;
                            oleDta.SelectCommand = oleComm;
                            break;
                    }

                    //G18
                    //upisivanje OleDb u DataSet
                    try
                    {
                        dbQDS.Tables[sheetNum].Clear();
                        oleDta.Fill(dbQDS.Tables[sheetNum]);
                        dbQDS.AcceptChanges();
                    }
                    catch (ConstraintException) { }

                    //pravljenje sql komande
                    sb.Append("SET IDENTITY_INSERT " + tabName + " ON; " + "INSERT INTO " + tabName + " (");

                    int br = 0;
                    foreach(DataColumn c in dbQDS.Tables[sheetNum].Columns)
                    {
                        if(br < dbQDS.Tables[sheetNum].Columns.Count - 1)
                        {
                            sb.Append(c.ColumnName + ", ");
                        }
                        else
                        {
                            sb.Append(c.ColumnName + ") VALUES (");
                        }
                        br++;
                    }

                    br = 0;
                    foreach(DataColumn c in dbQDS.Tables[sheetNum].Columns)
                    {
                        if (br < dbQDS.Tables[sheetNum].Columns.Count - 1)
                        {
                            sb.AppendFormat("@{0}, ", c.ColumnName);
                        }
                        else
                        {
                            sb.AppendFormat("@{0}); SET IDENTITY_INSERT {1} OFF;", c.ColumnName, tabName);
                        }
                        br++;
                    }

                    sqlComm.CommandText = sb.ToString();

                    for (int r = 0; r < dbQDS.Tables[sheetNum].Rows.Count; r++)
                    {
                        for(int c = 0; c < dbQDS.Tables[sheetNum].Columns.Count; c++)
                        {
                            sqlComm.Parameters.AddWithValue("@" + dbQDS.Tables[sheetNum].Columns[c].ColumnName,
                                dbQDS.Tables[sheetNum].Rows[r][c]);
                        }
                        try
                        {
                            sqlComm.ExecuteNonQuery();
                        }
                        catch { }
                        sqlComm.Parameters.Clear();
                    }
                    sb.Clear();
                }
                sqlConn.Close();
            }
        }
    }
}
