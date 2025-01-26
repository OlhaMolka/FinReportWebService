using FinReportWebService.Models;
using System;

namespace FinReportWebService.Services
{
    public class FinReportService
    {
        // Метод для отримання масиву ID звітів
        public int[] GetReportIdArray(DateTime dateBegin, DateTime dateEnd)
        {
            // Логіка для отримання звітів на основі дати (наприклад, бази даних)
            return new int[] { 357, 358, 360, 361 };
        }

        // Метод для отримання звіту за ID
        public FinReport GetReport(int reportID)
        {
            // Логіка для отримання конкретного звіту (наприклад, з бази даних)
            return new FinReport
            {
                ReportID = reportID,
                Date = new DateTime(2015, 03, 15),
                Info = "Some info"
            };
        }
    }
}
