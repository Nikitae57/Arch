using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;

namespace Microsoft.ServiceModel.Samples.BasicWebProgramming {
	public class Ticket {
		public Ticket(
			int id,
			int flightId,
			int seatNumber,
			float price,
			string from,
			string to
		) {
			this.id = id;
			this.flightId = flightId;
			this.seatNumber = seatNumber;
			this.price = price;
			this.flightFrom = from;
			this.flightTo = to;
		}
		
		public int id;
		public int flightId;
		public int seatNumber;
		public float price;

		public string flightFrom;
		public string flightTo;
	}

	public class Flight {
		public Flight(
			int id, 
			string from, 
			string to,
			string planeName,
			int seatsNumber,
			float ticketPrice
		) {
			this.id = id;
			this.flightFrom = from;
			this.flightTo = to;
			this.airplaneName = planeName;
			this.ticketsSold = new List<Ticket>();
			this.ticketsRemain = new List<Ticket>();

			for (int i = 0; i < seatsNumber; i++) {
				Ticket t = new Ticket(
					i,
					id,
					i + 1,
					ticketPrice,
					from,
					to
				);
				ticketsRemain.Add(t);
			}
		}
		
		public int id;
		public string airplaneName;
		public string flightFrom;
		public string flightTo;

		public int seatsNumber => ticketsRemain.Count;
		public List<Ticket> ticketsRemain;
		public List<Ticket> ticketsSold;	
	}
	
	[ServiceContract]
	public interface IService {
		[OperationContract]
		string GetFlights();

		[OperationContract]
		bool BuyTicket(int flightId);
	}

	public static class DataBase {
		public static List<Flight> flights = new List<Flight>();
	}

	public class Service : IService {
		public string GetFlights() {
			string result = "";
			foreach (var flight in DataBase.flights) {
				result += "\n";
				result += $"Flight id: {flight.id}\n";
				result += $"Flight to: {flight.flightTo}\n";
				result += $"Flight from: {flight.flightFrom}\n";
				result += $"Seats number: {flight.seatsNumber}\n";
				result += $"Plane name: {flight.airplaneName}\n";
				result += "\n";
			}

			return result;
		}

		public bool BuyTicket(int flightId) {
			Flight f = DataBase.flights.Find(x => x.id == flightId);

			if (f.ticketsRemain.Count <= 0) {
				return false;
			}

			Ticket t = f.ticketsRemain.First();
			f.ticketsSold.Add(t);
			f.ticketsRemain.Remove(t);

			return true;
		}
	}

	public class Program {
		static void Main(string[] args) {
			DataBase.flights.Add(new Flight(0, "Магадан", "Москва", "A999", 200, 999));
			DataBase.flights.Add(new Flight(1, "Москва", "Магадан", "A200", 100, 1));
			DataBase.flights.Add(new Flight(2, "Орел", "Сан-Франциско", "A123", 10, 10000));
			DataBase.flights.Add(new Flight(3, "Москва", "Магадан", "Б494", 50, 100));
			DataBase.flights.Add(new Flight(4, "Орел", "Москва", "В99", 120, 1000));
			DataBase.flights.Add(new Flight(5, "Москва", "Орел", "Г991", 140, 2));
			
			ServiceHost host = new ServiceHost(
				typeof(Service),
				new Uri("http://127.0.0.1:8000/")
			);
			
			host.AddServiceEndpoint(typeof(IService), new BasicHttpBinding(), "");
            
			Console.WriteLine("Server started");
			host.Open();
			Console.WriteLine("Press <Enter> to terminate");
			Console.ReadLine();
			host.Close();
		}
	}
}