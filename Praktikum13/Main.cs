using System;

namespace Praktikum13
{
    class Program
    {
        static void Main(string[] args)
        {
            Fuhrpark park = new Fuhrpark();
            Info info = new Info(park);

            for(int i = 0; i < 10; i++)
            {
                park.Aufnehmen(new Auto("Auto"+i,1990+i));
            }
            
            Console.WriteLine("Inventur:");

            park.Inventur();

            Console.WriteLine("Flottenalter = "+park.BerechneFlottenalter());

            Console.WriteLine(park[0].ToString());
        }
    }
}
