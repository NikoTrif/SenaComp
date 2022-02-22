using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace iflib
{
    public static class OfficeIE
    {
        public static class Excel
        {
            /// <summary>
            /// Brzo eksportuje bazu u Excel XLS fajl. Koristi Progress bar i 2 label-a iz željenog Form-a
            /// </summary>
            /// <param name="styleName">Može biti bilo šta, pojavljivaće se u Excel Stilovima, najbolje da bude naziv programa</param>
            /// <param name="vidljivostExcela">U cilju debug-a koda koristi TRUE. Koristi FALSE kada je kod spreman</param>
            /// <param name="savePath">Putanja za čuvanje</param>
            /// <param name="ds">Dataset prethodno napunjen podacima: using (var tMojaTabela = new dbDataSetTableAdapter()){tMojaTabela.Fill(mojDataSet )}</param>
            /// <param name="pb">Progress Bar iz Forme koja ga prikazuje</param>
            /// <param name="l1">Label koji prikazuje progres. Npr. 1 / 100</param>
            /// <param name="l2">Label koji prikazuje proces. Izvoz podataka u Excel tabelu. Ne mora se unositi ako ga nema</param>
            public static void ExportToExcel(string styleName, bool vidljivostExcela, string savePath, DataSet ds, ProgressBar pb,
                 System.Windows.Forms.Label l1, System.Windows.Forms.Label l2 = null)
            {
                pb.Minimum = 0;
                pb.Maximum = 0;
                pb.Step = 1;

                foreach (System.Data.DataTable dt in ds.Tables)
                {
                    pb.Maximum = pb.Maximum + dt.Rows.Count;
                }

                if (l2 != null)
                {
                    l2.Text = "Izvoz podataka u Excel tabelu";
                }
                l1.Text = string.Format("{0} / {1}", pb.Minimum, pb.Maximum);
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
                        l1.Text = string.Format("{0} / {1}", pb.Value, pb.Maximum);
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

                    exWorkSheet.Name = dt.TableName; //promena naziva Sheeta
                    if (iTab != ds.Tables.Count - 1)
                    {
                        exWorkBook.Sheets.Add(After: exWorkBook.Sheets[exWorkBook.Sheets.Count]); //dodavanje novog sheeta
                        exWorkSheet = exWorkBook.Sheets[exWorkBook.Sheets.Count]; //da sledeci bude aktivan 

                        iTab++;
                        iCol = 1;
                    }
                }

                exWorkSheet = exWorkBook.Sheets[1];
                exWorkSheet.Activate();

                exWorkBook.SaveAs(savePath, XlFileFormat.xlExcel8); //cuvanje kao xls sa unicode karakterima
                exWorkBook.Close(true);
                excel.Quit();

                System.Runtime.InteropServices.Marshal.ReleaseComObject(exWorkSheet);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(exWorkBook);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(excel);
            }

            public static void ImportFromExcel(DataSet ds, string conString, string fileName, ProgressBar pb,
                 System.Windows.Forms.Label l1, System.Windows.Forms.Label l2 = null)
            {
                if (MessageBox.Show("OPREZ!\nUkoliko vratite ovu bazu podataka,a baza koja se trenutno koristite će biti" +
                    " obrisana!\nDa li ste sigurni da želite da nastavite?",
                    "PAŽNJA!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    pb.Style = ProgressBarStyle.Marquee;
                    l2.Text = "Uvoz baze podataka iz Excel tabela";
                    l1.Visible = false;

                    string sheetName = string.Empty;
                    string connStr = $"Provider=Microsoft.Jet.Oledb.4.0;Data Source={fileName};Extended Properties=Excel 8.0;";
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

                    for (int sheetNum = 0; sheetNum < ds.Tables.Count; sheetNum++)
                    {
                        //Brisanje tabele u bazi
                        tabName = ds.Tables[sheetNum].TableName;
                        commStr = $"TRUNCATE TABLE {tabName}";
                        sqlComm.CommandText = commStr;
                        sqlComm.ExecuteNonQuery();

                        //upisivanje u OleDB kada su nazivi Sheet-ova isti kao nazivi tabela u DataSet-u
                        commStr = $@"SELECT * FROM [{ds.Tables[sheetNum].TableName}$]";
                        oleComm.CommandText = commStr;
                        oleDta.SelectCommand = oleComm;

                        //upisivanje u OleDB kada nazivi Sheet-ova nisu isti kao nazivi tabela u DataSet-u
                        //switch (sheetNum)
                        //{
                        //    case 0:
                        //        sheetName = "Artikli";
                        //        commStr = string.Format("SELECT * FROM [{0}$]", sheetName);
                        //        oleComm.CommandText = commStr;
                        //        oleDta.SelectCommand = oleComm;
                        //        break;
                        //    case 1:
                        //        sheetName = "Privatni prihod";
                        //        commStr = string.Format("SELECT * FROM [{0}$]", sheetName);
                        //        oleComm.CommandText = commStr;
                        //        oleDta.SelectCommand = oleComm;
                        //        break;
                        //    case 2:
                        //        sheetName = "Privatna dugovanja";
                        //        commStr = string.Format("SELECT * FROM [{0}$]", sheetName);
                        //        oleComm.CommandText = commStr;
                        //        oleDta.SelectCommand = oleComm;
                        //        break;
                        //    case 3:
                        //        sheetName = "Poslovni izlaz";
                        //        commStr = string.Format("SELECT * FROM [{0}$]", sheetName);
                        //        oleComm.CommandText = commStr;
                        //        oleDta.SelectCommand = oleComm;
                        //        break;
                        //    case 4:
                        //        sheetName = "Privatni trošak";
                        //        commStr = string.Format("SELECT * FROM [{0}$]", sheetName);
                        //        oleComm.CommandText = commStr;
                        //        oleDta.SelectCommand = oleComm;
                        //        break;
                        //    case 5:
                        //        sheetName = "Poslovni ulaz";
                        //        commStr = string.Format("SELECT * FROM [{0}$]", sheetName);
                        //        oleComm.CommandText = commStr;
                        //        oleDta.SelectCommand = oleComm;
                        //        break;
                        //    case 6:
                        //        sheetName = "Poslovni ulaz rate";
                        //        commStr = string.Format("SELECT * FROM [{0}$]", sheetName);
                        //        oleComm.CommandText = commStr;
                        //        oleDta.SelectCommand = oleComm;
                        //        break;
                        //    case 7:
                        //        sheetName = "Poslovni izlaz rate";
                        //        commStr = string.Format("SELECT * FROM [{0}$]", sheetName);
                        //        oleComm.CommandText = commStr;
                        //        oleDta.SelectCommand = oleComm;
                        //        break;
                        //    case 8:
                        //        sheetName = "Privatna dugovanja rate";
                        //        commStr = string.Format("SELECT * FROM [{0}$]", sheetName);
                        //        oleComm.CommandText = commStr;
                        //        oleDta.SelectCommand = oleComm;
                        //        break;
                        //}

                        //G18
                        //upisivanje OleDb u DataSet
                        try
                        {
                            ds.Tables[sheetNum].Clear();
                            oleDta.Fill(ds.Tables[sheetNum]);
                            ds.AcceptChanges();
                        }
                        catch (ConstraintException) { }

                        //pravljenje sql komande
                        sb.Append("SET IDENTITY_INSERT " + tabName + " ON; " + "INSERT INTO " + tabName + " (");

                        int br = 0;
                        foreach (DataColumn c in ds.Tables[sheetNum].Columns)
                        {
                            if (br < ds.Tables[sheetNum].Columns.Count - 1)
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
                        foreach (DataColumn c in ds.Tables[sheetNum].Columns)
                        {
                            if (br < ds.Tables[sheetNum].Columns.Count - 1)
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

                        for (int r = 0; r < ds.Tables[sheetNum].Rows.Count; r++)
                        {
                            for (int c = 0; c < ds.Tables[sheetNum].Columns.Count; c++)
                            {
                                sqlComm.Parameters.AddWithValue("@" + ds.Tables[sheetNum].Columns[c].ColumnName,
                                    ds.Tables[sheetNum].Rows[r][c]);
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
}
