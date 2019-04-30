using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
using Nwc.XmlRpc;

namespace XMLRPCServer
{
    class Server
    {

        const int PORT = 5050;

        static public void WriteEntry(String msg, EventLogEntryType type)
        {
            if (type != EventLogEntryType.Information) // ignore debug msgs
                Console.WriteLine("{0}: {1}", type, msg);
        }
        static void Main(string[] args)
        {
            Logger.Delegate = new Logger.LoggerDelegate(WriteEntry);

            XmlRpcServer server = new XmlRpcServer(PORT);
            server.Add("sample", new Server());
            Console.WriteLine("Web Server Running on port {0} ... Press ^C to Stop...", PORT);
            server.Start();
        }

		public string processMatrix(string matrix)
		{
			string[] strArray = matrix.Split(' ');
			int matrixSize = Convert.ToInt32(Math.Sqrt(strArray.Length));
			int[,] matrixInt = new int[matrixSize, matrixSize];
			int k = 0;
			for (int row = 0; row < matrixSize; row++)
			{
				for (int item = 0; item < matrixSize; item++)
				{
					matrixInt[row, item] = Convert.ToInt32(strArray[k++]); 
				}
			}

			bool firstDiagonal = true;
			int min = int.MaxValue;
			for (int i = 0, j = 0; i < matrixSize || j < matrixSize; i++, j++)
			{
				if (matrixInt[i, j] < min)
				{
					min = matrixInt[i, j];
				}
			}
			for (int i = 0, j = matrixSize - 1; i < matrixSize || j >= 0; i++, j--)
			{
				if (matrixInt[i, j] < min)
				{
					min = matrixInt[i, j];
					firstDiagonal = false;
				}
			}
			string res = "";
			if (firstDiagonal)
			{
				for (int row = 0; row < matrixSize; row++)
				{
					for (int item = 0; item < matrixSize; item++)
					{
						if (item == row)
						{
							res += "0 ";
						}
						else if (item < row)
						{
							res += Convert.ToString(matrixInt[row, item] * matrixInt[row, item]) + ' ';
						}
						else
						{
							res += Convert.ToString(matrixInt[row, item]) + ' ';
						}
					}
				}
			}
			else
			{
				for (int row = 0; row < matrixSize; row++)
				{
					for (int item = 0; item < matrixSize; item++)
					{
						if (item + row == matrixSize - 1)
						{
							res += "0 ";
						}
						else if (item + row > matrixSize - 1)
						{
							res += Convert.ToString(matrixInt[row, item] * matrixInt[row, item]) + ' ';
						}
						else
						{
							res += Convert.ToString(matrixInt[row, item]) + ' ';
						}
					}
				}
			}
			res = res.Remove(res.Length - 1);
			res += $"#{min}";
			return res;
		}

		/// <summary>A method that returns the current time.</summary>
		public DateTime Ping()
        {
            return DateTime.Now;
        }

        /// <summary>A method that echos back it's arguement.</summary>
        public String Echo(String arg)
        {
            return arg;
        }
    }
}
