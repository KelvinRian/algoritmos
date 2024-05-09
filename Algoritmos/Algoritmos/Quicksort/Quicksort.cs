using System.Linq;

namespace Algoritmos.Quicksort
{
    public static class Quicksort
    {
        public static IList<int> QuickSort(IList<int> list)
        {
            if (list == null)
            {
                return new List<int>();
            }
            else if (list.Count < 2)
            {
                return list;
            }
            else
            {
                var pivo = list[0];
                var menores = list.Where(x => x < pivo);
                var maiores = list.Where(x => x > pivo);

                var menoresOrdenados = QuickSort(menores.ToList());
                var maioresOrdenados = QuickSort(maiores.ToList());

                var novaLista = menoresOrdenados.Append(pivo);
                novaLista = novaLista.Concat(maioresOrdenados);

                return novaLista.ToList();
            }
        }
    }
}
