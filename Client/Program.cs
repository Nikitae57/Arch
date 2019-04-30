using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ServiceModel.Samples.BasicWebProgramming;

namespace Client
{
	class Program
	{
		static void Main(string[] args)
		{
			Uri serverUri = new Uri("http://localhost:8000/");
			EndpointAddress address = new EndpointAddress(serverUri);
			BasicHttpBinding binding = new BasicHttpBinding();
            
			ChannelFactory<IService> factory = new ChannelFactory<IService>(binding, address);
			IService myService = factory.CreateChannel();

			while (true) {
				Console.WriteLine("===============================");
				Console.WriteLine("1) Show flights");
				Console.WriteLine("2) Purchase ticket");
				Console.WriteLine("0) Exit");
				Console.WriteLine("===============================");
				Console.Write("Enter command: ");
				string command = Console.ReadLine();
				switch (command) {
					case "1": {
						Console.WriteLine(myService.GetFlights());
						break;
					}

					case "2": {
						Console.Write("Write flight id to buy ticket: ");
						int flightId = Convert.ToInt32(Console.ReadLine());
						bool isSold = myService.BuyTicket(flightId);
						if (isSold) {
							Console.WriteLine("You purchased ticket successfully");
						}
						else {
							Console.WriteLine("You purchased ticket unsuccessfully");
						}

						break;
					}

					case "0": {
						Environment.Exit(0);
						break;
					}

					default: {
						Console.WriteLine("Wrong command");
						break;
					}
				}
			}
			return;
		}
	}
}
