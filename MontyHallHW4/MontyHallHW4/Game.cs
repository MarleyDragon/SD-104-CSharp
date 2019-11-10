using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontyHallHW4
{
    class Game
    {
        static void Main(string[] args)
        {
            bool[] door;
            int nSwapped = 0, nStayed = 0;
            int nPlayer = 0;
            int nEliminated = 0;
            bool didSwap;
            Random rand = new Random();
            


            for (int n = 0; n < 10000; n++)
            {
                door = new bool[] { false, false, false };
                //initial car placement and player pic      
                door[rand.Next( 0, 2 )] = true;
                nPlayer = n % 3;
                didSwap = false;
                //find door to eliminate    
                for ( int h = 0; h < door.Length; h++ )
                {
                    if ( !door[h] && h != nPlayer )
                    {
                        nEliminated = h;
                        break;
                    }
                }
                //player swaps on even  
                if ( n % 2 == 0 )
                {
                    //find other door to switch to  
                    for ( int swap = 0; swap < door.Length; swap++ )
                    {
                        if ( swap != nEliminated && swap != nPlayer )
                        {
                            nPlayer = swap;
                            break;
                        }
                    }
                    didSwap = true;
                }
                //see if player won or lost      
                if ( door[nPlayer] && didSwap )
                {
                    nSwapped++;
                }
                else if ( door[nPlayer] && !didSwap )
                {
                    nStayed++;
                }

               
                    

            }
            
               
            Console.WriteLine("The player won {0} times when swapping and {1} times when not swapping out of 10,000 turns.", nSwapped, nStayed);
            
            Console.ReadLine();
        }
    }
}