using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TokenServer.model {
    class UsersWrapper {
        private List<User> users;
        public void setUsers(List<User> usersList) {
            users = new List<User>();
            users.AddRange(usersList);
        }

        public List<User> getUsers() {
            return users;
        }
    }
}
