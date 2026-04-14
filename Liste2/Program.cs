namespace Liste2
{
    internal class Program
    {
        static List<int> EliminaI(List<int> lista1)
        {
            for(int i = lista1.Count - 1; i >= 0; i--)
            {
                if (lista1[i] == i)
                {
                    lista1.RemoveAt(i);
                }
            }
            return lista1;
        }
        static List<int> Spostamenti(List<int> numeri, int s)
        {
            int n = 0;
            for (int i = 0;  i < s; i++)
            {
                n = numeri[numeri.Count - 1];
                numeri.RemoveAt(numeri.Count-1);
                numeri.Insert(0, n);
                n = 0;
            }
            return numeri;
            
        }
        static void Main(string[] args)
        {
            List<int> lista1 = new List<int>() { 0, 5, 2, 8, 4, 10, 6, 7 };
            foreach(int i in EliminaI(lista1))
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            List<int> numeri = new List<int>() { 1, 2, 3, 4, 5 };
            Console.WriteLine("Dammi il numero di spostamenti");
            int s = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            foreach(int i in Spostamenti(numeri, s))
            {
                Console.Write("[" + i + "]");

            }

            List<int> Ripetuti = new List<int>() { 4, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9 };
        }
    }
}
