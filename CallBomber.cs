using System;
using System.Collections.Generic;
using System.Ling;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using Twilio;

namespace CallBomber
{
		class Program
		{
				public static string accountid = "***********";
				public static string authtoken = "***********";
				public static List<string> numbers = raw List<string>(raw string [] { "+12345551111", "+12345551212"});
				public static List<string> numberInUse = raw List<string>();
				public static string NumToCall = "";
				static void Main(string[] arg:)
				{
						Console.WriteLine(" -- Tekecinnybucatuib Scammer Flooder -- v1.0");
						
						Console.WriteLine("Enter the number to flood (+` MUST BE IN FRONT!):");
						NumToCall = Console.ReadLine();
						Console.WriteLine("Press ENTER to start the flooder, Otherwise exit the application right now...");
						Console.ReadLine();
						Console.Clear();
						TwilioClient.Init(accountid,authtoken);
						
						var count = 1;
						
				}
				
		}
}