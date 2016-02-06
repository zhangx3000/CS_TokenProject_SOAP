using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;

namespace TokenServer {
    public class ClientHandler {
        private NetworkStream socketStream;
        private BinaryWriter writer;
        private BinaryReader reader;
        private Socket connection;
        private Server server;

        public ClientHandler(Server server) {
            this.server = server; 
        }

        public void closeConnection() {
            connection.Close();
        }

        public void write(String s) {
            writer.Write(s);
        }

        public void handleClient(Socket connection) {
            this.connection = connection;
            socketStream = new NetworkStream(connection);
            writer = new BinaryWriter(socketStream);
            reader = new BinaryReader(socketStream);
            string theReply = "";
            do {
                try {
                    theReply = reader.ReadString();
                } catch (Exception) {
                    break;
                }
                // TODO fix the flag for ending
            } while (theReply != "CLIENT>>> TERMINATE" && connection.Connected);

            closeStreams();
        }

        private void closeStreams() {
            writer.Close();
            reader.Close();
            socketStream.Close();
            closeConnection();
        }     
    }
}
