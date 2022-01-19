// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;
using System.Collections.Generic;

namespace ATM 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Options Vo =new Options();

            try{

                List<PersonDetail> Info = new List<PersonDetail>();
                Info.Add(new PersonDetail{
                    Code=1234,
                    Balance = 10000,
                    Name="Ankita Lande"
                });

                Info.Add(new PersonDetail{
                    Code=4587,
                    Balance = 30000,
                    Name="prashant Suryawanshi"
                });

                Info.Add(new PersonDetail{
                    Code=0000,
                    Balance = 18000,
                    Name="sayali Kumbhar"
                });

                Info.Add(new PersonDetail{
                    Code=4567,
                    Balance = 800,
                    Name="Nikita Lande"
                });

                Console.WriteLine("Enter 4 digit pin of your card? ");
                int CardNumber = Convert.ToInt32(Console.ReadLine());
                
                foreach(var PersonDetail in Info){
                    if(PersonDetail.Code==CardNumber){

                        bool endValue = false;
                        Console.WriteLine($"Hello {PersonDetail.Name} welcome to our ATM");
                        while(!endValue){
                            
                            Vo.Opp();

                        switch(Convert.ToInt32(Console.ReadLine())){

                            case 1:
                                Console.WriteLine("Enter how much money you have to withdraw?");
                                int Wi = Convert.ToInt32(Console.ReadLine());
                                if(Wi>=PersonDetail.Balance){
                                    Console.WriteLine("Insuficient Balance");
                                    Console.WriteLine("--------------------");
                                }
                                else{
                                    PersonDetail.Balance-=Wi;
                                    Console.WriteLine($"withdraw completed and your remaining Balance is {PersonDetail.Balance} ");
                                    Console.WriteLine("--------------------");
                                }
                                break;

                            case 2:
                                Console.WriteLine($"You have remainig Balance {PersonDetail.Balance}");
                                Console.WriteLine("--------------------");
                                break;

                            case 3:
                                Console.WriteLine("Enter the amount to be deposite");
                                int Dep = Convert.ToInt32(Console.ReadLine());
                                PersonDetail.Balance += Dep;
                                Console.WriteLine($"Your current Balance is {PersonDetail.Balance}");
                                Console.WriteLine("--------------------");
                                break;
                                
                            case 4:
                                Console.WriteLine("press 4 once again to exit");
                                if(Convert.ToInt32(Console.ReadLine())==4){
                                    endValue = true;
                                    }
                                break;

                            default:
                                Console.WriteLine("Enter proper number");
                                break;
                        }
                    }

                    

                }

            }
            }

            catch(Exception ex){
                Console.WriteLine(ex.Message);
            }
        }
    }
              
            
}
