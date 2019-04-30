using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
	class Program
	{
		static void Main(string[] args)
		{
			Algorithm.AlgorithmServiceClient client = new Algorithm.AlgorithmServiceClient();
			int[] mas = {20, 300, 15, 20, 0, 5, 14,98, 10 };
			Console.WriteLine("Исходный массив:");
			foreach (int i in mas)
			{
				Console.Write($"{i} ");
			}
			Console.WriteLine();

			mas = client.Sort(mas);
			Console.WriteLine("Сортированный массив:");
			foreach (int i in mas)
			{
				Console.Write($"{i} ");
			}
			Console.WriteLine();

			Console.WriteLine("Введите число для двоичного поиска по массиву:");
			int id = Convert.ToInt32(Console.ReadLine());
			int index = client.BinarySearch(mas, id);
			if (index != -1)
			{
				Console.WriteLine($"Элемент есть в массиве, его позиция: {index}");
			}
			else
			{
				Console.WriteLine($"Элемента нет в массиве");
			}
			Console.ReadKey();
		}
	}
}
