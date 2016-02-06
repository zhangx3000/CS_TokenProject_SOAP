using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TokenServer.backend {
    class TokenGenerator {
        private Random generator;
        private string bankAccount;

        public TokenGenerator(string bankAccount) {
            generator = new Random();
            this.bankAccount = bankAccount;
        }
        
        public string generate() {
            int[] bankAccountNumbers = convertStringToIntegerArray(bankAccount);
            int size = bankAccountNumbers.Length;
            int[] tokenNumbers = new int[size];

            for(var index = size - 1 ; index > size - 5; index--)
                tokenNumbers[index] = bankAccountNumbers[index];

            do {
                tokenNumbers[0] = generateFirstPosition();
                for (var index = 1; index < 12; index++) {
                    tokenNumbers[index] = generateTokenNumberAtPosition(index);
                }
            }while(areTokenNumbersDevidedByTen(tokenNumbers));

            return tokenNumbers.ToString();
        }

        private int generateTokenNumberAtPosition(int index) {
            int tokenNumber = bankAccount[index];
            do {
                tokenNumber = generator.Next(10);
            } while (tokenNumber == bankAccount[index]);
            
            return tokenNumber;
        }

        private int[] convertStringToIntegerArray(string bankAccount) {
            char[] charrArray = bankAccount.ToCharArray();
            int[] convertedArray = new int[charrArray.Length];
            for (int index = 0; index < charrArray.Length; index++) {
                convertedArray[index] = Int32.Parse(charrArray[index].ToString());
            }
            return convertedArray;
        }

        private int generateFirstPosition() {
            int firstPosition = 3;
            while (firstPosition == 3 || firstPosition == 4 || firstPosition == 5 || firstPosition == 6 ) {
                firstPosition = generator.Next(10);
            }
            return firstPosition;
        }

        private bool areTokenNumbersDevidedByTen(int[] tokenNumbers) {
            int sum = 0;
            foreach (int number in tokenNumbers) {
                sum += number;
            }
            return (sum % 10 == 0);
        }
    }
}
