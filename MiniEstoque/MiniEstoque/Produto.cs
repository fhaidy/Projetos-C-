using System;
using System.Globalization;

namespace MiniEstoque {
    class Produto {

        public string Nome;
        public double Preco;
        public int Quantidade;

        public double CalculaValorTotalEstoque() {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade) {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade) {
            if(Quantidade >= quantidade) {
                Quantidade -= quantidade;
            } else {
                Console.WriteLine("Não é possível remover mais produtos do que a quantidade total ({0}). :(", Quantidade);
            }     
        }

        public override string ToString() {
            return Nome + ", $ " + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", " + Quantidade + " unidades, Total: $" + CalculaValorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
