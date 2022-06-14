using System;

/*
    Сделать обработчики событий в Hero
    Space - 'Jump'
    Enter - 'Select' итд
*/

namespace KeyListenerTest
{
    public class Hero
    {
        public void Jump()
        {
            Console.WriteLine("Jump");
        }
        public void Action()
        {
            Console.WriteLine("Action");
        }
        public void MoveForward()
        {
            Console.WriteLine("Move forward");
        }
        public void MoveBackwards()
        {
            Console.WriteLine("Move backwards");
        }
        public void MoveLeft()
        {
            Console.WriteLine("Move left");
        }
        public void MoveRight()
        {
            Console.WriteLine("Move right");
        }
        public void Help()
        {
            Console.WriteLine("Spacebar - Jump\nEnter - Action\nWASD - Movement\nEscape - Exit");
        }
        public void Exit()
        {
            Environment.Exit(0);
        }
    }
}
