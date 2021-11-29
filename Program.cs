using System;

namespace part4
{
	class Program
	{
		public static void Main(string[] args)
		{
			double nettoEP, bruttoEP, mwstBT, bruttoRN, mwstRN, bruttoMP, mwstMT;
			mwstRN = 0.19;
			bruttoRN = 0.81;
			int menge;
			
			Console.Write("Bitte geben Sie den Nettopreis ihres Artikels ein: ");
			nettoEP = Convert.ToDouble(Console.ReadLine());
			if (nettoEP > 0)
			{ 
				Console.WriteLine("Bitte geben Sie die Menge der Artikel ein");
			}
			else 
			{ 
				Console.WriteLine("Der Nettopreis muss > 0 sein. Bitte versuche es erneut.");
			}
			
			bruttoEP = nettoEP * bruttoRN;
			mwstBT = nettoEP * mwstRN;
			
			menge = Convert.ToInt32(Console.ReadLine());
			
			if (menge > 1)
			{ 
				bruttoMP = bruttoEP * menge;
				mwstMT = mwstBT * menge;
				
				Console.WriteLine("Ihr Bruttobetrag bei dieser Transaktion ist {0} Euro", bruttoMP);
				Console.WriteLine("Ihr Mehrwertsteuerbetrag bei dieser Transaktion liegt bei {0} Euro", mwstMT);
			}
			else 
			{
				Console.WriteLine("Ihr Bruttobetrag bei dieser Transaktion ist {0} Euro", bruttoEP);
				Console.WriteLine("Ihr Mehrwertsteuerbetrag bei dieser Transaktion liegt bei {0} Euro", mwstBT);
			
			}
			
			Console.ReadKey(true);
		}
	}
}