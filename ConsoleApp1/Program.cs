using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           // задание 1.a
            bool bl = true;
            byte bt = 255;
            sbyte sbt = -128;
            short srt = -32768;
            ushort usrt = 65535;
            int it = -2147483648; //fasfasfa
            uint uit = 4294967295;
            long lng = -9223372036854775808;
            ulong ulng = 18446744073709551615;
            double flt = -12.423e12;
            decimal dsml = 12.424123M;
            char ct = 'a';
            string str = "SDf";
            object obj = 22;
            // задание 1.b
            int sd = it;
            short qd = srt;
            long we = lng;
            byte asc = bt;
            string jy = str;
            int gt = (int)(sd - it);
            short ht = (short)(qd - srt);
            uint uitb = 4294967295;
            long lngkj = -9223372036854775808;
            ulong ulngk = 18446744073709551615;
            //задание 1.c
            int khk = 5;
            object o = khk;
            byte s = (byte)(int)o;
            //задание 1.d
            dynamic ewt = "14";
            dynamic gd = 14;
            Console.WriteLine((dynamic)(ewt + gd + 1.32));
            //задание 1.e
            int? sdda = null; // в обычном виде значимый тип не модет принимать null
            //задание 2.a
            Console.WriteLine();
            Console.WriteLine();
            string dfsa = "sgdgafas";
            string kjh = "cvnsde";
            string lcdv = "s.d.v.sv";
            Console.WriteLine(String.Compare(dfsa, kjh));
            //задание 2.b
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(dfsa + kjh);
            string vsd = String.Copy(kjh);
            Console.WriteLine(vsd);
            Console.WriteLine(vsd.Substring(2, 4));
            string[] dfaf = lcdv.Split(new char[] { '.' });
            foreach (string sl in dfaf)
            {
            Console.WriteLine(sl);
            }
            Console.WriteLine(kjh.Insert(4, lcdv));
            Console.WriteLine(lcdv.Remove(0, 5));
            //задание 2.c
            Console.WriteLine();
            Console.WriteLine();
            string kkf = "";
            string dfcb = null;
            Console.WriteLine(String.Compare(kkf, dfcb));
            Console.WriteLine(kkf + dfcb);
            //задание 2.d
            Console.WriteLine();
            Console.WriteLine();
            StringBuilder vbxd = new StringBuilder("SASAsdsdvcvsvsv", 49);
            Console.WriteLine(vbxd);
            vbxd.Remove(5, 5);
            vbxd.Append("scsvd");
            Console.WriteLine(vbxd);
            // задание 3.a
            int[,] a = { { 1, 2, 3 }, { 4, 5, 6 } };
            foreach(int i in a)
            {               
                Console.Write(i);
                if(i == 3)
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            //задание 3.b
            string[] b = { "one", "two", "three", "four", "five"};
            foreach (string i in b)
            {           
                Console.WriteLine(i);
            }
            Console.WriteLine("Length = " + b.Length);
            Console.WriteLine("write number and value");
            int number = Convert.ToInt32(Console.ReadLine()) - 1;
            b[number] = Console.ReadLine();
            foreach (string i in b)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            Console.WriteLine();
            //задание 3.c
            int[][] c = { new int[2], new int[3], new int[4] };
            Console.WriteLine("write value");
            for (int i = 0; i < 2; i++){
                c[0][i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("write value");
            for (int i = 0; i < 3; i++)
            {
                c[1][i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("write value");
            for (int i = 0; i < 4; i++)
            {
                c[2][i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine();
            //задание 3.d
            dynamic[] e = { "fasf", 3, 1.34, "wewer" };
            foreach (dynamic i in e)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            Console.WriteLine();
            //задание 4.a
            (int, string, char, string, ulong) person = (134, "fdgdfga", 's', "gdssasa", 34071203859837128);
            (int, string, char, string, ulong) persons = (134, "fdgdfga", 's', "gdssasa", 3407120);

            //задание 4.b
            Console.WriteLine($"{person}");
            Console.WriteLine("{0} {1} {2}", person.Item1, person.Item2, person.Item4);
            //задание 4.c
            Console.WriteLine();
            Console.WriteLine();
            (var sool, var fd) = (132, "234");
            Console.WriteLine("{0}, {1}", sool, fd);
            //задание 4.d
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(person == persons);
            //задание 5
            (int, int, char) funn(int[] j, string L){
                return (j.Max(), j.Min(), L[0]);
            }
            int[] sdp = { 7, 8, 9, 12, 13 };
            dynamic dfg = funn(sdp, "ktfjtcgg");
            Console.WriteLine($"{dfg}");
            Console.ReadLine();
        }
    }
}
