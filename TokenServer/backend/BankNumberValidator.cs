using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace TokenServer.backend {
    class BankNumberValidator {
        public static bool isValid(string bankNumber) {
            bool isLengthCorrect = bankNumber.Length >= 16;
            
            Regex onlyDigitsRegex = new Regex("^\\d$");
            bool onlyDigits = onlyDigitsRegex.Match(bankNumber).Success;

            Regex validFirstNumberRegex = new Regex("[3-6]");
            string firstNumber = bankNumber.ElementAt(0).ToString();
            bool validFirstNumber = validFirstNumberRegex.Match(firstNumber).Success;

            return isLengthCorrect && onlyDigits && validFirstNumber;
        }
    }
}
