using System;
namespace Lab3App
{
    internal abstract class Tool : Collectable
    {
        public virtual void doAction()
        {
            Console.WriteLine("Tool is used");
        }
    }
}
