namespace Practice_1
{
    internal class NotAListMemberException : Exception
    {
        public NotAListMemberException(string message) : base(string.Format("Not a list member: {0}", message)) 
        { 

        }
    }
}
