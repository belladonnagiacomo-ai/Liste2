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
        static void Main(string[] args)
        {
            List<int> lista1 = new List<int>() { 0, 5, 2, 8, 4, 10, 6, 7 };
            foreach(int i in EliminaI(lista1))
            {
                Console.WriteLine(i);
            }
        }
    }
}
