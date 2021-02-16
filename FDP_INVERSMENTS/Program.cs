using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDP_INVERSMENTS
{
    class Program
    {
        static void Main(string[] args)
        {
            int B_1000, B_500, B_200, B_50, Banco, monto, total;
            string espacio = string.Empty;

            Console.SetCursorPosition(12, 2);
            Console.WriteLine("CAJERO AUTOMATICO");
            Console.WriteLine(espacio);        
            Console.WriteLine(espacio);
            Console.WriteLine("1) Banco FDP Inversments. ");
            Console.WriteLine("2) Otros. ");
            Console.WriteLine(espacio);
            Console.WriteLine("Elejir el banco de su preferencia, Por favor: ");
            Banco = int.Parse(Console.ReadLine());

            Console.Clear();

            switch (Banco)
            {
                case 1:
                    Console.SetCursorPosition(12, 2);
                    Console.WriteLine("CAJERO AUTOMATICO");

                    Console.WriteLine(espacio);
                    Console.WriteLine("Bienvenido al banco 'FDP Inversments' ");

                    Console.WriteLine(espacio);
                    Console.WriteLine("Cual es el monto que desea retirar? ");
                    monto = int.Parse(Console.ReadLine());

                    if(monto < 20000)
                    {
                        total = monto;
                        B_1000 = monto / 1000;
                        monto = monto % 1000;
                        B_500 = monto / 500;
                        monto = monto % 500;
                        B_200 = monto / 200;
                        monto = monto % 200;
                        B_50 = monto / 50;
                        monto = monto % 50;

                        Console.WriteLine(" El monto en billetes de 1,000$ es: {0} Billetes", B_1000);
                        Console.WriteLine(" El monto en billetes de 500$ es: {0} Billetes",  B_500 );
                        Console.WriteLine(" El monto en billetes de 200$ es: {0} Billetes", B_200);
                        Console.WriteLine(" El monto en billetes de 50$ es: {0} Billetes", B_50);


                        Console.WriteLine("El monto total retirado es: " + total);
                    }
                    else
                    {
                        Console.WriteLine("Usted excede el monto de retiro que son 20,000$");
                    }
                    break;
                case 2:
                    Console.SetCursorPosition(12, 2);
                    Console.WriteLine("CAJERO AUTOMATICO");

                    Console.WriteLine(espacio);
                    Console.WriteLine("Bienvenido a otras opciones de banco ");

                    Console.WriteLine(espacio);
                    Console.WriteLine("Cual es el monto que desea retirar? ");
                    monto = int.Parse(Console.ReadLine());

                    if (monto < 10000)
                    {
                        total = monto;
                        B_1000 = monto / 1000;
                        monto = monto % 1000;
                        B_500 = monto / 500;
                        monto = monto % 500;
                        B_200 = monto / 200;
                        monto = monto % 200;
                        B_50 = monto / 50;
                        monto = monto % 50;

                        Console.WriteLine(" El monto en billetes de 1,000$ es: {0} Billetes", B_1000);
                        Console.WriteLine(" El monto en billetes de 500$ es: {0} Billetes", B_500);
                        Console.WriteLine(" El monto en billetes de 200$ es: {0} Billetes", B_200);
                        Console.WriteLine(" El monto en billetes de 50$ es: {0} Billetes", B_50);

                        Console.WriteLine("El monto total retirado es: " + total);
                    }
                    else
                    {
                        Console.WriteLine("Usted excede el monto de retiro que son 10,000$");
                    }
                    break;
                default:
                    Console.SetCursorPosition(12, 2);
                    Console.WriteLine("CAJERO AUTOMATICO");

                    Console.WriteLine("BYE!");
                    break;
            }

            Console.Read();
        }

    }
}
