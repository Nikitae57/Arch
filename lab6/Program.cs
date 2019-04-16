using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab6.net.yandex.speller;

namespace lab6
{
	// API: https://tech.yandex.ru/speller/doc/dg/concepts/api-overview-docpage/
	class Program
	{
		SpellService service;

		void StartProgram()
		{
			service = new SpellService();
			Console.WriteLine("Введите текст для проверки орфографии:");
			string text = Console.ReadLine();
			Console.WriteLine();

			var spErrors = service.checkText(text, "ru, en", 0, "plain");
			if (spErrors.Length == 0)
			{
				Console.WriteLine("Ошибки не найдены");
			}
			else
			{
				foreach(SpellError er in spErrors)
				{
					Console.WriteLine($"Ошибка в слове: {er.word}");
					Console.WriteLine($"Позиция: {er.pos + 1}");
					if (er.s != null)
					{
						Console.WriteLine("Возможные варианты: ");
						foreach(string str in er.s)
						{
							Console.WriteLine(str);
						}
					}
					Console.WriteLine();
				}
			}
			Console.ReadKey();
		}

		static void Main(string[] args)
		{
			Program pr = new Program();
			pr.StartProgram();
		}
	}
}
