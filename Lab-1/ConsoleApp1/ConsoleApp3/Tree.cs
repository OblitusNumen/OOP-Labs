using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Tree<E>
    {
        private Node<E> _node;

        public Tree(Node<E> node)
        {
            _node = node;
        }

        public void print()
        {
            StringBuilder builder = new StringBuilder();
            _node.GetValues(builder);
            Console.WriteLine(builder.ToString());
        }
    }
}
