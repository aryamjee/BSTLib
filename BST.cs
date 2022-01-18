using System;
using System.Collections.Generic;

namespace BSTTraversalLibrary
{
    public  class BST
    {
        private static Node _root;

        public void Create(List<int> valueList)
        {
            valueList.ForEach(data =>
            {
                Node node = new Node(data);
                if (_root == null)
                {
                    _root = node;
                }
                else
                {
                    Node current = _root;
                    do
                    {
                        if (data < current.Data)
                        {
                            if (current.Left == null)
                            {
                                current.Left = node;
                                break;
                            }
                            current = current.Left;
                        }
                        else
                        {
                            if (current.Right == null)
                            {
                                current.Right = node;
                                break;
                            }
                            current = current.Right;
                        }

                    } while (current != null);
                }
            });
        }

        public void Traverse<T>() where T : new()
        {
            T order = new T();
            List<Node> nodes = (List<Node>)typeof(T).GetMethod("GetTree").Invoke(order, new object[] { });
            Console.WriteLine("{0} Traversal : ", typeof(T).Name);
            nodes.ForEach(node => Console.WriteLine(node.Data));
        }

        internal static Node GetRoot()
        {
            return _root;
        }
    }
}
