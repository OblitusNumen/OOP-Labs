using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Node<E>
    {
        public E value { get; set; }
        private readonly List<Node<E>> children = new List<Node<E>>();

        public Node(E value)
        {
            this.value = value;
        }

        public void addChild(Node<E> child)
        {
            children.Add(child);
        }

        public void GetValues(StringBuilder builder)
        {
            builder.Append("{").Append(value);
            if (children.Count != 0)
            {
                builder.Append(", [");
                children.ElementAt(0).GetValues(builder);
                for (int i = 1; i < children.Count; i++)
                {
                    builder.Append("; ");
                    children.ElementAt(i).GetValues(builder);
                }
                builder.Append("]");
            }
            builder.Append("}");
        }
    }
}
