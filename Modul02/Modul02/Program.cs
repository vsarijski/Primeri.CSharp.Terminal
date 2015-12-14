using System;

namespace Modul02
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");


			//Дефинуране на променливи
			int a = 0, b = 0;
			int sum = 0;
			string program_name = "Модул02 - Примери";
			string program_version = "1.0";
		
			//Събиране на числа

			a = 10;
			b = 5;
			sum = a + b;

			//ЗА ПРОГРАМАТА

			Console.WriteLine (program_name);
			Console.WriteLine ("Версия: " + program_version + "\n\n");

			//Писане в конзола
			Console.Write ( a);
			Console.Write ( " + " );
			Console.Write ( b );
			Console.Write (" = ");
			Console.WriteLine ( sum );


			//Допълнителни оператори
			Console.WriteLine ( "\nИзползване на +=" );
			a += b;
			Console.WriteLine ( a );

			Console.WriteLine ( "\nИзползване на -=" );
			a -= b;
			Console.WriteLine ( a );

			Console.WriteLine ( "\nИзползване на *=" );
			a *= b;
			Console.WriteLine ( a );

			Console.WriteLine ( "\nИзползване на ++" );
			a++ ;
			Console.WriteLine ( a );

			Console.WriteLine ("Стандартно делене:" + (14/4).ToString ());
			Console.WriteLine ("Остатък от делене:" + (14%4).ToString ());



		}

	}
}
