using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TokenServer.model {
    public class BankNumberToTokensWrapper {
        private List<BankNumberToTokens> bankNumberToTokensList;
        
        public List<BankNumberToTokens> BankNumberToTokensList { get; set; }
    }
}
