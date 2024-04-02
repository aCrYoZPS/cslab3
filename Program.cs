using CustomClass;
using Services;

bool run = true;
double number1;
while (run)
{
    Console.WriteLine("Введите номер задания: ");
    int task = CheckedInput.InputInt();
    switch (task)
    {
        case 1:
            Console.WriteLine("Введите число");
            number1 = CheckedInput.InputDouble();
            double z = MyClass.ProcessNumber(number1);
            Console.WriteLine($"Результат работы: {z}");
            break;
        case 2:
            Console.WriteLine("Введите число");
            number1 = CheckedInput.InputDouble();
            Services.CustMath.CalculateExpression(number1);
            break;
        case 3:
            DayOfWeek day = DateService.GetDay(CheckedInput.InputDate());
            System.Console.WriteLine($"{day}");
            break;
        case 4:
            var (iday, month, year) = CheckedInput.InputDateFromInts();
            int dur = DateService.GetDaysSpan(iday, month, year);
            if (dur != -1)
            {
                System.Console.WriteLine($"{dur}");
            }
            else
            {
                System.Console.WriteLine("Неверная дата");
            }
            break;
        default:
            System.Console.WriteLine("Несуществующее задание");
            break;
    }
    Console.WriteLine("Продолжить выполнение?[y/n]");
    run = CheckedInput.ExitHandler();
    Console.WriteLine();
}
