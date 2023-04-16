using System;

namespace Lab_Generics_ElinSUT22 // Elin Linderholm SUT22
{
    class Program
    {
        static void Main(string[] args)
        {   
            // skapar ett objekt av mina boxar och lägger till objekt i den

            BoxCollection boxes = new BoxCollection();

            boxes.Add(new Box(10, 15, 20));
            boxes.Add(new Box(20, 15, 10));   //samma volym som första boxen, kommer inte läggas till och meddelande visas
            boxes.Add(new Box(30, 10, 40));
            boxes.Add(new Box(5, 5, 5));
            boxes.Add(new Box(40, 50, 70));
            boxes.Add(new Box(100, 100, 50));

            Console.WriteLine("******************************");
            // skriver ut alla objekten

            DisplayBoxes(boxes);
            Console.WriteLine("******************************");

            //försöker lägga till box med samma dimensioner som redan finns

            boxes.Add(new Box(5, 5, 5));
            Console.WriteLine("******************************");
            // tar bort box ur collectionen

            boxes.Remove(new Box(5, 5, 5));

            // skriver ut objekten igen
            Console.WriteLine("******************************");
            DisplayBoxes(boxes);
            Console.WriteLine("******************************");
            // kollar om en box med dessa dimensioner eller mått finns med

            boxes.CheckifContainsBox(new Box(100,100,50));
            Console.WriteLine("******************************");
            boxes.CheckifContainsBox(new Box(20, 15, 10));



            Console.ReadKey();



        }
        //metod för att skriva ut alla objekt i collections

        public static void DisplayBoxes( BoxCollection boxes)
        {
            Console.WriteLine("Boxes: height x length x width in cm:");

            foreach(Box box in boxes)
            {
                Console.WriteLine("{0} x {1} x {2}", box.height, box.length, box.width);
            }
        }
    }
}
