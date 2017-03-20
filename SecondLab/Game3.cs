using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondLab
{
    class Game3 : Game2

       
    {
        public readonly List<int> History;
        public Game3(params int[] values) : base(values)
        {
            History = new List<int>();
        }

        public override bool Shift(int value)
        {
            bool if_shift = base.Shift(value);
            if (if_shift)
            {
                History.Add(value);
            }


            return if_shift;

        }      

   
        }
    }