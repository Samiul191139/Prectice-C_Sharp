namespace lab2
{
    class PrivateEx
    {
        private string message = "This is a private variable";

        private void ShowMessage()
        {
            Console.WriteLine(message);
        }

        public void AccessPrivateMethod()
        {
            ShowMessage();
        }
    }
}