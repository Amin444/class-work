using System;

namespace циклы
{
    class Program
    {
        static void Main(string[] args)
        {
           /* System.Console.WriteLine("Число:");
            int num=int.Parse(Console.ReadLine());
            for(int i=0;i<=10;i++)
            {
                System.Console.WriteLine($"{num}X{i}={num*i}");
            }*/

           /* System.Console.WriteLine("От числа:");
            int beginNum=int.Parse(Console.ReadLine());

            System.Console.WriteLine("До числа:");
            int toNum=int.Parse(Console.ReadLine());
            for(int i=beginNum ;i<=toNum; beginNum++)
            {
                if(i%2==0)
                {
                    System.Console.WriteLine(i);
                }
            }*/

          //  System.Console.WriteLine(DateTime.Now);
         // System.Console.WriteLine(DateTime.Now.ToString("dd/mm/yyyy"));

           // DateTime DateTimeAfter55seconds=DateTime.Now.AddSeconds(5);

         /*for(;;)
         {
             Console.Clear();
             System.Console.WriteLine(DateTime.Now);
                if(DateTimeAfter55seconds.ToString("dd/mm/yyyy hh:mm:ss")==DateTime.Now.ToString("dd/mm/yyyy hh:mm:ss"))
                {
                        break;
                }*/

                  //  --------------------------------------While--------------------------------------------

                   /* int Num=5;
                    int numoftry=3;
                    while(numoftry!=0)
                    {
                            System.Console.Write("От годай число:");
                            int inputNum=int.Parse(Console.ReadLine());
                            if(inputNum!=Num)
                            {
                                numoftry--;
                                System.Console.WriteLine($"Попыток осталось {numoftry}");
                            }
                            else
                            {
                                System.Console.WriteLine("Поздравляю ты угодал!!!");
                                break;
                            }
                    }*/
                                
                     /*  System.Console.WriteLine("Добро пожаловать в игру под названием висилица!");
                       System.Console.WriteLine("Если хотите узнать правила нажните на '1'");
                       int one =int.Parse(Console.ReadLine());
                       if(one==1)
                       {
                           System.Console.WriteLine("fvdgrdfrdg");
                       }
                            int attemps=3;
                            string Word="деньги";
                            for(int i=1;i<=attemps;i++)
                            {
                     
                                    System.Console.WriteLine("Что правит миром?");
                                string Person=Console.ReadLine();
                                    if(Word.ToLower()==Person.ToLower())
                                    {
                                        System.Console.WriteLine($"Вы ответили верно!->{Word}");
                                    }
                                        else
                                        {
                                            System.Console.WriteLine($"Попыток сгорело->{i}");
                                        }
                               }*/

                               int a=5,b=11;
                               int w=0;
                               for(int i=a;i<=b;i++)
                               {
                                 w+=i;  
                                 
                                    System.Console.WriteLine(w);
                               }
                            
                Console.ReadKey();
                      
                      
                       
                 

         }
        
    }
}
