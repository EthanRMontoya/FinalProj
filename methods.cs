using System.Threading;
using System.Diagnostics;
using static MyApp.Program;
namespace coreMethod
{
    public class Ultilities
    {
        //displays name up top
        public static void nameFr()
        {
            Console.ForegroundColor = GetRandomConsoleColor();
            Console.WriteLine("-------------------------------------------------------");
            string name = @" ________   ___        ________   _________   ________      
|\   ____\ |\  \      |\   __  \ |\___   ___\|\   ____\     
\ \  \___|_\ \  \     \ \  \|\  \\|___ \  \_|\ \  \___|_    
 \ \_____  \\ \  \     \ \  \\\  \    \ \  \  \ \_____  \   
  \|____|\  \\ \  \____ \ \  \\\  \    \ \  \  \|____|\  \  
    ____\_\  \\ \_______\\ \_______\    \ \__\   ____\_\  \ 
   |\_________\\|_______| \|_______|     \|__|  |\_________\
   \|_________|                                 \|_________|
                                                            
                                                            ";
            Console.WriteLine(name);
            Console.WriteLine("your current funds are" + " " + Tpoints + " " + "type x to exit");
            Console.WriteLine("---------------------------------------------------------");
        }

        //creating our random number generator
        private static Random _random = new Random();

        //creating our random color generator 
        public static ConsoleColor GetRandomConsoleColor()
        {
            var consoleColors = Enum.GetValues(typeof(ConsoleColor));
            return (ConsoleColor)consoleColors.GetValue(_random.Next(consoleColors.Length));
        }

        //method to check if we hit a multiplier
        static bool MultiCheck(int num1, int num2, int num3, int num4, int num5, int num6, int num7, int num8, int num9, int points)
        {
            if (num1 == num2 && num1 == num3 || num4 == num5 && num5 == num6 || num7 == num8 && num8 == num9)
            {
                Console.ForegroundColor = GetRandomConsoleColor();
                Console.WriteLine("multiplier!");
                Console.WriteLine("your new points are!" + Tpoints++);
                Console.ReadLine();
                return true;
            }
            if (num1 == num5 && num5 == num9)
            {
                Console.ForegroundColor = GetRandomConsoleColor();
                Console.WriteLine("side ways multiplier!");
                Console.ReadLine();
                return true;
            }
            if (num3 == num5 && num5 == num7)
            {
                Console.ForegroundColor = GetRandomConsoleColor();
                Console.WriteLine("side ways multiplier!");
                Console.ReadLine();
                return true;
            }
            else
            {
                return false;
            }
        }

        //easy convert method
        public static string ConvertMyNums(int num)
        {
            string visualNum = Convert.ToString(num);
            return visualNum;
        }

        //our public points system
        public static int Tpoints = _random.Next(1,20);

        //our main workhorse
        public static void RandomNum(int points)
        {

            //creating our random numbers super ugly like
            var rNum1 = new Random();
            int nVisualR1 = rNum1.Next(0, 10);
            int nVisualR2 = rNum1.Next(0, 10);
            int nVisualR3 = rNum1.Next(0, 10);
            int nVisualR4 = rNum1.Next(0, 10);
            int nVisualR5 = rNum1.Next(0, 10);
            int nVisualR6 = rNum1.Next(0, 10);
            int nVisualR7 = rNum1.Next(0, 10);
            int nVisualR8 = rNum1.Next(0, 10);
            int nVisualR9 = rNum1.Next(0, 10);

            //displaying our numbers and waitin super ugly code
            PrintNum(13, 0, nVisualR1);
            GetRandSleep();
            PrintNum(13, 12, nVisualR2);
            GetRandSleep();
            PrintNum(13, 24, nVisualR3);
            GetRandSleep();
            PrintNum(20, 0, nVisualR4);
            GetRandSleep();
            PrintNum(20, 12, nVisualR5);
            GetRandSleep();
            PrintNum(20, 24, nVisualR6);
            GetRandSleep();
            PrintNum(28, 0, nVisualR7);
            GetRandSleep();
            PrintNum(28, 12, nVisualR8);
            GetRandSleep();
            PrintNum(28, 24, nVisualR9);
            GetRandSleep();

            //using our MultiCheck method with the random numbers that we created and 
            //displayed

            var frPoints = MultiCheck(nVisualR1, nVisualR2, nVisualR3, nVisualR5, nVisualR6, nVisualR7, nVisualR7, nVisualR8, nVisualR9, Tpoints);

            //check to see if we add points 
            if (frPoints == false)
            {
                Tpoints--;
            }
            else
            {
                Tpoints++;
                Console.WriteLine("your points are" + Tpoints);
            }
            string target = "https://www.ncpgambling.org/5475-2/";

            //what happens when we run out of points?
            if (Tpoints <= 0)
            {
                try
                {
                    Process.Start(new ProcessStartInfo { FileName = target, UseShellExecute = true });
                }

                catch (System.ComponentModel.Win32Exception noBrowser)
                {
                    Console.Write("error bud");
                }
            }

            Thread.Sleep(500);
            var exit = Console.ReadLine();
            if (exit == "x")
            {
                Environment.Exit(1);
            }
            else{
            Console.Clear();
            }
        }

