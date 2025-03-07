namespace lab2
{
    class BasePrivateProtected
    {
        private protected string message = "This is a private protected variable";
    }

    class PrivateProtectedEx : BasePrivateProtected
    {
        public void ShowMessage()
        {
            Console.WriteLine(message);
        }
    }
}