using static System.Console;

namespace CsharpColections.helper
{
    public class OprecacoesArray
    {
        public void OrdenarBubleSort(ref int[] array)
        {
            int temp = 0;
            foreach (var item in array)
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        temp = array[i + 1];
                        array[i + 1] = array[i];
                        array[i] = temp;
                    }
                }
            }
        }
        public void ImprimirArray(int[] array)
        {
            foreach (var item in array)
            {
                Write($"{item} ");
            }
            WriteLine();
        }

        public void Ordenar(ref int[] array)
        {
            Array.Sort(array);
        }
        public void CopiarArray(ref int[] arrayOriginal, ref int[] arrayCopia)
        {
            Array.Copy(arrayOriginal, arrayCopia, arrayOriginal.Length);
        }

        public bool VerificarExistencia(int[] array, int valor)
        {
            return Array.Exists(array, elemento => elemento == valor);
        }

        public bool TodosMaiorQue(int[] array, int valor){
            return Array.TrueForAll(array, elemento => elemento > valor);
        }
    }
}

