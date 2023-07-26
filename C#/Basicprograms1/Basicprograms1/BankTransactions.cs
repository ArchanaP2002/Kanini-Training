//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Basicprograms1
//{
//     public class BankTransactions
//    {
//        private int custid;
//        private long accno;
//        private string accname, status;
//        private decimal balance, creditamt, debitamt;

//        public int Custid { get => custid; set => custid = value; }
//        public long Accno { get => accno; set => accno = value; }
//        public string Accname { get => accname; set => accname = value; }
//        public string Status { get => status; set => status = value; }
//        public decimal Balance { get => balance; set => balance = value; }
//        public decimal Creditamt { get => creditamt; set => creditamt = value; }
//        public decimal Debitamt { get => debitamt; set => debitamt = value; }

//        public BankTransactions(int Custid, long accno, string accname, decimal balance)
//        { 
//            this.custid = Custid;
//            this.balance = balance; 
//            this.accno = accno;
//            this.accname = accname;
//            this.status = "InActive";
//            this.creditamt = this.debitamt = 0;
//        }
//        //private void ReadCustomerDetails()
//        //{
//        //    Console.WriteLine("Enter The Customer id," + "AccountNumber, Name, Balance");
//        //    custid =  Convert.ToInt32 (Console.ReadLine());
//        //    accno = Convert.ToInt32(Console.ReadLine());
//        //    accname = (Console.ReadLine());
//        //    balance = Convert.ToDecimal(Console.ReadLine());
            
//        //}
//        private void PerformTransactions()
//        {
//            //ReadCustomerDetails();
//            Console.WriteLine("1. Credit 2. Debit");
//            int ch = Convert.ToInt32(Console.ReadLine());
//            switch (ch)
//            {
//                case 1:
//                    Console.WriteLine("Enter Credit Ammount");
//                    this.creditamt = Convert.ToDecimal(Console.ReadLine());
//                    balance += creditamt;
//                    this.status = "Active";
//                    break;
//                case 2:
//                    Console.WriteLine("Enter debit Ammount");
//                    this.debitamt = Convert.ToDecimal(Console.ReadLine());
//                     balance -= debitamt;
//                    this.status = "Active";
//                    break;
//                default:
//                    Console.WriteLine("Enter 1 or 2 only");
//                    break;

//            }
//        }
//        internal void WriteCustomerDetails()
//        {
//           PerformTransactions();
//            Console.WriteLine($"Name:{accname} - Balance: {balance}- Status: {status}");
//        }
      
//    }
//}
