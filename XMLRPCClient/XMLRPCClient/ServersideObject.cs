using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nwc.XmlRpc;

namespace XMLRPCClient
{
    class ServersideObject
    {
        XmlRpcRequest client;
        String host = "http://127.0.0.1:5050";

        public ServersideObject()
        {
             client = new XmlRpcRequest();
        }
        public ServersideObject(String host)
        {
            this.host = host;
            client = new XmlRpcRequest();
        }
        public DateTime? Ping()
        {
            XmlRpcResponse response;
            client.MethodName = "sample.Ping";
            Console.WriteLine(client);
            response = client.Send(host);
            if (response.IsFault)
            {
                Console.WriteLine("Fault {0}: {1}", response.FaultCode, response.FaultString);
                return null;
            }
            else {
                return (DateTime)response.Value;
            }
        }

        /// <summary>A method that echos back it's arguement.</summary>
        public String Echo(String arg)
        {
            XmlRpcResponse response;
            client.MethodName = "sample.Echo";
            client.Params.Clear();
            client.Params.Add(arg);
            Console.WriteLine(client);
            response = client.Send(host);
            if (response.IsFault)
            {
                Console.WriteLine("Fault {0}: {1}", response.FaultCode, response.FaultString);
                return "";
            }
            else
                return response.Value.ToString();
        }

        public void processMatrix(int[,] matrix) {
            XmlRpcResponse response;
            var matrixStr = "";
            var matrixSize = Convert.ToInt32(Math.Sqrt(matrix.Length));

            for (int i = 0; i < matrixSize; i++) {
                for (int j = 0; j < matrixSize; j++) {
                    matrixStr += Convert.ToString(matrix[i,j]);
                    matrixStr += ' ';
                }
            }

            matrixStr = matrixStr.Substring(0, matrixStr.Length - 1);
            
            client.MethodName = "sample.processMatrix";
            client.Params.Clear();
            client.Params.Add(matrixStr);
            Console.WriteLine(client);
            response = client.Send(host);
            if (response.IsFault)
            {
                Console.WriteLine("Fault {0}: {1}", response.FaultCode, response.FaultString);
                return;
            }

			Console.WriteLine("Old matrix:");
			for (int i = 0; i < matrixSize; i++)
			{
				for (int j = 0; j < matrixSize; j++)
				{
					Console.Write($"{matrix[i, j]} ");
				}
				Console.WriteLine();
			}

			var resultStr = response.Value.ToString();
            var res = resultStr.Split('#');
            var oneDimMatrix = res[0].Split(' ');
            var minElement = res[1];
            var resultMatrix = new int[matrixSize, matrixSize];

            var itemCounter = 0;
            Console.WriteLine("New matrix: ");
            for (int row = 0; row < matrixSize; row++) {
                for (int item = 0; item < matrixSize; item++) {
                    resultMatrix[row, item] = Convert.ToInt32(oneDimMatrix[itemCounter]);
                    itemCounter++;
                    Console.Write(resultMatrix[row, item] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Min element: " + minElement);
        }
    }
}
