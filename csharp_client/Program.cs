using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_client
{
	class Program
	{
		static void Main(string[] args)
		{
			var customer = new CsharpTypesInFsharp.domain.Customer("1", "Simon");
			Console.WriteLine("Customer name : {0} ", customer.Name);
			Console.WriteLine("Press any key");
			Console.ReadKey();
		}
	}
}
