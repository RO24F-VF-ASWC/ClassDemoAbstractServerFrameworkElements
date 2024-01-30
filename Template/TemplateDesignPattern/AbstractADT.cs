using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template.TemplateDesignPattern
{
    public abstract class AbstractADT
    {
        private ICollection<String> _myCollection;

        public AbstractADT()
        {
            _myCollection = CreateCollection(); // use the abstract method
        }

        //
        // Template method - to be overrided and will differ from subclass to subclass
        //
        protected abstract ICollection<string> CreateCollection();


        //
        // all the common methods
        //
        public void Add(string item)
        {
            _myCollection.Add(item);
        }

        public void Clear()
        {
            _myCollection.Clear();
        }

        public bool Remove(string item)
        {
            return _myCollection.Remove(item);
        }

        public int Count => _myCollection.Count;

        public override string ToString()
        {
            string str = "[" + String.Join(" , ", _myCollection) + "]";
            return $"The Collection: {str}";
        }
    }
}
