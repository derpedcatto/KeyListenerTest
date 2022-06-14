using System;

/*
    Метод Listen отслеживает коды нажатых клавиш

    Генерируются события на 
    - Space
    - Enter
    - Escape
    - F1
    - Arrow keys
*/

namespace KeyListenerTest
{
    public class KeyListener
    {
        public delegate void KeyListenerHandler();
        public event KeyListenerHandler KeyPressEvent;

        public void Listen(Hero hero)
        {
            KeyPressEvent = null;

            ConsoleKey key = Console.ReadKey().Key;
            Console.Clear();

            switch (key)
            {
                case ConsoleKey.Spacebar:
                    KeyPressEvent += hero.Jump;
                    break;

                case ConsoleKey.Enter:
                    KeyPressEvent += hero.Action;
                    break;

                case ConsoleKey.F1:
                    KeyPressEvent += hero.Help;
                    break;

                case ConsoleKey.Escape:
                    KeyPressEvent += hero.Exit;
                    break;

                case ConsoleKey.W:
                    KeyPressEvent += hero.MoveForward;
                    break;

                case ConsoleKey.A:
                    KeyPressEvent += hero.MoveLeft;
                    break;

                case ConsoleKey.S:
                    KeyPressEvent += hero.MoveBackwards;
                    break;

                case ConsoleKey.D:
                    KeyPressEvent += hero.MoveRight;
                    break;
            }

            if (KeyPressEvent != null)
                KeyPressEvent.Invoke();
        }
    }
}

// https://github.com/polvictor/KeyListener/blob/master/KeyListener/Program.cs