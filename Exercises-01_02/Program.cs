namespace Exercises_01_02
{
    internal class B3
    {
        static void Main()
        {
            Ex1();
            Ex2();
            Ex3();
            Ex4();
            Ex5();
            Ex6();
        }
        /// <summary>
        /// Create a C# program to convert from degrees Celsius to Kelvin and Fareiheit
        /// </summary>
        static void Ex1()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Mời nhập vào độ C");
            string input = Console.ReadLine();
            int a;
            while (!int.TryParse(input, out a))
            {
                Console.WriteLine("Mời nhập lại");
                input = Console.ReadLine();
            }

            double c = (int)(a * 1.8 - 32);
            double b = a + 273;
            Console.WriteLine($" Độ K là: {b}");
            Console.WriteLine($" Độ F là: {c}");
        }
        /// <summary>
        /// ▸Create a program in C# for calculate the surface and volume of a sphere, given its radius
        /// </summary>
        static void Ex2()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Mời nhập vào bán kính");
            float r = float.Parse(Console.ReadLine());
            double s = 4 * Math.PI * Math.Pow(r, 2);
            double v = 4 / 3 * Math.PI * Math.Pow(r, 3);
            Console.WriteLine($"Diện tích xung quanh là: {s}, Thể tích là: {v}");
        }
        /// <summary>
        /// ▸Create a program in C# for calculate the surface and volume of a sphere, given its radius
        /// </summary>
        static void Ex3()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("A=");
            int a = int.Parse(Console.ReadLine());
            Console.Write("B=");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"Tổng: {a + b}= {a} + {b}");
            Console.WriteLine($"Hiệu: {a - b}= {a} - {b}");
            Console.WriteLine($"Tích: {a * b}= {a} * {b}");
            Console.WriteLine($"Thương: {a / b}= {a} / {b}");
            Console.WriteLine($"Mod: {a % b}= {a} % {b}");
            Console.ReadKey();
        }
        /// <summary>
        /// Write a C# Sharp program to display certain values of the function     x = y2 + 2y + 1 (using integer numbers for y, ranging from -5 to +5).
        /// </summary>
        static void Ex4()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Mời nhập vào giá trị của y từ -5 đến 5");
            for (int y = -5; y <= 5; y++)
            {
                int x = (int)(Math.Pow(y, 2) + 2 * y + 1);
                Console.WriteLine($"Giá trị của x khi y = {y} là: {x}");
            }
        }
        /// <summary>
        /// Write a C# Sharp program that takes distance and time (hours, minutes, seconds) as input and displays speed in kilometers per hour (km/h) and miles per hour (miles/h).
        /// </summary>
        static void Ex5()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Mời nhập vào khoảng cách (km)");
            double distance = double.Parse(Console.ReadLine());
            Console.WriteLine("Mời nhập vào thời gian (giờ)");
            double hours = double.Parse(Console.ReadLine());
            Console.WriteLine("Mời nhập vào thời gian (phút)");
            double minutes = double.Parse(Console.ReadLine());
            Console.WriteLine("Mời nhập vào thời gian (giây)");
            double seconds = double.Parse(Console.ReadLine());
            double totalTimeInHours = hours + minutes / 60 + seconds / 3600;
            double speedKmh = distance / totalTimeInHours;
            double speedMph = speedKmh * 0.621371; // 1 km = 0.621371 miles 
            Console.WriteLine($"Tốc độ là: {speedKmh} km/h");
            Console.WriteLine($"Tốc độ là: {speedMph} miles/h");
            Console.ReadKey();
        }
        /// <summary>
        /// Write a C# Sharp program that takes a character as input and checks if it is a vowel, a digit, or any other symbol.
        /// </summary>
        static void Ex6()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Mời nhập vào một ký tự");
            char inputChar = Console.ReadKey().KeyChar;
            Console.WriteLine();
            if ("aeiouAEIOU".Contains(inputChar))
            {
                Console.WriteLine($"{inputChar} là nguyên âm");
            }
            else if (char.IsDigit(inputChar))
            {
                Console.WriteLine($"{inputChar} là chữ số");
            }
            else
            {
                Console.WriteLine($"{inputChar} là ký tự khác");
            }
            Console.ReadKey();
        }
    }
}