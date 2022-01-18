using System.Collections.Generic;

namespace BSTTraversalLibrary.TreeTraversals
{
    public class InOrder
    {
        private List<Node> _inOrderNodeList = new List<Node>();
        
        public List<Node> GetTree()
        {
            InOrderTraversal(BST.GetRoot());
            return _inOrderNodeList;
        }

        private void InOrderTraversal(Node node)
        {
            if (node != null)
            {
                // visit left child
                InOrderTraversal(node.Left);

                // process current node
                _inOrderNodeList.Add(node);

                // process right child
                InOrderTraversal(node.Right);
            }
        }
    }
}