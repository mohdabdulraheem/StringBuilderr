using System;
using System.Text;

namespace StringBuilderr
{
    public class Program
    {


        public static void Main()
        {
            //StringBuilder Initialization
            StringBuilder sb1 = new StringBuilder();
           Console.WriteLine(sb1);

            // StringBuilder  Append()
            StringBuilder sb = new StringBuilder("Hello ", 50);
            Console.WriteLine("StringBuilder  Append()\n");
            sb.Append("World!!");
            sb.AppendLine("Hello C#!");
            sb.AppendLine("This is new line.");

            Console.WriteLine(sb);

            //AppendFormat()
            Console.WriteLine("StringBuilder  AppendFormat()\n");
            StringBuilder amountMsg = new StringBuilder("Your total amount is ");
            amountMsg.AppendFormat("{0:c} ", 25);

            Console.WriteLine(amountMsg);
            Console.WriteLine();

            //Insert()
            Console.WriteLine("StringBuilder  Insert()");
            StringBuilder hello = new StringBuilder("Hello World!!", 50);
            sb.Insert(5, " C#");

            Console.WriteLine(hello);
            Console.WriteLine();

            // Remove()
            Console.WriteLine("StringBuilder  Remove()");
            StringBuilder rem= new StringBuilder("Hello World!!", 50);
            rem.Remove(6, 7);

            Console.WriteLine(rem);
            Console.WriteLine();

            //Replace()
            Console.WriteLine("StringBuilder  Replace()");
            StringBuilder rpl = new StringBuilder("Hello World!!", 50);
            rpl.Replace("World", "C#");

            Console.WriteLine(rpl);
            Console.WriteLine();

            //StringBuilder as Indexer
            Console.WriteLine("StringBuilder  as Indexer");

            StringBuilder indx = new StringBuilder("Hello World!!");

            for (int i = 0; i < indx.Length; i++)
                Console.WriteLine(indx[i]);

            //ToString()
            Console.WriteLine("StringBuilder  ToString()\n");
            StringBuilder tostr = new StringBuilder("Hello World!!");

            string str = tostr.ToString();
            Console.WriteLine(str);

        }
    }
}
