using System;
using System.Collections.Generic;
namespace Lab3App
{
    internal abstract class Collectable : Displayable
    {
        public CollectionBoard Board;

        public String _name;

        public abstract void Display();
        

        public abstract void AddMe(List<Collectable> list);
    }
}
