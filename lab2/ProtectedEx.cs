namespace lab2
{
    class BaseProtected
    {
        protected string message = "This is a protected variable";
    }

    class ProtectedEx : BaseProtected
    {
        public void ShowMessage()
        {
            Console.WriteLine(message);
        }
    }
}