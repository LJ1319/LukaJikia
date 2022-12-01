namespace Practice_1
{
    internal class LinkedItem
    {
        List<Node> nodes = new List<Node>();

        public Node this[int n]
        {
            get { return nodes[n]; }
            set { nodes.Add(value); }
        }
    }
}
