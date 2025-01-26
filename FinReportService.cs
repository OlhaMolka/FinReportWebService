using FinReportWebService.Models;
using System;

namespace FinReportWebService.Services
{
    public class FinReportService
    {
        // ����� ��� ��������� ������ ID ����
        public int[] GetReportIdArray(DateTime dateBegin, DateTime dateEnd)
        {
            // ����� ��� ��������� ���� �� ����� ���� (���������, ���� �����)
            return new int[] { 357, 358, 360, 361 };
        }

        // ����� ��� ��������� ���� �� ID
        public FinReport GetReport(int reportID)
        {
            // ����� ��� ��������� ����������� ���� (���������, � ���� �����)
            return new FinReport
            {
                ReportID = reportID,
                Date = new DateTime(2015, 03, 15),
                Info = "Some info"
            };
        }
    }
}
