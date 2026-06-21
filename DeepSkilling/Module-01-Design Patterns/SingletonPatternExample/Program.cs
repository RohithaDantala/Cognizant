using System;
class Program
{
    static void Main(string[] args)
    {
        Logger logger1 = Logger.GetInstance();
        Logger logger2 = Logger.GetInstance();

        logger1.Log("This is message 1.");
        logger2.Log("This is message 2.");
        if(Object.ReferenceEquals(logger1, logger2))
        {
            Console.WriteLine("Only one logger instance exists.");
        }
       
    }
}