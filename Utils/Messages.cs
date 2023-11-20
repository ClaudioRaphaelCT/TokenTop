namespace AppTop.Utils
{
    public class Messages
    {
        public static object MsgValidate(string error , string message)
        {
            var messages = new
            {
                Error = error,
                Message = message
            };
            return messages;
        }

    }
}
