using System;

namespace VeiculoList
{
    public class Veiculo
    {
        public string Placa { get; set; }

        public void List()
        {
            Console.WriteLine(Placa);
            Console.WriteLine("\n");
        }
    }
}
