using System.Collections.Generic;
using System.Reflection.Emit;

//Basic.Ketma - ketlik bo'limi uchun 3-amaliy vazifa

//1)Tub sonlar: Foydalanuvchidan kiritilgan sonning tub son ekanligini tekshiruvchi dastur tuzing. Agar kiritilgan son tub bo'lsa, "Tub" degan xabar chiqaring, aks holda "Tub emas" degan xabar chiqaring. 
//Input = 7;
//Output = “Tub”

internal class Program

{

    static void Main(string[] args)

    {

        Console.Write("N  sonini kiriting: (input):");

        string N = Console.ReadLine();

        int N1 = Convert.ToInt32(N);
        int sanoq = 0;
        int i = 1;
        while (i <= N1)
        {
            if (N1 % i == 0)
                sanoq++;
            i++;
        }
        if (sanoq == 2)
        {
            Console.WriteLine("Kiritgan soningiz :Tub!");
        }

        else if (sanoq != 2)
        {
            Console.WriteLine("Kiritgan soningiz :Tub emas!");
        }

    }

//2) Bo'luvchisiz sonlar: Foydalanuvchidan son qabul qilib, shu sonni 2 dan boshlab 10 gacha bo'lgan bo'luvchilarini hisoblovchi dastur yozing. Natijani ekranga chiqaring. Input = 20; 
//Output = "Bo'luvchilari: 2, 4, 5, 10"

internal class Program

    {

        static void Main(string[] args)

        {

            Console.Write("N  sonini kiriting: (input):");

            string N = Console.ReadLine();

            int N1 = Convert.ToInt32(N);
            int startN2 = 2;
            int finishN2 = 10;
            Console.WriteLine("Natija:");
            for (int i = startN2; i <= finishN2; i++)
            {
                if (N1 % i == 0)
                    Console.Write($"{i} ");
            }
        }

    }
//3)Daraja hisoblash: Foydalanuvchidan son va uning darajasini qabul qilib, berilgan sonni berilgan darajaga ko'taradigan dastur tuzing. Daraja musbat butun son bo'lishi kerak.
//Input = 3, 4;
//    Output = 81

internal class Program

    {

        static void Main(string[] args)

        {

            Console.Write("N1  sonini kiriting: (input):");

            string N = Console.ReadLine();

            int N1 = Convert.ToInt32(N);

            Console.Write("N2 (N1 ni darajasini) kiriting: (input):");

            string N2 = Console.ReadLine();

            int N3 = Convert.ToInt32(N2);
            double N4 = 1;

            Console.Write("Natija:");
            for (int i = 0; i < N3; i++)
            {
                N4 = N4 * N1;

            }


            Console.Write($" output: {N4} ");

        }

    }




//4)Harajatlar to'plamini hisoblash: Foydalanuvchidan bir nechta to'plam miqdorlar kiritilgan holda, ularni qo'shib yig'indisini hisoblovchi dastur yozing va natijani ekranga chiqaring.
//Input = [150, 230, 80, 120];
//    Output = 580

internal class Program

    {

        static void Main(string[] args)

        {

            int[] arr = [150, 230, 80, 120];

            int summa = 0;

            for (int i = 0; i < arr.Length; i++)
            {

                summa += arr[i];


            }

            Console.WriteLine($"Summa natija:{summa}");
        }

    }



//5)Armstrong sonlar: Foydalanuvchidan son qabul qilib, shu sonni Armstrong son ekanligini aniqlang.Armstrong son, raqamlarining darajasiga mos keladigan sonlardir.Masalan: 
//Input = 153;
//    Output = "153 Armstrong son" 
//153 raqamining raqamlarini darajaga olib, o'lchamalarga ko'paytirib qo'ygan holda, 1^3 + 5^3 + 3^3 = 1 + 125 + 27 = 153 bo'ladi.Bu sababli, 153 raqami Armstrong son hisoblanadi.


amespace ConsoleApp11
{
    internal class Program

    {

        static void Main(string[] args)

        {

            Console.Write("N1  sonini kiriting: (input):");

            string N = Console.ReadLine();

            int N1 = Convert.ToInt32(N);
            int count = 0; /// Honalar soni
            int kv = 1;
            int summa = 0;
            int N2 = 0;
            int N3 = N1;
            int armstrong = N3;

            while (N1 >= 1)
            {

                N1 = N1 / 10;
                count++;

            }

            while (N3 >= 1)

            {
                N2 = N3 % 10;

                for (int i = 0; i < count; i++)
                {
                    kv *= N2;
                }
                N3 = N3 / 10;

                summa += kv;
                kv = 1;
            }


            if (summa == armstrong)
                Console.WriteLine($"Kirtilgan son {armstrong} armstrong soni! ");
            else Console.WriteLine($"Kirtilgan son {armstrong} armstrong soni emas! ");
        }

    }
}




//6)Sifatli bo'luvchilar: Foydalanuvchidan son qabul qilib, shu sonni nechta sifatli bo'luvchilarini hisoblang. Sifatli bo'luvchilar, faqat bittadan o'zidan keyincha bo'lan sonlar hisoblanadi. Masalan: 
//Input = 20;
//Output = 4
//20 raqamining sifatli bo'luvchilari 1, 2, 4, va 5 sonlari hisoblanadi.
namespace ConsoleApp11
{
    internal class Program

    {

        static void Main(string[] args)

        {
            Console.Write("N1  sonini kiriting: (input):");

            string N = Console.ReadLine();

            int N1 = Convert.ToInt32(N);
            int i = 1;
            int count = 0;
            while (N1 >= i)
            {
                if (N1 % i == 0 && i < N1 / 2)
                {
                    count++;
                    Console.WriteLine($" Sonlar  {i}");
                }
                i++;

            }

            Console.WriteLine($" Sonlar miqdori {count}");
        }
    }
}
