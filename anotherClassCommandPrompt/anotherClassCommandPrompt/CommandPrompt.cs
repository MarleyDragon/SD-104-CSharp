using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace anotherClassCommandPrompt
{
    class CommandPrompt
    {
        ConsoleColor backgroundColor;
        ConsoleColor foregroundColor;
        string[] screenText;
            int height;
            int columns;
          // end of CommandPrompt class

        public CommandPrompt(int height, int columns)
        {
            backgroundColor = ConsoleColor.Red;   // or whatever you like
            foregroundColor = ConsoleColor.Black; // or whatever you like

            // create the screen to hold the number of rows passed in with the height parameter

            screenText = new string[height];

            // we will use the C# object to set the size of our window.
            Console.SetWindowSize(columns, height + 7);

            // let's set the initial screen rows to all blank lines
            for (int i = 0; i < screenText.Length; i++)
            {
                screenText[i] = "";
            }
        }   // end of CommandPrompt constructor
        public void SetBackgroundColor(string color)
        {
            backgroundColor = ConvertColor(color);
        }   // end of SetBackgroundColor

        public void SetForegroundColor(string color)
        {
            foregroundColor = ConvertColor(color);
        }   // end of SetForegroundColor
        public static ConsoleColor ConvertColor(string strColor)
        {
            ConsoleColor color;
            switch (strColor.ToLower())
            {
                case "black": color = ConsoleColor.Black; break;
                case "red": color = ConsoleColor.Red; break;
                case "blue": color = ConsoleColor.Blue; break;
                case "green":color = ConsoleColor.Green;break;
                case "yellow":color = ConsoleColor.Yellow;break;
                case "cyan":color = ConsoleColor.Cyan;break;
                case "darkblue": color = ConsoleColor.DarkBlue; break;
                case "darkcyan": color = ConsoleColor.DarkCyan; break;
                case "darkgray": color = ConsoleColor.DarkGray; break;
                case "darkgreen": color = ConsoleColor.DarkGreen; break;
                case "darkmagenta": color = ConsoleColor.DarkMagenta; break;
                case "darkred": color = ConsoleColor.DarkRed; break;
                case "darkyellow": color = ConsoleColor.DarkYellow; break;
                case "gray": color = ConsoleColor.Gray; break;
                case "magenta": color = ConsoleColor.Magenta; break;

                default: color = ConsoleColor.DarkGray; break;
            }
            return color;
        }   // end of ConvertColor method

        public void Display()
        {
            Console.BackgroundColor = backgroundColor;
            Console.ForegroundColor = foregroundColor;
            Console.Clear();             //  the Console object is available to us to control aspects of our terminal window. The Clear method will blank our window
                                         // The Clear method has blanked the screen and left the cursor at the top of the window.
                                         // We will now loop through the screenText array to put out text on the screen.
            for (int i = 0; i < screenText.Length; i++)
            {
                Console.WriteLine(screenText[i]);
            }
        }   // end of Display method


        public void SetScreenText(int lineNumber, string lineOfText)
        {
            screenText[lineNumber] = lineOfText;
        }   // end of SetScreenText method


        public void ClearScreen()
        {
            Console.Clear();
             for (int i = 0; i < screenText.Length; i++)
            {
                screenText[i] = "";
            }

        }
        public void SaveScreen(string fileName)
        {
            FileStream stream;
            StreamWriter textOut = null;
            ConsoleColor a, b;
            try
            {
                fileName = "C:/Users/ACT/Desktop/Projects/SD104-CSharp/SD-104-CSharp/anotherClassCommandPrompt/" + fileName;
                stream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
                textOut = new StreamWriter(stream);
                //your code here!!!
                textOut.WriteLine(height);
                textOut.WriteLine(columns);
                textOut.WriteLine(backgroundColor);
                textOut.WriteLine(foregroundColor);


                for (int i = 0; i < screenText.Length; i++)
                {
                    textOut.WriteLine(screenText[i]);
                    //textOut.Write(backgroundColor, foregroundColor);
                }

                //backgroundColor =  a;
                //foregroundColor =  b;




                



            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Creating file: ");
                Console.WriteLine(ex.ToString());
                return;
            }
            finally
            {
                if (textOut != null)
                    textOut.Close();
            }
        }   // of of SaveScreen method
        public void ReloadScreen(string fileName)
        {
            FileStream stream;

            try
            {
                fileName = "C:/Users/ACT/Desktop/Projects/SD104-CSharp/SD-104-CSharp/anotherClassCommandPrompt/" + fileName;
                stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                //textIn = new StreamReader(stream);
                //your code here!!!



                using (StreamReader textIn = new StreamReader(stream))
                {
                    height = Convert.ToInt32(textIn.ReadLine());
                    columns = Convert.ToInt32(textIn.ReadLine());
                    backgroundColor = ConvertColor(textIn.ReadLine());
                    foregroundColor = ConvertColor(textIn.ReadLine());

                    screenText = new string [height];


                    for (int i = 0; i < screenText.Length; i++)
                    {
                        screenText[i] = textIn.ReadLine();
                    }
                    //Console.WriteLine(textIn.ReadToEnd());
                    Console.ReadLine();
                }


            }

            catch (Exception ex)
            {
                Console.WriteLine("Error Creating file: ");
                Console.WriteLine(ex.ToString());
                return;
            }
            finally
            {
               // textIn.Close();

            }


        }

    }
}

