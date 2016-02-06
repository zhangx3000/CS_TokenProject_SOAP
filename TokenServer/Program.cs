using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using TokenServer.model;
using TokenServer.backend;
namespace TokenServer {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            User u = new User();
            u.setPassword("pasword");
            u.setUsername("usrnm");
            UsersWrapper wrapper = new UsersWrapper();
            List<User> users = new List<User>();
            users.Add(u);
            wrapper.setUsers(users);
            XMLManager.writeUsers(wrapper);
        }
    }
}
