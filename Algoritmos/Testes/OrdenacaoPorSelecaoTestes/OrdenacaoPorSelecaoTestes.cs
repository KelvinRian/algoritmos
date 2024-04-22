using Algoritmos.OrdenacaoPorSelecao;

namespace Testes.OrdenacaoPorSelecaoTestes
{
    public class OrdenacaoPorSelecaoTestes
    {
        [Fact]
        public void deve_ordenar_array_do_menor_pro_maior_numero()
        {
            var array = new int[] { 5, 4, 6, 1, 2, 10, 7, 9, 3, 8 };
            
            var resultado = OrdenacaoPorSelecao.OrdenarPeloMenor(array);

            resultado.ElementAt(0).Equals(1);
            resultado.ElementAt(1).Equals(2);
            resultado.ElementAt(2).Equals(3);
            resultado.ElementAt(3).Equals(4);
            resultado.ElementAt(4).Equals(5);
            resultado.ElementAt(5).Equals(6);
            resultado.ElementAt(6).Equals(7);
            resultado.ElementAt(7).Equals(8);
            resultado.ElementAt(8).Equals(9);
            resultado.ElementAt(0).Equals(10);
        }
    }
}
