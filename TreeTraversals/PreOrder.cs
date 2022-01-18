using System.Collections.Generic;

namespace BSTTraversalLibrary.TreeTraversals
{
    public class PreOrder
    {
        private List<Node> _preOrderNodeList = new List<Node>();

        public List<Node> GetTree()
        {
            PreOrderTraversal(BST.GetRoot());
            return _preOrderNodeList;
        }

        private void PreOrderTraversal(Node node)
        {
            if(node != null)
            {
                // process current node
                _preOrderNodeList.Add(node);

                // visit left child
                PreOrderTraversal(node.Left);

                // visit right child
                PreOrderTraversal(node.Right);
            }
        }
    }
}
