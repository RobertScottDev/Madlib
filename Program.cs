using System;

namespace Madlib
{
    class Program
    {
        static void Main(string[] args)
        {

            // Init Variables
            string player;
            string element;
            string[] thing = new string[3];

            
            //Run Game
            Console.WriteLine("Hello Welcome to Madlib");
            Console.WriteLine("Can I have your name ?");
            player = Console.ReadLine();
            string motion;
            string motionTwo;

            Console.Clear();
            Console.WriteLine($"Okay {player} lets start !");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine($" First {player} give me an element !");
            element = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Now how about Containers. Cup, Bowl, etc");
            for (int i = 0; i < thing.Length; i++)
            {
                Console.WriteLine($"Containers {i + 1} / {thing.Length}");
                thing[i] = Console.ReadLine();
            }
            Console.WriteLine("Now two states of moving");
            motion = Console.ReadLine();
            motionTwo = Console.ReadLine();
            Console.Clear();
                

            


            
                //Madlib Story
            string madlib =
                $"Empty your mind, be formless, shapeless — like {element}. Now you put {element} in a {thing[0]},\n" +
                $"it becomes the {thing[0]}; You put {element} into a {thing[1]} it becomes the {thing[1]}; \n" +
                $"You put it in a {thing[2]} it becomes the {thing[2]}. Now {element} can {motion} or it can {motionTwo}. \n" +
                $"Be {element}, {player}."; 

            //Init Story

            Console.WriteLine(madlib);
            Console.ReadKey();




        }
    }
}
