namespace Services
{
    public class DateService
    {
        public static DayOfWeek GetDay(string date)
        {
            return DateTime.Parse(date).DayOfWeek;
        }
        public static int GetDaysSpan(int day, int month, int year)
        {
            DateTime argDate = new DateTime();
            argDate = new DateTime(year, month, day);
            if (argDate > DateTime.Today)
            {
                return argDate.Subtract(DateTime.Today).Days;
            }
            else
            {
                return DateTime.Today.Subtract(argDate).Days;
            }
        }
    }
}
