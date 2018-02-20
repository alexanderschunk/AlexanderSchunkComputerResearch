/*
 * Erstellt mit SharpDevelop.
 * Benutzer: Alexander
 * Datum: 20.02.2018
 * Zeit: 15:19
 * 
 * Sie können diese Vorlage unter Extras > Optionen > Codeerstellung > Standardheader ändern.
 */
using System;

namespace AlexanderSchunkAntiVirusTestMeltdownUndSpectreTest1
{
	class Program
	{
		//Alexander Schunk Antivirus Programm Test
		
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			int anzahldateien = 0;
			
			string dateiname = "";
			
			Console.WriteLine("Alexander Schunk Geben Sie den Dateinamen ein: ");
			
			dateiname = Console.ReadLine();
			
			Console.WriteLine("Alexander Schunk Dateiname: " + dateiname);
			
			Console.WriteLine("Alexander Schunk geben Sie die Anzahl an: ");
			
			anzahldateien = Console.Read();
			
			Console.WriteLine("Alexander Schunk Anzahl Dateien: " + anzahldateien);
			
			for(int i  = 0; i < anzahldateien; i++){
				
				Console.WriteLine("Alexander Schunk Anzahl: " + i); 
			}
			
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}