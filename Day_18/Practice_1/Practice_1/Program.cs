namespace Practice_1
{
    internal class Program
    {
        public static void Main()
        {
            Node nodeA = new Node();
            nodeA.Data = 13;

            Node nodeB = new Node();
            nodeB.Data = 17;

            Node nodeC = new Node();
            nodeC.Data = 19;

            nodeA.Next = nodeB;
            nodeB.Next = nodeC;

            LinkedItem linkedItems = new LinkedItem();
            linkedItems[0] = nodeA;
            linkedItems[1] = nodeB;
            linkedItems[2] = nodeC;

            Node newNode = new Node()
            {
                Data = 15,
            };

            Console.Write("Enter an index: ");
            int reqIndex = Convert.ToInt32(Console.ReadLine()); 

            try
            {
                if (linkedItems[reqIndex] != newNode)
                {
                    throw new NotAListMemberException($"Requested element at given n-th place (index: {reqIndex}) was not found in the list!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}