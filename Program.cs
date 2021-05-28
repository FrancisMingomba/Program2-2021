using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Program2
{
    class Program
    {
        static void Main(string[] args)
        {

            String path = "C:/Users/mingo/OneDrive/Documents/csvFile.csv";

            try
            {
                if (!path.EndsWith(".csv"))
                {
                    Console.WriteLine("Wrong file extension");
                }
                else
                {
                    string[] lines = System.IO.File.ReadAllLines(path);

                    List<double> listA = new List<double>();
                    List<string> listB = new List<string>();

                    foreach (var k in lines)
                    {
                        string[] line = k.Split(',');
                        //listA.Add(Convert.ToInt32(line[1]));                    
                        if (line.Length > 2)
                        {
                            throw new FormatException("Bad data");
                        }
                        else
                        {
                            double myValue = Convert.ToDouble((line[1]));
                            Console.WriteLine("Debug: " + "Added " + myValue + " to the list A");
                            listA.Add((double)myValue);
                            // listA.Add((int)Convert.ToDouble((line[1])));
                        }
                        listB.Add(line[0]);

                    }
                    // Extract element at last position of the list to insert " and " in front of it
                    var lastItem = listB[listB.Count - 1];
                    listB.RemoveAt(listB.Count - 1);

                    //Insert comma the list elements
                    string[] names = listB.ToArray();
                    var str = String.Join(",", names);
                    double av = listA.Average();

                    Console.Write(str + " and " + lastItem + "'" + "s " + "average" + " " + "is " + av);//.ToString("#.##"));
                }
            }
            catch (FileNotFoundException e)
            {
                // Console.WriteLine("File does not exist", e.Message);
                Console.WriteLine("File Not Found Exception:" + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format Exception: " + e.Message);
            }
            catch (IOException e)
            {
                Console.WriteLine("IOException: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Catch All Exception: " + e.Message);
               
            }
            

            Console.ReadLine();
        }


    }
}









