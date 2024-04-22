namespace Algoritmos.PesquisaBinaria
{
    public static class PesquisaBinaria
    {
        //Tempo de execução O(log n)
        public static int? Pesquisar(IList<int> lista, int item)
        {
            var baixo = 0;
            var alto = lista.Count;

            while (baixo <= alto)
            {
                var meio = (baixo + alto) / 2;
                var chute = lista[meio];

                if (chute == item)
                    return meio;

                if (chute > item)
                    alto = meio - 1;

                else
                    baixo = meio + 1;
            }

            return null;
        }
    }
}
