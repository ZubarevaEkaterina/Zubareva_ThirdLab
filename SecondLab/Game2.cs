using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondLab
{
   class Game2 : Game
    {
        public Game2(params int[] field) : base(field)
        {
          
        }

        public void Randomize()
        { }


        public bool End_of_the_game
        {
            get
            {
                int k = 1;
                for (int x = 0; x < Field.GetLength(0); x++)
                {
                    for (int y = 0; y < Field.GetLength(1); y++)
                    {
                        if (Field[x, y] != k && k < Field.Length)

                            return false;
                        k++;

                    }
                }
                return true;

            }
        }
    }
}
