using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication16
{
    class Program
    {
        public static void menu()
        {
            int n;
            Console.WriteLine("Choose the number of task:");
            n = Convert.ToInt32(Console.ReadLine());
            switch (n)
            {
                case 0:
                    return;
                //break;
                case 1:
                    z1();
                    break;
                case 2:
                    z2();
                    break;
                case 3:
                    z3();
                    break;
                case 4:
                    z4();
                    break;
                case 5:
                    z5();
                    break;
                case 6:
                    z6();
                    break;
                case 7:
                    z7();
                    break;
                case 8:
                    z8();
                    break;
                case 9:
                    z9();
                    break;
                case 10:
                    z10();
                    break;
                case 11:
                    z11();
                    break;
                case 12:
                    z12();
                    break;
                case 13:
                    z13();
                    break;
                case 14:
                    z14();
                    break;
                case 15:
                    z15();
                    break;
                case 16:
                    z16();
                    break;
                case 17:
                    z17();
                    break;
                case 18:
                    z18();
                    break;
                case 19:
                    z19();
                    break;
                case 20:
                    z20();
                    break;
                case 21:
                    z21();
                    break;
                case 22:
                    z22();
                    break;
                case 23:
                    z23();
                    break;
                case 24:
                    z24();
                    break;
                case 25:
                    z25();
                    break;
                case 26:
                    z26();
                    break;
                case 27:
                    z27();
                    break;
                case 28:
                    z28();
                    break;
                case 29:
                    z29();
                    break;
                case 30:
                    z30();
                    break;
                case 31:
                    z31();
                    break;
                case 32:
                    z32();
                    break;
                case 33:
                    z33();
                    break;
                case 34:
                    z34();
                    break;
                case 35:
                    z35();
                    break;
                case 36:
                    z36();
                    break;
                case 37:
                    z37();
                    break;
                case 38:
                    z38();
                    break;
                case 39:
                    z39();
                    break;
                case 40:
                    z40();
                    break;
                case 41:
                    z41();
                    break;
                case 42:
                    z42();
                    break;
                case 43:
                    z43();
                    break;
                case 44:
                    z44();
                    break;
                case 45:
                    z45();
                    break;
                case 46:
                    z46();
                    break;
                case 47:
                    z47();
                    break;
                case 48:
                    z48();
                    break;
                case 49:
                    z49();
                    break;
                case 50:
                    z50();
                    break;

            }
            menu();
        }



        static void z1()
        {
            Console.WriteLine("Задача № 1. Вывести на экран сообщение «Hello World!»");
            Console.WriteLine("Hello, world!");
        }

        static void z2()
        {
            Console.WriteLine("Задача № 2. Вывести на экран три числа в порядке, обратном вводу");
            int a, b, c;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(c + " " + b + " " + a);
        }

        static void z3()
        {
            Console.WriteLine("Задача № 3. Вывести на экран квадрат введенного числа");
            int a;
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a * a);
        }

        static void z4()
        {
            Console.WriteLine("Задача № 4. Получить реверсную запись трехзначного числа");
            int a, n, b = 0, i = 100;
            a = Convert.ToInt32(Console.ReadLine());
            while (a != 0)
            {
                n = a % 10;
                b = b + n * i;
                a = a / 10;
                i = i / 10;
            }
            Console.WriteLine(b);
        }

        static void z5()
        {
            Console.WriteLine("Задача № 5. Посчитать количество единичных битов числа");
            int a, k = 0;
            a = Convert.ToInt32(Console.ReadLine());
            while (a != 0)
            {
                if ((a % 2) == 1)
                {
                    k++;
                }
                a = a / 2;
            }
            Console.WriteLine(k);
        }

        static void z6()
        {
            Console.WriteLine("Задача № 6. Вывести на экран наибольшее из двух чисел");
            int a, b;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine(b);
            }
        }

        static void z7()
        {
            Console.WriteLine("Задача № 7. Вывести на экран наибольшее из трех чисел");
            int a, b, c;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                if (a > c) { Console.WriteLine(a); }
                else { Console.WriteLine(c); }
            }
            else
            {
                if (b > c) { Console.WriteLine(b); }
                else { Console.WriteLine(c); }
            }
        }

        static void z8()
        {
            Console.WriteLine("Задача № 8. Вывести название дня недели по его номеру");
            int a;
            a = Convert.ToInt32(Console.ReadLine());
            if (a == 1) { Console.WriteLine ("Monday"); }
            if (a == 2) { Console.WriteLine ("Tuesday"); }
            if (a == 3) { Console.WriteLine ("Wednesday"); }
            if (a == 4) { Console.WriteLine ("Thursday"); }
            if (a == 5) { Console.WriteLine ("Friday"); }
            if (a == 6) { Console.WriteLine ("Saturday"); }
            if (a == 7) { Console.WriteLine ("Sunday"); }
        }

        static void z9()
        {
            Console.WriteLine("Задача № 9. Проверить, является ли четырехзначное число палиндромом");
            int[] n = new int[4];
            for (int i = 0; i < 4; i++)
            {
                n[i] = Convert.ToInt32(Console.ReadLine());
            }
            if ((n[0] == n[3]) & (n[1] == n[2])) { Console.WriteLine("Yes"); }
            else { Console.WriteLine("No"); }
        }

       static void z10()
        {
            Console.WriteLine("Задача № 10. Проверить, является ли четырехзначное число счастливым билетом");
            int[] n = new int[4];
            for (int i = 0; i < 4; i++)
            {
                n[i] = Convert.ToInt32(Console.ReadLine());
            }
            if ((n[0] +n[1]) == (n[2] + n[3])) { Console.WriteLine("Yes"); }
            else { Console.WriteLine("No"); }
        }

        static void z11()
        {
            Console.WriteLine("Задача № 11. Проверить, является ли двоичное представление числа палиндромом");
            int a;
            string m;
            bool f = true;
            a = Convert.ToInt32(Console.ReadLine());
            m = Convert.ToString(a, 2);
            for (int i = 0; i <= m.Length / 2; i++)
            {
                if (m[i] != m[m.Length - i - 1])  f = false;
            }
            if (f) { Console.WriteLine("Yes"); }
            else { Console.WriteLine("No"); }
        }

        static void z12()
        {
            Console.WriteLine("Задача № 12. Решить квадратное уравнение");
            int a, b, c;
            double x1, x2, d;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            d = b * b - 4 * a * c;
            if (d < 0) { Console.WriteLine("No solution"); }
            else
            {
                x1 = (-b + Math.Sqrt(d)) / 2 / a;
                x2 = (-b - Math.Sqrt(d)) / 2 / a;
                Console.WriteLine(x1 + " " + x2);
            }
        }

        static void z13()
        {
            Console.WriteLine("Задача № 13. Вывести на экран все натуральные числа до заданного");
            int a;
            a = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < a; i++)
                Console.WriteLine(i);
        }

        static void z14()
        {
            Console.WriteLine("Задача № 14. Найти наибольший нетривиальный делитель натурального числа");
            int a;
            bool f = true;
            a = Convert.ToInt32(Console.ReadLine());
            for (double i = a / 2; i > 0; i--)
            {
                if ((a % i == 0) & (f))
                {
                    Console.WriteLine(i);
                    f = false;
                }
            }
        }

        static void z15()
        {
            Console.WriteLine("Задача № 15. Найти наименьший нетривиальный делитель натурального числа");
            int a;
            bool f = true;
            a = Convert.ToInt32(Console.ReadLine());
            for (double i = 2; i < a / 2; i++)
            {
                if ((a % i == 0) & (f))
                {
                    Console.WriteLine(i);
                    f = false;
                }
            }
        }

        static void z16()
        {
            Console.WriteLine("Задача № 16. Подсчитать общее число делителей натурального числа");
            int a, del = 1;
            a = Convert.ToInt32(Console.ReadLine());
            for (double i = 2; i < a / 2; i++)
            {
                if (a % i == 0)
                    del++;
            }
            Console.WriteLine(del);
        }

        static void z17()
        {
            Console.WriteLine("Задача № 17. Проверить, является ли заданное натуральное число простым");
            int a;
            bool f = true;
            a = Convert.ToInt32(Console.ReadLine());
            for (double i = 2; i < a / 2; i++)
            {
                if ((a % i == 0) && (f))
                {
                    Console.WriteLine("No");
                    f = false;
                }
            }
            if ((f)||(a == 2)) Console.WriteLine("Yes");
        }


        static void z18()
        {
            Console.WriteLine("Задача № 18. Вывести на экран все простые числа до заданного");
            int a;
            bool f = true;
            a = Convert.ToInt32(Console.ReadLine());
            for (int j = 2; j < a; j++)
            {
                for (double i = 2; i < j / 2; i++)
                {
                    if ((j % i == 0) && (f))
                    {
                        f = false;
                    }
                }
                if ((f)||(j == 2)) Console.WriteLine(j + " ");
                f = true;
            }
        }

        static void z19()
        {
            Console.WriteLine("Задача № 19. Вывести на экран первых n простых чисел");
            int a, k = 0, j = 2;
            bool f;
            a = Convert.ToInt32(Console.ReadLine());
            while (k < a)
            {
                f = true;
                for (double i = 2; i < j / 2; i++)
                {
                    if ((j % i == 0) & (f))
                    {
                        f = false;
                    }
                }
                if ((f)||(j == 2)) {
                    Console.WriteLine(j + " ");
                    k++;
                }
                j++;
            }
        }

        static void z20()
        {
            Console.WriteLine("Задача № 20. Проверить, является ли заданное натуральное число совершенным");
            int a;
            double k = 1;
            a = Convert.ToInt32(Console.ReadLine());
            for (double i = 2; i < a / 2; i++)
            {
                if (a % i == 0)
                {
                    k = k + i;
                }
            }
            if (a == k) Console.WriteLine("Yes");
            else Console.WriteLine("No");
        }

        static void z21()
        {
            Console.WriteLine("Задача № 21. Проверить, являются ли два натуральных числа дружественными");
            int a, b;
            double ka = 1, kb = 1;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            for (double i = 2; i < a / 2; i++)
            {
                if (a % i == 0)
                {
                    ka = ka + i;
                }
            }
            if (ka == b)
            {
                for (double i = 2; i < b / 2; i++)
                {
                    if (b % i == 0)
                    {
                        kb = kb + i;
                    }
                }
                if (kb == a) Console.WriteLine("Yes");
            else Console.WriteLine("No");
            }
            else Console.WriteLine("No");
        }
            

        static void z22()
        {
            Console.WriteLine("Задача № 22. Найти наибольший общий делитель двух натуральных чисел");
            int a, b, k;
            bool f = true;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            if (a > b) k = b;
            else k = a;
                for (double i = k / 2; i > 0 ; i--)
                {
                    if ((b % i == 0)&&(a % i == 0)&&(f))
                    {
                        Console.WriteLine(i);
                        f = false;
                    }
                }
            }         


        static void z23()
        {
            Console.WriteLine("Задача № 23. Найти наименьшее общее кратное двух натуральных чисел");
            int a, b, k;
            double nod = 1;
            bool f = true;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            if (a > b) k = b;
            else k = a;
            for (double i = k / 2; i > 0; i--)
            {
                if ((b % i == 0) && (a % i == 0) && (f))
                {
                    nod = i;
                    f = false;
                }
            }
            Console.WriteLine(a*b/nod);
        }


        static void z24()
        {
            Console.WriteLine("Задача № 24. Вычислить x^n");
            int a, b, c = 1;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < b; i++)
            {
                c = c * a;
            }
            Console.WriteLine(c);
        }


        static void z25()
        {
            Console.WriteLine("Задача № 25. Вычислить x^n по алгоритму быстрого возведения в степень");
            int a, b, c = 1;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            if (b % 2 == 0)
            {
                c = 1;
                for (int i = 0; i < (b / 2); i++)
                {
                    c = c * a * a;
                }
            }
            else
            {
                c = a;
                for (int i = 0; i < (b / 2); i++)
                {
                    c = c * a * a;
                }
            }
            Console.WriteLine(c);
        }
        static void z26()
        {
            Console.WriteLine("Задача № 26. Решить квадратное уравнение заданного вида с параметром");
            int n;
            double x1, x2;
            Console.WriteLine("Введите параметр а ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < (n + 1); i++)
            {
                x1 = Math.Sqrt(i * i + 3) - i;
                x2 = -i - Math.Sqrt(i * i + 3);
                Console.WriteLine("a = " + i + "; x1 = " + x1 + "; x2 = " + x2);
            }
        }
        static void z27()
        {
            int n, x;
            float res = 0, a;
            Console.WriteLine("Задача № 27. Вычислить значение многочлена в точке");
            Console.WriteLine("Введите степень многочлена");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите точку х");
            x = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < (n + 1); i++)
            {
                a = Convert.ToInt32(Console.ReadLine());
                res = res * x + a;
            }
            Console.WriteLine("Значение многочлена в точке х = " + res);
        }
        static void z28()
        {
            Console.WriteLine("Задача № 28. Вычислить факториал");
            int n, fact = 1;
            Console.WriteLine("Введите число");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                fact *= (i + 1);
            }
            Console.WriteLine("Факториал = " + fact);

        }
        static void z29()
        {
            Console.WriteLine("Задача № 29. Вычислить число сочетаний из n по k");
            int k, n, num = 1, denom = 1;
            Console.WriteLine("Введите n");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите k (k<=n)");
            k = Convert.ToInt32(Console.ReadLine());
            for (int i = n; i > (n - k); i--)
            {
                num *= i;
            }
            for (int i = 1; i < (k + 1); i++)
            {
                denom *= i;
            }
            Console.WriteLine("Число сочетаний = " + num / denom);
        }
        static void z30()
        {
            Console.WriteLine("Задача № 30. Вывести таблицу квадратов и кубов всех натуральных чисел до n");
            int n;
            Console.WriteLine("Введите n");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("x x^2 x^3");
            for (int i = 1; i < (n + 1); i++)
            {
                Console.Write(" " + i + " " + i * i + " " + i * i * i + "\n");
            }

        }
        static void z31()
        {
            Console.WriteLine("Задача № 31. Сформировать реверсную запись заданного числа");
            int r, n;
            r = 0;
            Console.WriteLine("Введите n");
            n = Convert.ToInt32(Console.ReadLine());
            while (n != 0)
            {
                r *= 10;
                r = r + n % 10;
                n /= 10;
            }
            Console.WriteLine("Реверсная запись: " + r);
        }
        static void z32()
        {
            Console.WriteLine("Задача № 32. Проверить монотонность последовательности цифр числа");
            int delta, a, b, n;
            Console.WriteLine("Введите число");
            n = Convert.ToInt32(Console.ReadLine());
            b = n % 8;
            n /= 8;
            a = n % 8;
            n /= 8;
            delta = a - b;
            while (n != 0)
            {
                b = a;
                a = n % 8;
                n /= 8;
                if (delta * (a - b) <= 0)
                {
                    break;
                }
            }
            Console.WriteLine("Монотонность: " + (delta * (a - b) > 0));
        }
        static void z33()
        {
            Console.WriteLine("Задача № 33. Получить каноническое разложение числа на простые сомножители");
            int p = 2, n;
            Console.WriteLine("Введите число:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Разложение:");
            Console.Write(n + " = 1");
            while (n != 1)
            {
                if (n % p == 0)
                {
                    Console.Write(" * " + p);
                    n /= p;
                }
                else
                {
                    p++;
                }
            }
            Console.WriteLine();

        }
        static void z34()
        {
            Console.WriteLine("Задача № 34. Сформировать число из двух заданных чередованием разрядов");
            int c = 0, z = 1, a, b;
            Console.WriteLine("Введите число а");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число b");
            b = Convert.ToInt32(Console.ReadLine());
            while (a != 0)
            {
                c = c + z * (b % 10);
                z *= 10;
                b /= 10;
                c = c + z * (a % 10);
                z *= 10;
                a /= 10;
            }
            Console.WriteLine("Число: " + c);
        }
        static void z35()
        {
            Console.WriteLine("Задача № 35. Вывести на экран x, записанное в системе счисления с основанием n");
            int x, n, y = 0, i = 1;
            x = Convert.ToInt32(Console.ReadLine());
            n = Convert.ToInt32(Console.ReadLine());
            while (x > 0)
            {
                y = y + (x % n) * i;
                x = x / n;
                i = i * 10;
            }
            Console.WriteLine(y);
        }


        static void z36()
        {
            Console.WriteLine("Задача № 36. Найти наименьший нетривиальный делитель двух заданных чисел");
            int a, b, t = 0;
            bool f = true;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            if (a < b) t = a;
            else t = b;
            for (double i = 2; i < t; i++)
            {
                if ((a % i == 0) & (b % i == 0) && (f))
                {
                    Console.WriteLine(i);
                    f = false;
                }
            }
        }


        static void z37()
        {
            Console.WriteLine("Задача № 37. Проверить, является ли натуральное число счастливым билетом");
            int a, s1 = 0, s2 = 0;
            string st;
            a = Convert.ToInt32(Console.ReadLine());
            st = a.ToString();
            char[] m = st.ToCharArray(); ;
            for (int i = 0; i < m.Length; i++)
            {
                if (i < m.Length / 2) s1 = s1 + Convert.ToInt32(m[i]);
                if (i > m.Length / 2 + 1) s2 = s2 + Convert.ToInt32(m[i]);
            }
            if (s1 == s2) { Console.WriteLine("Yes"); }
            else { Console.WriteLine("No"); }
        }


        static void z38()
        {
            Console.WriteLine("Задача № 38. Проверить, является ли натуральное число палиндромом");
            int a;
            bool f = true;
            string st;
            a = Convert.ToInt32(Console.ReadLine());
            st = a.ToString();
            char[] m = st.ToCharArray(); ;
            for (int i = 0; i < m.Length / 2; i++)
            {
                if (m[i] != m[m.Length - i - 1]) { f = false; }
            }
            if (f) { Console.WriteLine("Yes"); }
            else { Console.WriteLine("No"); }
        }


        static void z39()
        {
            Console.WriteLine("Задача № 39. Проверить, является ли натуральное число степенью двойки");
            int a;
            bool f = true;
            a = Convert.ToInt32(Console.ReadLine());
            while (a > 0)
            {
                if (a % 2 == 1) { f = false; }
                a = a / 2;
            }
            if (f) { Console.WriteLine("Yes"); }
            else { Console.WriteLine("No"); }
        }


        static void z40()
        {
            Console.WriteLine("Задача № 40. Вывести на экран произведение четных элементов заданной последовательности натуральных чисел");
            int a, b, i = 1;
            a = Convert.ToInt32(Console.ReadLine());
            b = 1;
            while (a != 0)
            {
                if (i % 2 == 0)
                {
                    b = b * a;
                }
                i++;
                a = Convert.ToInt32(Console.ReadLine());
            }
        }

        static void z41()
        {
            Console.WriteLine("Задача № 41. Вывести на экран произведение двузначных элементов последовательности натуральных чисел, которые делятся на заданное число");
            int n, a, p = 1;

            n = Int32.Parse(Console.ReadLine());
            a = Int32.Parse(Console.ReadLine());

            while (a != 0)
            {

                if ((a > 9) && (a < 100) && (a % n == 0))
                {
                    p = p * a;
                }
                a = Int32.Parse(Console.ReadLine());
            }

            if (p != 1) { Console.WriteLine(p); }
            else { Console.WriteLine("No elements"); }


        }

        static void z42()
        {
            Console.WriteLine("Задача № 42. Найти количество простых членов последовательности");
            int a, i, sch = 0;
            bool k;

            a = Int32.Parse(Console.ReadLine());
            while (a != 0)
            {
                k = true; ;
                for (i = 2; i <= a / 2; i++)
                {
                    if (a % i == 0) { k = false; }
                }
                if (k) { sch++; }
                a = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine(sch);

        }

        static void z43()
        {
            Console.WriteLine("Задача № 43. Проверить, начинается ли каждый из членов последовательности с десятичной цифры, на которую оканчивается предыдущий");
            int a, b, fst, lst;

            fst = 1;
            lst = 0;
            a = Int32.Parse(Console.ReadLine());

            b = 0;
            if (a != b) { b = Int32.Parse(Console.ReadLine()); }

            while (b != 0)
            {
                lst = a % 10;
                fst = b;
                while (fst > 9)
                {
                    fst /= 10;
                }
                if (lst != fst) { break; }
                a = b;
                b = Int32.Parse(Console.ReadLine());
            }

            if (lst == fst) { Console.WriteLine("Yes"); }
            else { Console.WriteLine("No"); }

        }

        static void z44()
        {
            Console.WriteLine("Задача № 44. Проверить, является ли последовательность пилообразной");
            int l, r, s;

            l = Int32.Parse(Console.ReadLine());
            s = Int32.Parse(Console.ReadLine());
            r = Int32.Parse(Console.ReadLine());

            while (r != 0)
            {
                if ((l - s) * (r - s) <= 0) { break; }
                l = s;
                s = r;
                r = Int32.Parse(Console.ReadLine());
            }

            if (r == 0) { r = l; }

            if ((l - s) * (r - s) > 0)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }


        }

        static void z45()
        {
            Console.WriteLine("Задача № 45. Проверить, является ли последовательность строго монотонной");
            int a, b, razn;

            a = Int32.Parse(Console.ReadLine());
            if (a != 0) { b = Int32.Parse(Console.ReadLine()); }
            else { b = 0; }

            razn = a - b;

            while (b != 0)
            {
                if (razn * (a - b) <= 0) { break; }
                a = b;
                b = Int32.Parse(Console.ReadLine());
            }
            if (a == 0) { b = 1; }
            if (b == 0) { Console.WriteLine("Yes"); }
            else { Console.WriteLine("No"); }

        }

        static void z46()
        {
            Console.WriteLine("Задача № 46. Вывести на экран n-ное число Фибоначчи");
            int f0 = 0, f1 = 1, f = 0, i, n;

            n = Int32.Parse(Console.ReadLine());

            if (n == 0) { Console.Write(0); }
            if (n == 1) { Console.Write(1); }
            for (i = 2; i <= n; i++)
            {
                f = f1 + f0;
                f0 = f1;
                f1 = f;
            }
            Console.WriteLine(f);
        }

        static void z47()
        {
            Console.WriteLine("Задача № 47. Вывести на экран сумму чисел Фибоначчи до n-ного включительно");
            int f0 = 0, f1 = 1, f, i, n, sum = 0;

            n = Int32.Parse(Console.ReadLine());

            if (n == 0) { sum = 0; }
            else { sum = 1; }

            for (i = 2; i <= n; i++)
            {
                f = f1 + f0;
                sum += f;
                f0 = f1;
                f1 = f;
            }
            Console.WriteLine(sum);
        }

        static void z48()
        {
            Console.WriteLine("Задача № 48. Вывести на экран все числа Фибоначчи до n-ного включительно");
            int f0 = 0, f1 = 1, f, i, n;


            n = Int32.Parse(Console.ReadLine());

            Console.Write(f0 + " ");
            if (n != 0) { Console.Write(f1 + " "); }
            for (i = 2; i <= n; i++)
            {
                f = f1 + f0;
                Console.Write(f + " ");
                f0 = f1;
                f1 = f;
            }
        }

        static void z49()
        {
            Console.WriteLine("Задача № 49. Проверить баланс круглых скобок в символьном выражении");
            bool flag = true;
            char ch;
            int i, n, sch = 0;
            n = Int32.Parse(Console.ReadLine());

            for (i = 0; i < n; i++)
            {
                ch = Convert.ToChar(Console.Read());

                if (ch == '(') { sch++; }
                else if (ch == ')') { sch--; }

                if (sch == -1) { flag = false; break; }
            }
            if (sch == 0) { flag = true; }
            if (!flag) { Console.WriteLine("No balance"); }
            else { Console.WriteLine("Balanced"); }

        }

        static void z50()
        {
            Console.WriteLine("Задача № 50. Вычислить экспоненту с заданной точностью");
            double exp = 1, toch, s = 1;
            int i = 1, x;

            x = Int32.Parse(Console.ReadLine());

            toch = Double.Parse(Console.ReadLine());

            while (Math.Abs(s) >= toch)
            {
                s = s * x / i;
                exp += s;
                i++;
            }

            Console.WriteLine(exp);
        }

        static void Main(string[] args)
        {
            menu();
        }
    }
}