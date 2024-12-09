using System.Diagnostics;

namespace rand
{




    internal class Program
    {
        struct vecotr2
        {
            public int x;
            public int y;
        }

        static bool numChecker(int input1,Random rand)
        {

            int num1 = rand.Next(0, 30);
            return num1 == input1;







        }
        static void Main(string[] args)
        {
            Random rand = new Random();
            //Console.WriteLine(rand.Next(0,100));//next => 범위 지정
            //int input1 = int.Parse(Console.ReadLine());
            bool isWon;
            //isWon=numChecker(input1,rand);
            //Console.WriteLine(" ");
            //Console.WriteLine("　");//ㄱ한자 1
            Stopwatch sw = new Stopwatch();
            sw.Start();
            vecotr2 playerPos;
            playerPos.x = 0;
            playerPos.y = 0;

            /*
            long reversecounter = 0;
            while (true) {
                reversecounter = (6000 - sw.ElapsedMilliseconds) / 1000;
                Console.WriteLine(reversecounter);
                if (reversecounter > 0) {
                    Console.WriteLine(reversecounter);
                }
                else
                {
                    break;
                    sw.Restart();
                }
            }*/
            bool isFriend = false;
            


            
            while (true)
            {
                if(sw.ElapsedMilliseconds >= 1000)
                {
                   // Console.WriteLine("0.5secon passed");
                   // 
                   // Console.WriteLine(sw.ElapsedMilliseconds);
                    sw.Restart();
                    if (Console.KeyAvailable)//키가 입력되었을 때 작동
                    {
                        ConsoleKeyInfo pressedKey = Console.ReadKey();
                        if (pressedKey.Key == ConsoleKey.Spacebar)
                        {
                            isFriend = true;
                            Console.WriteLine("fire!");
                        }
                        if(isFriend)
                        {
                            playerPos.x += 2;
                        }
                    }
                }
            }


            /*
            while (true) {

                //Console.WriteLine(rand.Next(0, 100));
                Console.WriteLine(sw.ElapsedMilliseconds);
                
                if (Console.KeyAvailable) { //키가 눌렸을 때만 작동
                    var key = Console.ReadKey(true);
                    if (key.Key==ConsoleKey.Spacebar)
                    {
                        Console.WriteLine("oh");
                        break;
                    }




                }

            }*/
            sw.Stop();
            
        }
    }
}
