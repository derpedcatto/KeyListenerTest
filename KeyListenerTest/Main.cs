using System;

namespace KeyListenerTest
{
    class Program
    {
        static void Main()
        {
            KeyListener keylistener = new();
            Hero hero = new();

            Console.WriteLine("Press F1 for help.");
            while(true)
            {
                keylistener.Listen(hero);
            }
        }
    }
}