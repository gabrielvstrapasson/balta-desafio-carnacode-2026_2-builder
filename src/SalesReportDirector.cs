using System;

namespace Project
{
    public class SalesReportDirector
    {
        public SalesReport BuildSalesReportPdf(ISalesReportBuilder builder, string title, DateTime start, DateTime end)
        {
            builder.SetTitle(title);
            builder.SetFormat("PDF");
            builder.AddDate(start.ToString(), end.ToString());

            builder.SetOrientation("Portrait");
            builder.SetPageSize("A4");
            builder.IncludePageNumbers(true);

            return builder.Build();
        }

        public SalesReport BuildSalesReportExcel(ISalesReportBuilder builder, string title, DateTime start, DateTime end) 
        {
            builder.SetTitle(title);
            builder.SetFormat("Excel");
            builder.AddDate(start.ToString(), end.ToString());

            return builder.Build();

        }



    }
}
