using System;

namespace FinReportWebService.Models
{
    public class FinReport
    {
        public int ReportID { get; set; }
        public DateTime Date { get; set; }
        public required string Info { get; set; }
    }
}

