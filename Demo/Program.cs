using System;
using System.Collections.Generic;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<string> names = new List<string>
            //{
            //    "Ivan",
            //    "Pesho",
            //    "Go6o"
            //};

            //names.Insert(1, "Yoana");

            //Console.WriteLine(names.Remove("Go6o"));

            //Console.WriteLine(names.Count);

            //string name = Console.ReadLine();

            //Console.WriteLine($"Contains -> {names.Contains(name)}");

            //Console.WriteLine(string.Join(", ", names));

            string[] input =
            {
                "Brachiosaurus",
                "Amargasaurus",
                "Mamenchisaurus"
            };

            List<string> dinosaurs = new List<string>(input);

            Console.WriteLine("\nCapacity: {0}", dinosaurs.Capacity);

            Console.WriteLine();
            foreach (string dinosaur in dinosaurs)
            {
                Console.WriteLine(dinosaur);
            }

            Console.WriteLine("\nAddRange(dinosaurs)");
            dinosaurs.AddRange(dinosaurs);

            Console.WriteLine();
            foreach (string dinosaur in dinosaurs)
            {
                Console.WriteLine(dinosaur);
            }

            Console.WriteLine("\nRemoveRange(2, 2)");
            dinosaurs.RemoveRange(2, 2);

            Console.WriteLine();
            foreach (string dinosaur in dinosaurs)
            {
                Console.WriteLine(dinosaur);
            }

            input = new string[]
            {
                "Tyrannosaurus",
                "Deinonychus",
                "Velociraptor"
            };

            Console.WriteLine("\nInsertRange(3, input)");
            dinosaurs.InsertRange(3, input);

            Console.WriteLine();
            foreach (string dinosaur in dinosaurs)
            {
                Console.WriteLine(dinosaur);
            }

            Console.WriteLine("\noutput = dinosaurs.GetRange(2, 3).ToArray()");
            string[] output = dinosaurs.GetRange(2, 3).ToArray();

            Console.WriteLine();
            foreach (string dinosaur in output)
            {
                Console.WriteLine(dinosaur);

                /* This code example produces the following output:

                Capacity: 3

                Brachiosaurus
                Amargasaurus
                Mamenchisaurus

                AddRange(dinosaurs)

                Brachiosaurus
                Amargasaurus
                Mamenchisaurus
                Brachiosaurus
                Amargasaurus
                Mamenchisaurus

                RemoveRange(2, 2)

                Brachiosaurus
                Amargasaurus
                Amargasaurus
                Mamenchisaurus

                InsertRange(3, input)

                Brachiosaurus
                Amargasaurus
                Amargasaurus
                Tyrannosaurus
                Deinonychus
                Velociraptor
                Mamenchisaurus

                output = dinosaurs.GetRange(2, 3).ToArray()

                Amargasaurus
                Tyrannosaurus
                Deinonychus
                 */
            }
        }
    }
}

