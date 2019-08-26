using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontyHallHW4
{
    class Game
    {

        private bool[] door;
        int randNum;
        int wins;
        int losses;
        int userChoice;
        int nRand;
        
        int discardMe;







        public void PlayGame()
        { 
            
        door = new bool[3]{false, false, false};
        Random randNum = new Random();
        nRand = randNum.Next(1, 3);
            switch (nRand)
                {

                case 1:
                    if (nRand = 1)
                    {
                        door[nRand - 1] = door[nRand - 1] == true ? false : true;
                        break;
                    }
                case 2:
                    door[nRand - 1] = door[nRand - 1] == true ? false : true;
                    break;


                case 3:
                    door[nRand - 1] = door[nRand - 1] == true ? false : true;
                    break;


            }
                
            {
                


            }




        }
    




    }


}
