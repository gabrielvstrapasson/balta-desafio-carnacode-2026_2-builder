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

        public SalesReport BuilderCompleteReport(ISalesReportBuilder builder, string title, DateTime start, DateTime end)
        {
            builder.SetTitle(title);
            builder.SetFormat("PDF");
            builder.AddDate(start.ToString(), end.ToString());

            builder.AddHeader(true, "Relatório Corporativo");
            builder.AddFooter(true, "Confidencial");
            builder.AddCharts(true, "Bar");
            builder.SetOrientation("Landscape");
            builder.SetPageSize("A4");
            builder.IncludePageNumbers(true);
            builder.IncludeTotals(true);
            builder.SetCompanyLogo("logo.png");
            builder.SetWaterMark("Confidencial");

            return builder.Build();
        }



    }
}
