﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basicprograms1
{
    internal class Student_Calculation : Student_marks
    {
        private double tot, avg;

        public Student_Calculation(int rno, string name, double mark1, 
            double mark2, double mark3, double tot, double avg)
            : base (rno, name, mark1, mark2, mark3)
        {
            //base( rno,  name,  mark1, mark2, mark3);
            this.Tot = tot;
            this.Avg = avg;
        }

        public double Tot { get => tot; set => tot = value; }
        public double Avg { get => avg; set => avg = value; }

        public void Calculate()
        {
            this.Tot = this.Mark1 + this.Mark2 + this.Mark3;
            this.Avg = this.Tot / 3;

        }
    }
}
