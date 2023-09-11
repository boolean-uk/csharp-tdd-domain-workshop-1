using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator.console
{
    public class Calculator
    {
        private List<string> _transactionHistory = new List<string>();


        public int Add(int a, int b)
        {
            
            _transactionHistory.Add($"{a}+{b}={a+b}");
            return a + b;
        }

        public int Multiply(int a, int b)
        {
            _transactionHistory.Add($"{a}*{b}={a * b}");
            return a * b;
        }

        //public List<string> TransactionHistory { get; set; } = new List<string>();
        public List<string> TransactionHistory { get { return _transactionHistory; } }
        public bool TransactionHitoryIsFull { get { return _transactionHistory.Count > TransactionMaxCount ? true : false; } }

        public int TransactionMaxCount { get; set; } = 1;


    }
}
