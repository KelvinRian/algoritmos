using Algoritmos.PesquisaBinaria;

namespace Testes.PesquisaBinariaTestes
{
    public class PesquisaBinariaTestes
    {
        [Fact]
        public void Deve_retornar_item_existente()
        {
            var lista = new List<int>() { 1, 3, 5, 7, 9 };
            var item = 3;

            var resultado = PesquisaBinaria.Pesquisar(lista, item);
            Assert.Equal(item, resultado);
        }
    }
}
