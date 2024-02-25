namespace IdealWieghtCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IdealWieght caseM=new IdealWieght() { Gender='m',Height=170};
            double Actual1= caseM.calculate();
            double Expected1 = 65;
            int x;
            if(Actual1==Expected1) 
            { 
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("caseM Success");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("caseM Faild");
            }
            IdealWieght caseF = new IdealWieght() { Gender = 'f', Height = 176 };
            double Actual2 = caseF.calculate();
            double Expected2 = 63;
            if (Actual2 == Expected2)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("caseF Success");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("caseF Faild");
            }
            IdealWieght caseDefault = new IdealWieght() { Gender = 'k' };
            double Actual3 = caseDefault.calculate();
            double Expected3 = 0;
            if (Actual3 == Expected3)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("caseDefault Success");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("caseDefault Faild");
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadLine();
        }
    }
}
