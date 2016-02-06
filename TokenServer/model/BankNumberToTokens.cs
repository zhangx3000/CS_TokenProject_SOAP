using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TokenServer.model {
    public class BankNumberToTokens {
        private string bankNumber;
        private List<string> tokens;

        public BankNumberToTokens() {
            tokens = new List<string>();
        }

        public string getBankNumber() {
            return bankNumber;
        }

        public void setBankNumber(string b) {
            bankNumber = b;
        }

        public List<string> getTokens() {
            return tokens;
        }

        public void setTokens(List<string> tok) {
            tokens = new List<string>();
            tokens.AddRange(tok);
        }
    }
}
