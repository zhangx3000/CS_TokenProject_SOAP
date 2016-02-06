using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;

namespace TokenServer {
    public class Server {

        private Thread readThread;
        private List<ClientHandler> clients = new List<ClientHandler>();

        public Server() {
            readThread = new Thread(new ThreadStart(RunServer));
            readThread.Start();                                     
        }

        private void RunServer() {
            TcpListener listener;
            try {
                listener = new TcpListener(IPAddress.Parse("127.0.0.1"), 50000);
                listener.Start();
                while (true) {
                    createNewClientHandler(listener);
                }
            } catch (Exception error) {
                // TODO Change error handling
                MessageBox.Show(error.ToString());
            }
        }

        private void closeConnections() {
            foreach (ClientHandler handler in clients)
                handler.closeConnection();
        }

        private void notifyWriters(string p) {
            foreach (ClientHandler handler in clients)
                handler.write(p);
        }

        private void createNewClientHandler(TcpListener listener) {
            Socket connection = listener.AcceptSocket();
            ClientHandler handler = new ClientHandler(this);
            ThreadPool.QueueUserWorkItem(new WaitCallback(o => handler.handleClient(connection)));
            clients.Add(handler);
        }
    }
}
