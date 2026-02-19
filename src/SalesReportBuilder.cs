
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

public class SalesReportBuilder : ISalesReportBuilder
{
    private readonly SalesReport _salesReport;

    public SalesReportBuilder(SalesReport salesReport)
    {
        _salesReport = salesReport;
    }
    public SalesReportBuilder()
    {
        _salesReport = new SalesReport();
    }

    public void AddCharts(bool includeCharts, string chartType)
    {
        _salesReport.IncludeCharts = includeCharts;
        if (includeCharts) _salesReport.ChartType = chartType;
    }

    public void AddDate(string startDate, string endDate)
    {
        if (DateTime.TryParse(startDate, out var start)) 
            _salesReport.StartDate = start;

        if (DateTime.TryParse(endDate, out var end))
            _salesReport.EndDate = end;
    }

    public void AddFooter(bool includeFooter, string footerText)
    {
        _salesReport.IncludeFooter = includeFooter;
        if (includeFooter) _salesReport.FooterText = footerText;
    }

    public void AddHeader(bool includeHeader, string headerText)
    {
        _salesReport.IncludeHeader = includeHeader;
        if (includeHeader) _salesReport.HeaderText = headerText;
    }

    public void AddSummary(bool includeSummary, List<string> columns, List<string> filters)
    {
        _salesReport.IncludeSummary = includeSummary;
        if (includeSummary)
        {
            _salesReport.Columns = columns;
            _salesReport.Filters = filters;
        }
    }

    public SalesReport Build() => _salesReport;

    public void IncludePageNumbers(bool includePageNumbers)
    {
        _salesReport.IncludePageNumbers = includePageNumbers;
    }

    public void IncludeTotals(bool includeTotals)
    {
        _salesReport.IncludeTotals = includeTotals;
    }

    public void SetCompanyLogo(string companyLogo)
    {
        _salesReport.CompanyLogo = companyLogo;
    }

    public void SetFormat(string format)
    {
        _salesReport.Format = format;
    }

    public void SetGroupBy(string groupBy)
    {
        _salesReport.GroupBy = groupBy;
    }

    public void SetOrientation(string orientation)
    {
        _salesReport.Orientation = orientation;
    }

    public void SetPageSize(string pageSize)
    {
        _salesReport.PageSize = pageSize;
    }

    public void SetSortBy(string sortBy)
    {
        _salesReport.SortBy = sortBy;
    }

    public void SetTitle(string title)
    {
        _salesReport.Title = title;
    }

    public void SetWaterMark(string waterMark)
    {
        _salesReport.WaterMark = waterMark;
    }

    
}