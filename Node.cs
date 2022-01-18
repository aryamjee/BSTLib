namespace BSTTraversalLibrary
{
    public class Node
    {
        public int Data { get; internal set; }
        public Node Left { get; internal set; }
        public Node Right { get; internal set; }
        internal Node(int value)
        {
            Data = value;
        }
    }
}
