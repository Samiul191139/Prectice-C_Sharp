using System;

namespace lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            PublicEx publicEx = new PublicEx();
            publicEx.ShowMessage();

            PrivateEx privateEx = new PrivateEx();
            privateEx.AccessPrivateMethod();

            ProtectedEx protectedEx = new ProtectedEx();
            protectedEx.ShowMessage();

            InternalEx internalEx = new InternalEx();
            internalEx.ShowMessage();

            ProtectedInternalEx protectedInternalEx = new ProtectedInternalEx();
            protectedInternalEx.ShowMessage();

            PrivateProtectedEx privateProtectedEx = new PrivateProtectedEx();
            privateProtectedEx.ShowMessage();
        }
    }
}