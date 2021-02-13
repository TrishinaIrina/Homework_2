using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task_1_4();
            //Two_digit_number();
            //Logical();
            //LargestArea();
            //Density();
            //LowerCurrent(5, 8, 58, 24);
            //Column();
            //Equation();
            //AreaCircle();
            //CentimeterToMeter();
            //FullWeeks();
            //Four_digitNumber();
            //Console.WriteLine(Stunt());
            //Logical_2();

            //int a = 5;
            //int b = 7;
            //swap(ref a, ref b);
            //Console.WriteLine(a + " " + b);

            //int variable_1 = 0;
            //int variable_2 = 0;
            //Assignment(ref variable_1, ref variable_2, 4, 3);
            //Console.WriteLine(variable_1 + " " + variable_2);

            //Console.WriteLine(F(8, 9)); 
            //Console.WriteLine(SecondsFromBeginningDay(38, 25, 6));
            //Console.WriteLine(NumberOfDays(12, 9)); 
            //Console.WriteLine(DaysFromBeginningYear(3, 20));
            //Console.WriteLine(MinimumValue(88, 125, 4)); 
            //Console.WriteLine(Even(25)); 
            //Console.WriteLine(MinimumOfThree(8, 256, 55)); 
            //Rate();
            //Console.WriteLine(SumOfOdd(1, 10)); 
            //Console.WriteLine(Divisible(10, 3));
        }
        public static void Task_1_4()
        {
            //1.Составить программу вывода на экран в одну строку трех любых чисел с двумя пробелами между ними.
            Console.Write("5  10  21");

            //2.Вывести на экран числа 5, 10 и 21 одно под другим.
            Console.WriteLine("5");
            Console.WriteLine("20");
            Console.WriteLine("50");

            //3.Дано расстояние в сантиметрах.Найти число полных метров в нем.
            int a;
            Console.WriteLine("Введите расстояние в сантиметрах: ");
            a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Полных полных метров: " + (a / 100)); // "полных", поэтому преобразование типов не используем


            //4.С некоторого момента прошло 234 дня. Сколько полных недель прошло за этот период?
            DateTime date = DateTime.Now;
            Console.WriteLine("Укажите кол-во дней добавляемых к текущей дате: ");
            date = date.AddDays(Convert.ToInt32(Console.ReadLine()));
            var countWeek = (date - DateTime.Now).TotalDays / 7;
            Console.WriteLine("Через указанное кол-во дней пройдет: " + (int)countWeek + " полных недель");
        }

        public static void Two_digit_number()
        {
            //5.Дано двузначное число.Найти:
            //     a.число десятков в нем;
            //     b.число единиц в нем;
            //     c.сумму его цифр;
            //     d.произведение его цифр
            int number;
            while (true)
            {
                Console.WriteLine("Введите двузначное число: ");
                Int32.TryParse(Console.ReadLine(), out number);
                if (number < 10 || number > 99)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Введено неверное значение!");
                    Console.ResetColor();
                    Console.WriteLine("Для продолжения нажмите любую клавишу");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                else
                {
                    Console.WriteLine("число десятков: " + (number / 10));
                    Console.WriteLine("число единиц: " + (number % 10));
                    Console.WriteLine("сумма цифр: " + ((number / 10) + (number % 10)));
                    Console.WriteLine("произведение цифр: " + ((number / 10) * (number % 10)));
                    break;
                }
            }
        }

        public static void Logical(bool A = true, bool B = false, bool C = false)
        {
            //6.Вычислить значение логического выражения при следующих значениях логических величин А, В и С: 
            //А = Истина, В = Ложь, С = Ложь:
            //     a.А или В;
            //     b.А и В;
            //     c.В или С.
            Console.WriteLine("Значения: А = Истина, В = Ложь, С = Ложь");
            Console.WriteLine("Логический результат первого ИЛИ второго: " + (A || B));
            Console.WriteLine("Логический результат первого И второго: " + (A && B));
            Console.WriteLine("Логический результат второго ИЛИ третьего : " + (B || C));
        }

        public static void LargestArea(double radius = 0, double side = 0)
        {
            //7.Даны радиус круга и сторона квадрата.У какой фигуры площадь больше ?
            double Pi = 3.14;
            Console.WriteLine("введите значение радиуса круга: ");
            radius = Int32.Parse(Console.ReadLine());
            Console.WriteLine("введите значение стороны квадрата: ");
            side = Int32.Parse(Console.ReadLine());
            double AreaCircle = Pi * Math.Pow(radius, 2);
            double AreaSquare = Math.Pow(radius, 2);
            if (AreaCircle > AreaSquare)
                Console.WriteLine("Площадь круга больше");
            else if (AreaCircle < AreaSquare)
                Console.WriteLine("Площадь квадрата больше");
            else
                Console.WriteLine("Площади равны");
        }

        public static void Density(double weight_1 = 0, double volume_1 = 0, double weight_2 = 0, double volume_2 = 0)
        {
            //8.Даны объемы и массы двух тел из разных материалов.
            //Материал какого из тел имеет большую плотность ?
            Console.WriteLine("введите объем первого тела: ");
            weight_1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("введите массу первого тела: ");
            volume_1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("введите объем второго тела: ");
            weight_2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("введите массу второго тела: ");
            volume_2 = Int32.Parse(Console.ReadLine());
            if ((weight_1 / volume_1) > (weight_2 / volume_2))
                Console.WriteLine("Плотность первого тела больше");
            else if ((weight_1 / volume_1) < (weight_2 / volume_2))
                Console.WriteLine("Плотность второго тела больше");
            else
                Console.WriteLine("Плотности равны");
        }

        public static void LowerCurrent(double R_1, double U_1, double R_2, double U_2)
        {
            //9.Известны сопротивления двух несоединенных друг с другом участков электрической 
            //цепи и напряжение на каждом из них.По какому участку протекает меньший ток?
            double I_1 = U_1 / R_1;
            double I_2 = U_2 / R_2;
            if (I_1 < I_2)
                Console.WriteLine("Ток в первой цепи меньше");
            else if (I_2 < I_1)
                Console.WriteLine("Ток во второй цепи меньше");
            else
                Console.WriteLine("В обоих цепях равный ток");
        }

        public static void Column(int a = 20, int b = 35)
        {
            //10.Напечатать "столбиком":
            //a.все целые числа от 20 до 35;
            //b.квадраты всех целых чисел от 10 до b(значение b вводится с клавиатуры; b > 10);
            //c.третьи степени всех целых чисел от a до 50 (значение a вводится с клавиатуры; a< 50);
            //d.все целые числа от a до b(значения a и b вводятся с клавиатуры; b > a).

            Console.WriteLine("все целые числа от 20 до 35: ");
            for (int i = 20; i <= 35; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("введите целое число больше 10");
            b = Convert.ToInt32(Console.ReadLine());
            double result;
            Console.WriteLine("Квадраты всех целых чисел от 10 до " + b + ":");
            for (int i = 10; i <= b; i++)
            {
                result = Math.Pow(i, 2);
                Console.WriteLine(result);
            }

            Console.WriteLine("введите целое число меньше 50");
            a = Convert.ToInt32(Console.ReadLine());
            double result_2;
            Console.WriteLine("Числа от " + a + " до 50 возведенные в 3 степень");
            for (int i = a; i <= 50; i++)
            {
                result_2 = Math.Pow(i, 3);
                Console.WriteLine(result_2);
            }

            Console.WriteLine("введите целое число");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите целое число (болеше первого)");
            b = Convert.ToInt32(Console.ReadLine());
            for (int i = a; i <= b; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void Equation(int x = -1)
        {
            //11.вычисления значения функции y=7 * 𝑥^2 −3𝑥+4 при любом значении x;
            Console.WriteLine("Для вычисления функции y = 7 * x^2 - 3x + 4 введите значение х:");
            if (Int32.TryParse(Console.ReadLine(), out x))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                var y = 7 * Math.Pow(x, 2) - 3 * x + 4;
                Console.WriteLine("Результат: " + y);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Введено неверное значение");
            }
        }

        public static void AreaCircle()
        {
            //12.Дан радиус окружности. Найти длину окружности и площадь круга.
            double Pi = 3.14;
            double radius = 0;
            double length_C = 0;
            double area = 0;
            Console.WriteLine("Введите значение радиуса окружности: ");
            Double.TryParse(Console.ReadLine(), out radius);
            length_C = 2 * Pi * radius;
            area = Pi * radius * radius;
            Console.WriteLine("Длина окружности: " + length_C);
            Console.WriteLine("Площадь круга: " + area);
        }

        public static void CentimeterToMeter()
        {
            //13.Дано расстояние в сантиметрах.Найти число полных метров в нем. 1 cm = 0.01 m
            double distance;
            Console.WriteLine("Введите расстояние в сантиметрах: ");
            Double.TryParse(Console.ReadLine(), out distance);
            Console.WriteLine("Перевод в метры: " + distance * 0.01);
        }

        public static void FullWeeks()
        {
            //14.С некоторого момента прошло 234 дня.Сколько полных недель прошло за этот период?
            Console.WriteLine("Введите дату: ");
            DateTime date = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Укажите кол-во дней добавляемых к текущей дате: ");
            DateTime newDate = date.AddDays(Convert.ToInt32(Console.ReadLine()));
            var countWeek = (newDate - date).TotalDays / 7;
            Console.Write("Через указанное кол-во дней пройдет: " + (int)countWeek);
            Console.Write(" недель(и)");
        }

        public static void Four_digitNumber()
        {
            //16.Дано четырехзначное число.Найти:
            //   a.сумму его цифр;
            //   b.произведение его цифр.
            Console.WriteLine("Введите четырехзначное число: ");
            int number;
            Int32.TryParse(Console.ReadLine(), out number);
            int first = number / 1000;
            int second = (number / 100) % 10;
            int third = (number / 10) % 10;
            int fourth = number % 10;
            Console.WriteLine("Сумма его цифр: " + (first + second + third + fourth));
            Console.WriteLine("Произведение его цифр: " + (first * second * third * fourth));
        }

        public static int Stunt(int number = 456)
        {
            //17.В трехзначном числе x зачеркнули его вторую цифру. Когда к образованному при
            //этом двузначному числу справа приписали вторую цифру числа x, то получилось
            //число 456. Найти число x.
            int first = number / 100;
            int second = number / 10 % 10;
            int third = number % 10;
            return first * 100 + third * 10 + second;
        }

        public static void ForLogical_2(bool X, bool Y)
        {
            Console.WriteLine("не X и не Y =       " + (!X && !Y));
            Console.WriteLine("X или(не X и Y) =   " + (X || (!X && Y)));
            Console.WriteLine("(не X и Y) или Y =  " + ((!X && Y) || Y));
        }

        public static void Logical_2(bool X = false, bool Y = false)
        {
            //18.Вычислить значение логического выражения при всех возможных значениях
            //логических величин X и Y:
            //    a.не X и не Y;
            //    b.X или(не X и Y);
            //    c. (не X и Y) или Y.
            X = false;
            Y = false;
            Console.WriteLine("При значениях Х = false и Y = false: ");
            Console.WriteLine("*************************************");
            ForLogical_2(X, Y);
            Console.WriteLine("");
            X = true;
            Y = true;
            Console.WriteLine("При значениях Х = true и Y = true: ");
            Console.WriteLine("*************************************");
            ForLogical_2(X, Y);
            Console.WriteLine("");
            X = false;
            Y = true;
            Console.WriteLine("При значениях Х = false и Y = true: ");
            Console.WriteLine("*************************************");
            ForLogical_2(X, Y);
            Console.WriteLine("");
            X = true;
            Y = false;
            Console.WriteLine("При значениях Х = true и Y = false: ");
            Console.WriteLine("*************************************");
            ForLogical_2(X, Y);
            Console.WriteLine("");
        }

        public static void swap(ref int a, ref int b)
        {
            //19.Напишите функцию swap(int* a, int* b), которая изменяет значения параметров a и
            //b так, что новое значение a рав- но старому значению b и наоборот.
            int buf = a;
            a = b;
            b = buf;
        }

        public static void Assignment(ref int a, ref int b, int x, int y)
        {
            //21.Напишите функцию int f(int& a, int& b, int x, int y), которая присваивает объекту a
            //значение, равное x*y, а объекту b значение x/y.
            a = x * y;
            b = x / y;
        }

        public static double F(int x, int y)
        {
            //22.Напишите функцию int f(int x, int y), которая возвращает 0, если значения x и y оба
            //равны нулю, 12/x, если y равен 0, 12/y, если x равен 0, иначе 144/(x*y).
            double result = 0;
            if (x == 0 && y == 0)
            {
                return result;
            }
            else if (y == 0)
            {
                result = 12 / x;
            }
            else if (x == 0)
            {
                result = 12 / x;
            }
            else
            {
                result = 144 / (x * y);
            }
            return result;
        }

        public static int SecondsFromBeginningDay(int h, int m, int s)
        {
            //23.Напишите функцию int f(int h, int m, int s), которая принимает три целых аргумента
            //(часы h, минуты m и секунды s) и возвращает количество секунд, прошедших с
            //начала дня.
            if (h > 23 || m > 59 || s > 59)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Некорректное значение времени!");
                return 0;
            }
            return h * 3600 + m * 60 + s;
        }

        public static int NumberOfDays(int month, int day)
        {
            //24.Напишите функцию int f(int m, int d), которая принимает два целых аргумента
            //(месяц m и день d) и возвращает количество дней, прошедших с начала года.
            //Считаем, что в каждом месяце 30 дней
            if (month > 12 || day > 30)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Некорректное значение даты!");
                return 0;
            }
            return day + (month - 1) * 30; //month - 1 потому что месяц не полный(еще не закончился)
        }

        public static int DaysFromBeginningYear(int month, int day)
        {
            //25.Напишите функцию int f(int m, int d), которая принимает два целых аргумента
            //(месяц m и день d) и возвращает количество дней, прошедших с начала года.
            //Считаем, что в каждом месяце 30 или 31дней, а год не високосный.
            List<int> months = new List<int> { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (month > 12 || month == 4 && day > 30 || month == 6 && day > 30 || month == 9 && day > 30 || month == 11 && day > 30 ||
                month == 2 && day > 28 || month == 1 && day > 31 || month == 3 && day > 31 || month == 5 && day > 31 ||
                month == 7 && day > 31 || month == 8 && day > 31 || month == 9 && day > 31 || month == 11 && day > 31)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Некорректное значение даты!");
                return 0;
            }
            int result = 0;
            for (int i = 1; i < month; i++)
            {
                result += months[i];
            }
            return result + day;
        }

        public static int MinimumValue(int number_1 = 999, int number_2 = 999, int number_3 = 999, int number_4 = 999)
        {
            //26.Напишите функцию int f(int m1, int m2, int m3) с аргументами по умолчанию,
            //которая находит наименьшее из од- ного, двух или трех целых чисел (находящихся
            //в пределах от 1 до 999). Используйте условный оператор if.
            int min = 999;
            List<int> numbers = new List<int> { number_1, number_2, number_3, number_4 };
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }
            return min;
        }

        public static bool Even(int anyNumber)
        {
            //27.Напишите функцию bool even(int n), определяет четность числа n и возвращает true
            //для четного числа и false для нечетного числа.
            return (anyNumber % 2 == 0);
        }

        public static int MinimumOfThree(int number_1, int number_2, int number_3)
        {
            //28.Напишите программу, которая находит наименьшее число из заданного набора
            //трех целых чисел. Используйте условный оператор if.
            if (number_1 < number_2 && number_1 < number_3) return number_1;
            else if (number_2 < number_1 && number_2 < number_3) return number_2;
            else if (number_3 < number_1 && number_3 < number_2) return number_3;
            else
            {
                Console.WriteLine("Нет меньшего числа из трех. Два или три из них равны");
                return 0;
            }
        }

        public static void Rate()
        {
            //Напишите программу, которая с помощью функции rand() ставит оценки в
            //пределах от 2 до 5. В файл протокола направляйте слово “Неуд” при появлении 2,
            //«Удовл» при появлении 3, и т.д. Используйте оператор switch.

            List<int> students = getList(2, 5, 1, 25);   // БАГ!!!! по какой-то причине функция getList здесь не выдает оценку "5"
            int count = 1;
            foreach (var item in students)
            {
                Console.Write("Student №" + count++ + ": " + item);
                SetColor(item);
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        private static void SetColor(int rate)
        {
            switch (rate)
            {
                case 3:
                case 4:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("  (Хорошист)");
                    break;
                case 5:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("  (Отличник)");
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("  (Двоечник)");
                    break;
            }
        }

        private static List<int> getList(int numbersFrom = 1, int numbersTo = 1000, int callFrom = 1, int callTo = 1000)
        {
            List<int> numbers = new List<int>();
            Random rnd = new Random();
            for (int i = 0; i < rnd.Next(callFrom, callTo); i++)
            {
                numbers.Add(rnd.Next(numbersFrom, numbersTo));
            }
            return numbers;
        }

        private static void showList(List<int> numbers)
        {
            int dec = 0;
            foreach (int item in numbers)
            {
                if (dec % 10 == 0)
                {
                    Console.WriteLine(item + ' ');
                    dec++;
                }
                else
                {
                    Console.Write(item + ' ');
                    dec++;
                }
            }
        }

        private static int SumOfOdd(int numberFrom, int numberTo)
        {
            //30.Напишите функцию int f(int M, int N), которая вычисляет и возвращает сумму всех
            //нечетных целых чисел в пределах от M до N включительно. Используйте оператор
            //for.
            int sum = 0;
            for (int i = numberFrom; i <= numberTo; i++)
            {
                if (i % 2 != 0)
                {
                    sum += i;
                }
            }
            return sum;
        }

        private static int Divisible(int number, int divisor)
        {
            //31.Напишите функцию int f(int N, int n), которая вычисляет и возвращает наименьшее
            //из чисел, больших или равных N, которое делится нацело на n. Используйте
            //оператор while.
            int currentNumber = number;
            while (true)
            {
                if (currentNumber % divisor == 0)
                {
                    return currentNumber;
                }
                else currentNumber++;
            }
        }
    }
}

