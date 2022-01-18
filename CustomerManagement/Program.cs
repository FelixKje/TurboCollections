using System;
using System.Collections.Generic;
using TurboCollections;

namespace CustomerManagement{
    class Program{
        static void Main(string[] args){
            var list = new TurboList<string>();
            int numberInput;
            string stringInput;
            
            while (true){
                Console.WriteLine("(1) Add a customer");
                Console.WriteLine("(2) Remove a Customer by name");
                Console.WriteLine("(3) Remove a Customer by index");
                Console.WriteLine("(4) Display all Customers");
                
                numberInput = Convert.ToInt32(Console.ReadLine());
                if (numberInput <=  4 && numberInput > 0){
                    if (numberInput == 1){
                        Console.WriteLine("Whats the Customer's name?");
                        stringInput = Console.ReadLine();
                        list.Add(stringInput);
                    }
                    if (numberInput == 2){
                        Console.WriteLine("Whats the Customer's name that you would like to remove?");
                        stringInput = Console.ReadLine();
                        list.Remove(stringInput);
                    }
                    if (numberInput == 3){
                        Console.WriteLine("Whats the Customer's index that you would like to remove?");
                        numberInput = Convert.ToInt32(Console.ReadLine());
                        list.RemoveAt(numberInput);
                    }
                    if (numberInput == 4){
                        Console.WriteLine("Here's a list of all Customers");
                        for (int i = 0; i < list.Count; i++){
                            Console.WriteLine(list.Get(i));
                        }
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                    }
                }
            }
        }
    }
}