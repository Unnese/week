namespace week
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] daysOfWeek = {"понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресение"};
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Здравствуйте, пользователь! Введите число от 1 до 7, чтобы узнать сколько дней осталось до выходного: ");
                int day;
                if (!int.TryParse(Console.ReadLine(), out day) || day < 1 || day > 7)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Вы ввели неправильное число.");
                    continue;
                }
                if (day == 7)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Поздравляем! Это воскресение и у вас выходной!");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"Это {daysOfWeek[day - 1]}. Осталось {7-day} дней до выходного");
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Хотите продолжить (да/нет)? ");
                if (Console.ReadLine() != "да")
                {
                    break;
                }
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("До свидания!");
            Console.ReadLine()
        }
    }
}