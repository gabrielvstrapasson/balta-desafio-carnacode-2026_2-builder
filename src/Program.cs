
using Project;
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Sistema de Relatórios ===");

        var builder = new SalesReportBuilder();
        var director = new SalesReportDirector();

        var salesReport1 = director.BuildSalesReportPdf(
            builder,
            "Vendas Janeiro",
            new DateTime(2024, 1, 1),
            new DateTime(2024, 1, 31)
        );

        salesReport1.Generate();

        var salesReport2 = director.BuildSalesReportExcel(
            builder,
            "Vendas Fevereiro",
            new DateTime(2024, 2, 1),
            new DateTime(2024, 2, 29)
        );

        salesReport2.Generate();
    }
}
