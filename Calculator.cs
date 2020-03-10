using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
	class Calculator
	{
		static void Main(string[] args)
		{
			/*
			int a = 10;
			int b = 6;
		
			Console.WriteLine("Hasil Penambahan: {0} + {1} = {2}", a, b, Penambahan(a,b));
			Console.WriteLine("Hasil Pengurangan: {0} - {1} = {2}", a, b, Pengurangan(a,b));
			*/
			
			Console.Title = "Aplikasi Calculator";
            Console.WriteLine("Pilih menu Calculator:\n");
            Console.WriteLine("1. Penambahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian\n");
            Console.Write("Input nomor menu [1..4]: ");
            
            int pil = int.Parse(Console.ReadLine());

            Console.WriteLine();
			
			Console.WriteLine("\nTekan sembarang key untuk keluar");
			Console.ReadKey();
		}
	
		static int Penambahan(int a, int b)
		{
			return a+b;
		}
	
		static int Pengurangan(int a, int b)
		{
			return a-b;
		}
		
		static int Perkalian(int a, int b)
        {
            return a * b;
        }
        static float Pembagian(float a, float b)
        {
            return a / b;
        }
	
	}
}