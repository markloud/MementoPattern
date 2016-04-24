using MementoPattern;
using System;

namespace MementoPattern
{
    /// <summary>
    /// MainApp startup class for Real-World
    /// Memento Design Pattern.
    /// </summary>
    internal class MainApp
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        private static void Main()
        {
            Originator<string> orig = new Originator<string>();

            orig.SetState("state0");
            Caretaker<string>.SaveState(orig); //save state of the originator
            orig.ShowState();

            orig.SetState("state1");
            Caretaker<string>.SaveState(orig); //save state of the originator
            orig.ShowState();

            orig.SetState("state2");
            Caretaker<string>.SaveState(orig); //save state of the originator
            orig.ShowState();

            //restore state of the originator
            Caretaker<string>.RestoreState(orig, 0);
            orig.ShowState();  //shows state0

            Console.ReadKey();
        }
    }
}