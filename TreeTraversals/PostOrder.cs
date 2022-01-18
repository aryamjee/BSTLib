using System.Collections.Generic;

namespace BSTTraversalLibrary.TreeTraversals
{
    public class PostOrder
    {
        private List<Node> _postOrderNodeList = new List<Node>();

        public List<Node> GetTree()
        {
            PostOrderTraversal(BST.GetRoot());
            return _postOrderNodeList;
        }

        private void PostOrderTraversal(Node node)
        {
            if (node != null)
            {
                // visit left child
                PostOrderTraversal(node.Left);

                // visit right child
                PostOrderTraversal(node.Right);

                // process current node
                _postOrderNodeList.Add(node);
            }
        }
    }
}
