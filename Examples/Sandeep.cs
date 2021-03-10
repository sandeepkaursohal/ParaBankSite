using System;
using System.Collections.Generic;
using System.Text;
using excel = Microsoft.Office.Interop.Excel;


namespace ParaBankSite.Examples
{
    class Sandeep
    {
        public void Excel(string rgs)
        {
            excel.Application x1app = new excel.Application();

            excel.Workbook x1workbook = x1app.Workbooks.Open("");

            excel._Worksheet x1worksheet = (excel._Worksheet)x1workbook.Sheets[1];

            excel.Range x1range = x1worksheet.UsedRange;

            string website;

            for (int i=1;i<=3;i++)
            {
                website = x1range.Cells[i,1].value2;

            }

        }
    }
}
