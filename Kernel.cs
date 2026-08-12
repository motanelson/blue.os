using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace CosmosExpre
{
    public class Kernel : Sys.Kernel
    {

        protected override void BeforeRun()
        {
            Console.WriteLine("Cosmos booted successfully. Type a line of text to get it echoed back.");
        }

        protected override void Run()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            while (true) 
            { 
                Console.WriteLine("give me a expression separete by space like 10 + 10?");
                var input = Console.ReadLine().Trim();
                String[] s = input.Split(' ');
                expre.Main(s);
                input = Console.ReadLine();
            }
            
            
        }
    }
    class RunExpre
    {
        static Double total = 0.00; static String s = ""; static Double d = 0.00; static int counter = 0;

        static void writer(Double ss)
        {
            Console.WriteLine(ss);


        }
        static void parm(String ss)

        {
            ss = ss.Trim();
            if (counter == 0) s = ss;
            if (counter == 1)
            {
                try
                {
                    d = Double.Parse(ss);
                }
                catch (Exception e)
                {
                    Console.WriteLine("error:");

                }
                if (s == "+") total = total + d;
                if (s == "-") total = total - d;
                if (s == "*") total = total * d;
                if (s == "X") total = total * d;
                if (s == "x") total = total * d;
                if (s == "\\") total = total / d;
                if (s == "/") total = total / d;
                counter = -1;
            }
            counter++;



        }

        public static void RunLoop(String[] ss)
        {
            if (ss.Length == 0) Console.WriteLine("error ...");
            if (ss.Length == 1) Console.WriteLine(ss[0]);
            if (ss.Length > 2)
            {
                try
                {
                    total = Double.Parse(ss[0]);
                }
                catch (Exception e)
                {
                    Console.WriteLine("error:");

                }
                for (int i = 1; i < ss.Length; i++)
                {
                    parm(ss[i]);


                }
                writer(total);
            }


        }



    }





    class expre
    {
        public static void Main(String[] argv)
        {


            RunExpre.RunLoop(argv);

        }





    }


}
