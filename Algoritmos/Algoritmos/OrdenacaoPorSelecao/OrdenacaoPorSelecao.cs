namespace Algoritmos.OrdenacaoPorSelecao
{
    public static class OrdenacaoPorSelecao
    {
        //Tempo de execução O(n²)
        public static int[] OrdenarPeloMenor(int[] array)
        {
            var novoArray = new int[array.Length];

            for (int i = 0; i < array.Count(); i++)
            {
                var menor = BuscaMenor(array);
                novoArray.Append(menor);
            }

            return novoArray;
        }

        private static int BuscaMenor(int[] array)
        {
            var menor = array[0];
            var menorIndice = 0;

            for(int i = 0; i < array.Count(); i++)
            {
                if (array[i] < menor)
                {
                    menor = array[i];
                    menorIndice = i;
                }
            }

            return menorIndice;
        }
    }
}
