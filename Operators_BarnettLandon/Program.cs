namespace Operators_BarnettLandon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tINTEGERS");
            //Assign and declare var1
            int numOneI = 1 + 3;
            Console.WriteLine(numOneI);
            //Assign and declare var2
            int numTwoI = 2*3;
            Console.WriteLine(numTwoI);
            //Print min and max of var1 and var2
            Console.WriteLine("Max:" + Math.Max(numOneI, numTwoI));
            Console.WriteLine("Min:" + Math.Min(numOneI, numTwoI));
            //Defines which var has a greater value
            bool isIntGreater = numOneI > numTwoI;
            Console.WriteLine($"{numOneI} is greater than {numTwoI}, {isIntGreater}");

             
            Console.WriteLine("\n\tSHORT");
            //Assign and declare var1
            short numOneS = 12 + 69;
            Console.WriteLine(numOneS);
            //Assign and declare var2
            short numTwoS = 21 * 33;
            Console.WriteLine(numTwoS);
            //Print min and max of var1 and var2
            Console.WriteLine("Max:" + Math.Max(numOneS, numTwoS));
            Console.WriteLine("Min:" + Math.Min(numOneS, numTwoS));
            //Defines which var has a greater value
            bool isShortGreater = numOneS > numTwoS;
            Console.WriteLine($"{numOneS} is greater than {numTwoS}, {isShortGreater}");

            Console.WriteLine("\n\tLONG");
            //Assign and declare var1
            long numOneL = 92233720368547 + 922337209564775808;
            Console.WriteLine(numOneL);
            //Assign and declare var2
            long numTwoL = 865550446 * 5467348652;
            Console.WriteLine(numTwoL);
            //Print min and max of var1 and var2
            Console.WriteLine("Max:" + Math.Max(numOneL, numTwoL));
            Console.WriteLine("Min:" + Math.Min(numOneL, numTwoL));
            //Defines which var has a greater value
            bool isLongGreater = numOneL > numTwoL;
            Console.WriteLine($"{numOneL} is greater than {numTwoL}, {isLongGreater}");

            Console.WriteLine("\n\tFLOAT");
            //Assign and declare var1
            float numOneF = 5.9f + 6.9f;
            Console.WriteLine(numOneF);
            //Assign and declare var2
            float numTwoF = 21f * 7.2f;
            Console.WriteLine(numTwoF);
            //Print min and max of var1 and var2
            Console.WriteLine("Max:" + Math.Max(numOneF, numTwoF));
            Console.WriteLine("Min:" + Math.Min(numOneF, numTwoF));
            //Defines which var has a greater value
            bool isFloatGreater = numOneF > numTwoF;
            Console.WriteLine($"{numOneF} is greater than {numTwoF}, {isLongGreater}");

            Console.WriteLine("\n\tDOUBLE");
            //Assign and declare var1
            double numOneD = 5.9f + 6.9f;
            Console.WriteLine(numOneD);
            //Assign and declare var2
            double numTwoD = 21f * 7.2f;
            Console.WriteLine(numTwoD);
            //Print min and max of var1 and var2
            Console.WriteLine("Max:" + Math.Max(numOneD, numTwoD));
            Console.WriteLine("Min:" + Math.Min(numOneD, numTwoD));
            //Defines which var has a greater value
            bool isDoubleGreater = numOneD > numTwoD;
            Console.WriteLine($"{numOneD} is greater than {numTwoD}, {isDoubleGreater}");

            Console.WriteLine("\n\tDECIMAL");
            //Assign and declare var1
            decimal numOneDe = 12.13579m + 181864.2m;
            Console.WriteLine(numOneDe);
            //Assign and declare var2
            decimal numTwoDe = 78546546m + 5m;
            Console.WriteLine(numTwoDe);
            //Print min and max of var1 and var2
            Console.WriteLine("Max:" + Math.Max(numOneDe, numTwoDe));
            Console.WriteLine("Min:" + Math.Min(numOneDe, numTwoDe));
            //Defines which var has a greater value
            bool isDecimalGreater = numOneDe > numTwoDe;
            Console.WriteLine($"{numOneDe} is greater than {numTwoDe}, {isDecimalGreater}");
        }
    }
}