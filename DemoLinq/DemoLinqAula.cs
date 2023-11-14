namespace DemoLinq
{
    class DemoLinq
    {
        static void Main(string[] args)
        {
            List<string> cidades = new List<string>();
            cidades.Add("São Paulo");
            cidades.Add("São Jośe");
            cidades.Add("Joinville");
            cidades.Add("Floripa");
            cidades.Add("Blumenau");

            BuscarPrimeiroComLinqLambda(cidades, "Sã").ForEach(x => Console.WriteLine(x));
            Console.ReadKey();
        }

        public static string BuscarPrimeiroComForeach(List<string> lista, string termo)
        {
            foreach (string item in lista)
            {
                if (item.Equals(termo))
                {
                    return item;
                }

            }
            return null;
        }


        public static List<string> BuscarPrimeiroComLinq(List<string> lista, string termo)
        {
            return (from item in lista where item.Contains(termo) select item).ToList();
        }

        public static List<string> BuscarPrimeiroComLinqLambda(List<string> lista, string termo)
        {
            return lista.Where(x => x.Contains(termo)).ToList();
        }
    }
}