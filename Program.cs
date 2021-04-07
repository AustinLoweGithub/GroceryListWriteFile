using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GroceryItems;

namespace WriteGroceryListFile
{
        class Program
        {
            static void Main(string[] args)
            {

                bool _continue = true;

                Console.WriteLine("This program creates a grocery list from user input and stores it to a text file at C:\\temp\\GroceryList.txt\n");

                String filepath = @"C:\temp\GroceryList.txt";


                while (_continue)
                {


                    Console.WriteLine("\n\nEnter Grocery name.\n");

                    string _tempName = Console.ReadLine();

                    Console.WriteLine("\nEnter Grocery Quantity.\n");

                    double _tempQuantity = Math.Round(Convert.ToDouble(Console.ReadLine()),0);

                    Console.WriteLine("\nEnter Grocery Price.\n");

                    double _tempPrice = Convert.ToDouble(Console.ReadLine());


                    Groceries GroceryFinal = new Groceries(_tempName, _tempQuantity, _tempPrice);



                    if (!File.Exists(filepath))
                    {
                        StreamWriter sw = new StreamWriter(filepath);

                        sw.WriteLine("Buy " + GroceryFinal.quantity + " " + GroceryFinal.item + " for $" + GroceryFinal.price + " each, a total cost of: " + GroceryFinal.totalcost);

                        sw.Close();


                    }



                    else if (File.Exists(filepath))
                    {
                        File.AppendAllText(filepath, "\nBuy " + GroceryFinal.quantity + " " + GroceryFinal.item + " for $" + GroceryFinal.price + " each, a total cost of: " + GroceryFinal.totalcost);
                        
                        

                    }

                    StreamReader sr = new StreamReader(filepath);

                    string textline;

                    while ((textline = sr.ReadLine()) != null)
                    {

                        Console.WriteLine(textline);

                    }

                          sr.Close();




                    Console.WriteLine("\n\nPress x to exit, or any other key to enter another item.\n\n");

                    char _exitcheck1 = Console.ReadKey().KeyChar;

                    if (char.ToLower(_exitcheck1) == 'x') { _continue = false; }



                }

                Console.WriteLine("\n\nPress d to delete the file or any other key to keep it in C:\\temp\\GroceryList.txt\n");

                char _exitcheck2 = Console.ReadKey().KeyChar;

                if (char.ToLower(_exitcheck2) == 'd')
                {
                    File.Delete(filepath); Console.WriteLine("\nC:\\temp\\GroceryList.txt has been deleted!\n\nPress any key to close program");

                
                 }

            
            }
        }
    }


    //Create a grocery item class and a list of groceries
    // view grocery list on console window
    // write to file
    // empty file and chjeck file has been emptied
    // exit the program
    // put in loop so can be done as long as user wants until exit is entered
    // save name, quantity, and price

    

