using System;

namespace Estructura_de_datos
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] array = new int[5];
            array[0] = 5;
            array[1] = 8;
            array[2] = 6;
            array[3] = 2;
            array[4] = 7;

            string list = GetNextGreaterElement(array);

            Console.WriteLine(list);

            Random rnd = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Iteración #" + (i + 1));

                for (int j = 0; j < array.Length; j++)
                {
                    array[j] = rnd.Next();
                    Console.WriteLine(array[j]);
                }
            }
        }

        public static string GetNextGreaterElement(int[] elements)
        {
            string list = "";

            for (int i = 0; i < elements.Length; i++)
            {
                list = list + elements[i] + " -> ";

                for (int j = i + 1; j < elements.Length; j++)
                {

                    if (elements[i] < elements[j])
                    {
                        list += elements[j] + "\n";
                        j = elements.Length;
                    }
                    else
                    {
                        if (j == elements.Length - 1)
                        {
                            list += "-1\n";
                        }
                    }
                }
            }

            return list;
        }
    }
}
