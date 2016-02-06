using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TokenServer.model {
    class User {
        private string username;
        private string password;

        public void setUsername(string u) {
            username = u;
        }

        public string getUsername() {
            return username;
        }

        public void setPassword(string p) {
            password = p;
        }

        public string getPassword() {
            return username;
        }
        
    }
}
