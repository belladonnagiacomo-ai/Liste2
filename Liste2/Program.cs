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
        static void Spostamenti(List<int> numeri, int s)
        {
            int somma;
            for(int i = 0;  i < numeri.Count; i++)
            {
                somma = 0;
                somma = i + s;
                if(somma >= numeri.Count)
                {
                    somma = somma - numeri.Count;
                    numeri[i] = numeri[somma];
                }
                else
                {
                    numeri[i] = numeri[somma];
                }
                
            }
            foreach(int i in numeri)
            {
                Console.WriteLine(i);
            }
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
            Spostamenti(numeri, s);
        }
    }
}
