using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class Bank_Acc
    {
        private int custid;
        private string name;
        private long accno;
        private double balance;
        private string status;

        public Bank_Acc(int custid, long accno, string name,  double balance, string status)
        {
            this.Custid = custid;
            this.Name = name;
            this.Accno = accno;
            this.Balance = balance;
            this.Status = status;
        }

        public int Custid { get => custid; set => custid = value; }
        public string Name { get => name; set => name = value; }
        public long Accno { get => accno; set => accno = value; }
        public double Balance { get => balance; set => balance = value; }
        public string Status { get => status; set => status = value; }

        public void checkaccstatus(int custid  )
        {
            if (custid == Custid)
            {
                name = Name;
                accno = Accno;
                balance = Balance;
                status = Status;

            }
                

        }

        public void checkaccstatus( long accno)
        {
            if (accno == Accno)
            {
                name = Name;
                
                balance = Balance;
                status = Status;
                custid = Custid;

            }


        }

        public void checkaccstatus(string name)
        {
            if (name == Name)
            {
               
                accno = Accno;
                balance = Balance;
                status = Status;
                custid = Custid;

            }


        }
    }
}
