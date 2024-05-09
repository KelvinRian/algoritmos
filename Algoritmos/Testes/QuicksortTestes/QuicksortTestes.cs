using Algoritmos.Quicksort;

namespace Testes.QuicksortTestes
{
    public class QuicksortTestes
    {
        [Fact]
        public void QuickSortDeveRetornarCasoBase()
        {
            var lista = new List<int>();
            var resultado = Quicksort.QuickSort(lista);

            Assert.Equal(lista, resultado);
        }

        [Fact]
        public void QuickSortDeveOrdenarLista()
        {
            var lista = new List<int> { 3, 5, 1, 4, 2};
            var resultado = Quicksort.QuickSort(lista);

            Assert.Equal(1, resultado[0]);
            Assert.Equal(2, resultado[1]);
            Assert.Equal(3, resultado[2]);
            Assert.Equal(4, resultado[3]);
            Assert.Equal(5, resultado[4]);
        }
    }
}
