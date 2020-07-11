
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System;


namespace FajloviDrugi
{
	class Program
	{
		static void Main(string[] args)
		{
			

			//File.WriteAllText("tekst.txt", "Tekst za fajl" + Environment.NewLine);
			//File.AppendAllText("tekst.txt", "Drugi red");

			if (File.Exists("tekst.txt"))
			{
				//Console.WriteLine(File.ReadAllText("tekst.txt"));

				foreach(string red in File.ReadLines("tekst.txt"))
				{
					Console.WriteLine("Iduci red je: " + red);
					string[] niz = red.Split(';');
					foreach (string rec in niz)
					{
						Console.WriteLine(rec);
					}

				}
			}
			Console.ReadKey();
		}
	}

	
}

namespace DrugiNS
{
	namespace JosJedan
	{
		namespace NekiTamoTreci
		{
			class NekaKlasa
			{ }
		}
	}
	class Primer
	{ }
}
