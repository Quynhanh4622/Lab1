using System;

namespace lab3.ex1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Atom atom = new Atom();
            while (true)
            {
                atom.Accept();
                Console.WriteLine("chon 1 de tiep tuc, 2 de ket thuc: ");
                int choice = Int32.Parse(Console.ReadLine());
                if (choice != 1)
                {
                    break;
                }
            }
            atom.Distplay();
        }
    }
}