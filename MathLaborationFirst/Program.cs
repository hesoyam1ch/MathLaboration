using System;
namespace MathLaborationFirst
{
   

    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Перша лабораторна:"+"\nМетод дотичних" +"\t x^3-0,1x^2+0,4x-1,5=0" );
            FirstLaboration.Result();
            Console.WriteLine("Друга лабораторна:"+"\nМетод прямокутникiв" + "\tIntegral0^1cos(x^3+2x^2 )dx,n=20");
            SecondLaboration.Result();
        }
    }

}