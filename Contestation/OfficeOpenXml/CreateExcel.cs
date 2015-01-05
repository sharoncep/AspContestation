using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOpenXml.Style;
using System.Drawing;
using OfficeOpenXml.Drawing;

namespace OfficeOpenXml
{
    public static class CreateExcelClass
    {
        /// <summary>
        /// http://zeeshanumardotnet.blogspot.in/2010/08/creating-advanced-excel-2007-reports-on.html
        /// http://zeeshanumardotnet.blogspot.in/2011/06/creating-reports-in-excel-2007-using.html
        /// </summary>
        /// <param name="sheetName"></param>
        /// <param name="dt"></param>
        /// <param name="FilePath"></param>
        /// <returns></returns>
        public static string CreateSheet(string sheetName, DataTable dt, string FilePath, string imagePath)
        {
            using (ExcelPackage p = new ExcelPackage())
            {

                List<int> maximumLengthForColumns =
                        Enumerable.Range(0, dt.Columns.Count)
                        .Select(col => dt.AsEnumerable()
                        .Select(row => row[col].ToString().Trim())
                        .Max(val => val.Length < dt.Columns[col].ColumnName.Length ? dt.Columns[col].ColumnName.Length : val.Length)).ToList();

                //Here setting some document properties
                p.Workbook.Properties.Author = "Ariva Meddata Infotech";
                p.Workbook.Properties.Title = sheetName;

                //Create a sheet
                p.Workbook.Worksheets.Add(sheetName);
                ExcelWorksheet ws = p.Workbook.Worksheets[1];
                ws.Name = sheetName; //Setting Sheet's name
                ws.Cells.Style.Font.Size = 11; //Default font size for whole sheet
                ws.Cells.Style.Font.Name = "Calibri"; //Default Font name for whole sheet

                //string imagePath = string.Concat(AppDomain.CurrentDomain.BaseDirectory, "Images\\freedom.jpg");

                //DataTable dt = CreateDataTable(); //My Function which generates DataTable

                //Merging cells and create a center heading for out table
                //ws.Cells[7, 1].Value = "Sample DataTable Export";
                //ws.Cells[7, 1, 7, dt.Columns.Count].Merge = true;
                //ws.Cells[7, 1, 7, dt.Columns.Count].Style.Font.Bold = true;
                //ws.Cells[7, 1, 7, dt.Columns.Count].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                int colIndex = 1;
                int rowIndex = 7;
                int maxLen = 0;
                foreach (DataColumn dc in dt.Columns) //Creating Headings
                {
                    var cell = ws.Cells[rowIndex, colIndex];
                    cell.Style.Font.Bold = true;
                    cell.Style.Font.Size = 13;
                    ws.Column(colIndex).Width = maximumLengthForColumns[maxLen] + 3;
                    // ws.Column(colIndex).Width = maximumLengthForColumns[maxLen] > dc.ColumnName.Length ? maximumLengthForColumns[maxLen] + 5 : dc.ColumnName.Length + 5;
                    //Setting the background color of header cells to Gray
                    //var fill = cell.Style.Fill;
                    //fill.PatternType = ExcelFillStyle.None;
                    //fill.BackgroundColor.SetColor(Color.White);


                    //Setting Top/left,right/bottom borders.
                    var border = cell.Style.Border;
                    border.Bottom.Style = border.Top.Style = border.Left.Style = border.Right.Style = ExcelBorderStyle.Thin;

                    //Setting Value in cell
                    cell.Value = dc.ColumnName;

                    colIndex++;
                    maxLen++;
                }

                foreach (DataRow dr in dt.Rows) // Adding Data into rows
                {
                    colIndex = 1;
                    rowIndex++;

                    foreach (DataColumn dc in dt.Columns)
                    {
                        var cell = ws.Cells[rowIndex, colIndex];
                        //Setting Value in cell
                        cell.Value = dr[dc.ColumnName];

                        //Setting borders of cell
                        var border = cell.Style.Border;
                        border.Left.Style =
                            border.Right.Style = ExcelBorderStyle.Thin;
                        colIndex++;

                        var dataBorder = cell.Style.Border;
                        border.Bottom.Style =
                        border.Top.Style =
                        border.Left.Style =
                        border.Right.Style = ExcelBorderStyle.None;
                    }
                }

                AddImage(ws, 0, 1, imagePath);

                //Generate A File
                Byte[] bin = p.GetAsByteArray();
                string file = FilePath + ".xlsx";
                File.WriteAllBytes(file, bin);
                return file;
            }
        }

        private static void AddImage(ExcelWorksheet ws, int columnIndex, int rowIndex, string filePath)
        {
            //How to Add a Image using EP Plus
            Bitmap image = new Bitmap(filePath);
            ExcelPicture picture = null;
            if (image != null)
            {
                picture = ws.Drawings.AddPicture("pic" + rowIndex.ToString() + columnIndex.ToString(), image);
                picture.From.Column = columnIndex;
                picture.From.Row = rowIndex;
                //picture.From.ColumnOff = Pixel2MTU(2); //Two pixel space for better alignment
                //picture.From.RowOff = Pixel2MTU(2);//Two pixel space for better alignment
                //picture.SetSize(100, 100);
            }
        }


    }
}
