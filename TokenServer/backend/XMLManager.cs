using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wox.serial;
using TokenServer.model;

namespace TokenServer.backend {
    class XMLManager {
        public static UsersWrapper readUsers() {
            return (UsersWrapper)Easy.load(Constants.USERS_FILE_NAME);
        }

        public static void writeUsers(UsersWrapper users) {
            Easy.save(users, Constants.USERS_FILE_NAME);
        }

        public static void addUser(User user) {
            UsersWrapper usersList = readUsers();
            usersList.getUsers().Add(user);
            writeUsers(usersList);
        }

        public static BankNumberToTokensWrapper readBankNumbersToTokens() {
            return (BankNumberToTokensWrapper)Easy.load(Constants.BANK_NUMBERS_AND_TOKENS_FILE_NAME);
        }

        public static void writeBankNumbersToTokens(BankNumberToTokensWrapper users) {
            Easy.save(users, Constants.USERS_FILE_NAME);
        }

        public static void addBankNumberToToken(BankNumberToTokens obj) {
            BankNumberToTokensWrapper list = readBankNumbersToTokens();
            list.BankNumberToTokensList.Add(obj);
            writeBankNumbersToTokens(list);
        }
    }
}
