
using Project;
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Sistema de Relatórios ===");

        var builder = new SalesReportBuilder();
        var director = new SalesReportDirector();

        var salesReport = director.BuildSalesReportPdf(
            builder,
            "Vendas Janeiro",
            new DateTime(2024, 1, 1),
            new DateTime(2024, 1, 31)
        );

        salesReport.Generate();
    }
}
