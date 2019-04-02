using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nwc.XmlRpc;
using System.Diagnostics;

namespace XMLRPCClient
{
    class Program
    {
        static ServersideObject obj;
        /// <summary>Simple logging to Console.</summary>
        static public void WriteEntry(String msg, EventLogEntryType type)
        {
            if (type != EventLogEntryType.Information) // ignore debug msgs
                Console.WriteLine("{0}: {1}", type, msg);
        }

        private static int[,] readMatrix() {
            Console.WriteLine("Enter matrix size:");
            int size = Convert.ToInt32(Console.ReadLine());
            var matrix = new int[size, size];

            Console.WriteLine("Enter matrix");
            for (int i = 0; i < size; i++) {
				string[] row = Console.ReadLine().Split(' ');
                for (int j = 0; j < size; j++) {
                    matrix[i, j] = Convert.ToInt32(row[j]);
                }
            }

            return matrix;
        }
        
        static void Main(string[] args) {
            obj = new ServersideObject("http://127.0.0.1:5050");
            var matrix = readMatrix();
            obj.processMatrix(matrix);
            Console.ReadLine();
        }
    }
}
