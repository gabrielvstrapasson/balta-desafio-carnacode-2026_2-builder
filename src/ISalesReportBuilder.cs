using System;
using System.Collections.Generic;

public interface ISalesReportBuilder
{
    void SetTitle(string title);
    void SetFormat(string format);
    void AddDate(string startDate, string endDate);
    void AddHeader(bool includeHeader, string headerText);
    void AddFooter(bool includeFooter, string footerText);
    void AddCharts(bool includeCharts, string chartType);
    void AddSummary(bool includeSummary, List<string> columns, List<string> filters);
    void SetSortBy(string sortBy);
    void SetGroupBy(string groupBy);
    void IncludeTotals(bool includeTotals); 
    void SetOrientation(string orientation);
    void SetPageSize(string pageSize);  
    void IncludePageNumbers(bool includePageNumbers);
    void SetCompanyLogo(string companyLogo);
    void SetWaterMark(string waterMark);

    SalesReport Build();

}
