namespace lab2
{
    class BaseProtectedInternal
    {
        protected internal string message = "This is a protected internal variable";
    }

    class ProtectedInternalEx : BaseProtectedInternal
    {
        public void ShowMessage()
        {
            Console.WriteLine(message);
        }
    }
}