using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Sabirov
{
    class StudentBaseGetSet
    {
        private string name;
        private int marks;

        public int Marks
        {
            get
            {
                return marks;
            }
            set
            {
                if (value < 2) marks = 2;
                else if (value > 5) marks = 5;
                else marks = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
    }
}
