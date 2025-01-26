using FinReportWebService.Models;
using FinReportWebService.Services;
using Microsoft.AspNetCore.Mvc;
using System;

namespace FinReportWebService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FinReportController : ControllerBase
    {
        private readonly FinReportService _finReportService;

        public FinReportController()
        {
            _finReportService = new FinReportService(); // ����������� ������
        }

        // ����� ��� ��������� ������ ID ����
        [HttpGet("reportIds")]
        public ActionResult<int[]> GetReportIds(DateTime dateBegin, DateTime dateEnd)
        {
            var reportIds = _finReportService.GetReportIdArray(dateBegin, dateEnd);
            return Ok(reportIds);
        }

        // ����� ��� ��������� ���� �� ID
        [HttpGet("report/{reportID}")]
        public ActionResult<FinReport> GetReport(int reportID)
        {
            var report = _finReportService.GetReport(reportID);
            if (report == null)
            {
                return NotFound();
            }
            return Ok(report);
        }
    }
}
