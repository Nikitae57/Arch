using System;

namespace ConsoleApplication1 {
    internal class MenuHandler {
        public static void Main(string[] args) {
            var mh = new MenuHandler();

            while (true) {
                mh.printMenu();
                var choice = Console.ReadLine();
                switch (choice) {
                    case "1": 
                        One.doOne(args);
                    break;
                    
                    case "2": 
                        Two.doTwo();
                    break;

                    case "3":
                        Three.doThree();
                    break;
                    
                    case "4":
                        Four.doFour();
                    break;
                    
                    case "5": 
                        Five.doFive();
                    break;

                    default:
                        Environment.Exit(0);
                    break;
                }
            }
        }

        private void printMenu() {
            String menu = "\n1) Вывести на экран аргументы, переданные в программу при запуске в командной строке\n" +
                          "2) Распечатать лет с 1900 по 2000. Рядом с каждым годом вывести слово «високосный» если этот год високосный или «не високосный» – если нет.\n" +
                          "3) Вывести последовательность чисел Фибоначи до заданного числа.\n" +
                          "4) Вычислить факториал заданного числа\n" +
                          "5) Вывести все простые числа не превышающие заданное. Для решения использовать алгоритм «решето Эратосфена\n";
            
            Console.WriteLine(menu);
        }
    }
}