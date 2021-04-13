using System;
using System.Collections.Generic;
using System.Text;

namespace TrabajoFinaal
{
    class pantalla
    {
        public void pantalla1()
        {
            for (int i = 1; i < 110; i++)
            {
                Console.SetCursorPosition(i, 0); Console.Write("▒");
                Console.SetCursorPosition(i, 6); Console.Write("═");
                Console.SetCursorPosition(i, 9); Console.Write("═");
                Console.SetCursorPosition(i, 22); Console.Write("═");
                Console.SetCursorPosition(i, 25); Console.Write("▒");

            }
            for (int i = 0; i <= 25; i++)

            {
                Console.SetCursorPosition(1, i); Console.Write("░");
                Console.SetCursorPosition(110, i); Console.Write("░");

            }

            Console.SetCursorPosition(60, 13); Console.Write(" BIENVENIDOS ");
            Console.SetCursorPosition(10, 15); Console.Write(" ▓▓▓▓▓ ▓▓▓▓▓▓ ▓▓     ▓   ▓▓▓  ");
            Console.SetCursorPosition(10, 16); Console.Write("▓      ▓      ▓ ▓    ▓  ▓   ▓ ");
            Console.SetCursorPosition(10, 17); Console.Write("▓      ▓      ▓  ▓   ▓ ▓     ▓");
            Console.SetCursorPosition(10, 18); Console.Write(" ▓▓▓▓  ▓▓▓▓▓  ▓   ▓  ▓ ▓▓▓▓▓▓▓");
            Console.SetCursorPosition(10, 19); Console.Write("     ▓ ▓      ▓    ▓ ▓ ▓     ▓");
            Console.SetCursorPosition(10, 20); Console.Write("     ▓ ▓      ▓     ▓▓ ▓     ▓");
            Console.SetCursorPosition(10, 21); Console.Write("▓▓▓▓▓  ▓▓▓▓▓▓ ▓      ▓ ▓     ▓");
            Console.SetCursorPosition(10, 23); Console.WriteLine("Centro de Gestión de Mercados, Logística y Tecnologías de la Información");
        }



        public void pantalla2()
        {
            for (int i = 35; i <= 80; i++)
            {
                Console.SetCursorPosition(i, 0); Console.Write("▒");
                //Console.SetCursorPosition(i, 2); Console.Write("═");
                //Console.SetCursorPosition(i, 18); Console.Write("═");
                Console.SetCursorPosition(i, 35); Console.Write("▒");


            }
            for (int i = 0; i <= 35; i++)

            {
                Console.SetCursorPosition(35, i); Console.Write("░");
                Console.SetCursorPosition(80, i); Console.Write("░");

            }

        }

        public void pantalla3()
        {
            for (int i = 1; i < 80; i++)
            {
                Console.SetCursorPosition(i, 0); Console.Write("▒");
                Console.SetCursorPosition(i, 6); Console.Write("═");
                //Console.SetCursorPosition(i, 9); Console.Write("═");
                //Console.SetCursorPosition(i, 22); Console.Write("═");
                Console.SetCursorPosition(i, 25); Console.Write("▒");

            }
            for (int i = 0; i <= 25; i++)

            {
                Console.SetCursorPosition(1, i); Console.Write("░");
                Console.SetCursorPosition(80, i); Console.Write("░");

            }

        }
    }
}