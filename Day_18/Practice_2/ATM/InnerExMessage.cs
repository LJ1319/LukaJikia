namespace ATM
{
    internal class InnerExMessage
    {
        public InnerExMessage()
        {
        }

        public static string GetLastInnerExMessage(Exception ex)
        {
            string message = "";

            if (ex != null)
            {
                if (ex.InnerException == null)
                {
                    message = ex.Message;
                    return message;
                }
                else
                {
                    return GetLastInnerExMessage(ex.InnerException);
                }

            }

            return message;
        }

        public static string GetAllInnerExMessageTogether(Exception ex)
        {
            string message = "";

            if (ex != null)
            {
                if (ex.InnerException == null)
                {
                    message += ex.Message;
                    return message;
                }
                else
                {
                    return GetAllInnerExMessageTogether(ex.InnerException);
                }
            }

            return message;
        }
    }
}
