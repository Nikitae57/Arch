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
