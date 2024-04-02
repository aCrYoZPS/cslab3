namespace Services
{
    public class CheckedInput
    {
        public static double InputDouble()
        {
            double number = 0;
            bool input = true;
            while (input)
            {
                bool correctInput = double.TryParse(Console.ReadLine(), out number);
                if (correctInput)
                {
                    input = false;
                }
                else
                {
                    Console.WriteLine("Неверный ввод");
                }
            }
            return number;
        }
        public static int InputInt()
        {
            int number = 0;
            bool input = true;
            while (input)
            {
                bool correctInput = int.TryParse(Console.ReadLine(), out number);
                if (correctInput)
                {
                    input = false;
                }
                else
                {
                    Console.WriteLine("Неверный ввод");
                }
            }
            return number;
        }
        public static bool ExitHandler()
        {
            char ch;
            bool input = true, res = false;
            while (input)
            {
                ch = Console.ReadKey().KeyChar;
                switch (ch)
                {
                    case 'y':
                    case 'Y':
                        res = true;
                        input = false;
                        break;
                    case 'n':
                    case 'N':
                        res = false;
                        input = false;
                        break;
                    default:
                        System.Console.WriteLine("Неизвестная команда");
                        break;
                }
            }
            return res;
        }
        public static string? InputDate()
        {
            bool input = true;
            DateTime dt;
            string? inp = "dummytext";
            while (input)
            {
                Console.WriteLine("Введите дату в формате дд.мм.гггг.");
                inp = Console.ReadLine();
                if (!DateTime.TryParseExact(
                        inp, "dd.MM.yyyy",
                        System.Globalization.CultureInfo.InvariantCulture,
                        System.Globalization.DateTimeStyles.None, out dt) ||
                    inp is null)
                {
                    Console.WriteLine("Неверный формат даты.");
                }
                else
                {
                    input = false;
                }
            }
            return inp;
        }
        public static (int, int, int) InputDateFromInts()
        {
            bool input = true;
            int iday = 1, month = 1, year = 1970;
            DateTime? res = new DateTime(1970, 1, 1);
            while (input)
            {
                Console.WriteLine("Введите день");
                iday = CheckedInput.InputInt();
                Console.WriteLine("Введите месяц");
                month = CheckedInput.InputInt();
                Console.WriteLine("Введите год");
                year = CheckedInput.InputInt();
                try
                {
                    res = new DateTime(year, month, iday);
                }
                catch
                {
                    res = null;
                    Console.WriteLine("Неверный формат даты.");
                }
                if (res != null)
                {
                    input = false;
                }
            }
            return (iday, month, year);
        }
    }
}
