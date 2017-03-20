using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondLab
{
   class Game2 : Game
    {
        public Game2(params int[] field) : base(field) // используем конструктор для создания поля в базовом классе
        {
        Randomize();
        }

        public void Randomize()
        {
            List<int> rand_list = new List<int>();
            Random random = new Random();
          
            
            int[] values_in_random = new int[Field.Length];
         
            for (int i = 0; i < Field.Length; i++)
            {
                while (rand_list.Contains(values_in_random[i]))
                {
                    values_in_random[i] = random.Next(1, Field.Length);
                    
                }
               
                rand_list.Add(values_in_random[i]);
            }
         

            base.Filling(values_in_random);
        }


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