        //using our random number gnerator and our sleep for a more 
        //realistic feel 
        public static void GetRandSleep()
        {
            Console.ForegroundColor = GetRandomConsoleColor();
            Thread.Sleep(300);
        }


        //where we link our ints to a pretty visual 
        public static void PrintNum(int top, int left, int num)
        {
            string value = null;
            if (num == 0)
            {
                value = (@" :::::::  
:+:   :+: 
+:+  :+:+ 
+#+ + +:+ 
+#+#  +#+ 
#+#   #+# 
 #######  ");
            }
            if (num == 1)
            {
                value = (@"  :::   
:+:+:   
  +:+   
  +#+   
  +#+   
  #+#   
####### ");
            }
            if (num == 2)
            {
                value = (@" ::::::::  
:+:    :+: 
      +:+  
    +#+    
  +#+      
 #+#       
########## ");
            }
            if (num == 3)
            {
                value = (@" ::::::::  
:+:    :+: 
       +:+ 
    +#++:  
       +#+ 
#+#    #+# 
 ########  ");
            }
            if (num == 4)
            {
                value = (@"    :::     
   :+:      
  +:+ +:+   
 +#+  +:+   
+#+#+#+#+#+ 
      #+#   
      ###   ");
            }
            if (num == 5)
            {
                value = (@":::::::::: 
:+:    :+: 
+:+        
+#++:++#+  
       +#+ 
#+#    #+# 
 ########  ");
            }
            if (num == 6)
            {
                value = (@" ::::::::  
:+:    :+: 
+:+        
+#++:++#+  
+#+    +#+ 
#+#    #+# 
 ########  ");
            }
            if (num == 7)
            {
                value = (@"::::::::::: 
:+:     :+: 
       +:+  
      +#+   
     +#+    
    #+#     
    ###     ");
            }
            if (num == 8)
            {
                value = (@" ::::::::  
:+:    :+: 
+:+    +:+ 
 +#++:++#  
+#+    +#+ 
#+#    #+# 
 ########  ");
            }
            if (num == 9)
            {
                value = (@" ::::::::  
:+:    :+: 
+:+    +:+ 
 +#++:++#+ 
       +#+ 
#+#    #+# 
 ########  ");
            }
            if (num == 10)
            {
                value = (@"  :::   :::::::  
:+:+:  :+:   :+: 
  +:+  +:+  :+:+ 
  +#+  +#+ + +:+ 
  +#+  +#+#  +#+ 
  #+#  #+#   #+# 
####### #######  ");
            }

            //where we split up our visuals line by line and print them out in the
            //correct spacing

            var lines = value.Split(Environment.NewLine);

            for (int line = 0; line < lines.Length; line++)
            {
                Console.CursorTop = top + line;
                Console.CursorLeft = left;
                Console.Write(lines[line]);
            }

            return;
        }
    }
}