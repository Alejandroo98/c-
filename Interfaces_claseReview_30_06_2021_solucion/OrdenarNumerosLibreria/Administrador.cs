using EntidadesBiblioteca;

namespace OrdenarNumerosLibreria
{
    public class Administrador
    {


        public int[] ordenarNumeros(int[] numDesordenados)
        {

            for (int i = 0; i < numDesordenados.Length - 1; i++)
            {
                int posicionMenor = obtenerPosicionMenor(numDesordenados, i);
                var intercambio = numDesordenados[i];
                numDesordenados[i] = numDesordenados[posicionMenor];
                numDesordenados[posicionMenor] = intercambio;
            }

            return numDesordenados;
        }


        public Estudiante[] ordenerPorNota(Estudiante[] notasDesordenadas)
        {
            for (int i = 0; i < notasDesordenadas.Length - 1; i++)
            {
                int posicionMenor = obtenerPosicionMenor(notasDesordenadas, i);
                var intercambio = notasDesordenadas[i];
                notasDesordenadas[i] = notasDesordenadas[posicionMenor];
                notasDesordenadas[posicionMenor] = intercambio;
            }

            return notasDesordenadas;

        }

        private int obtenerPosicionMenor(Estudiante[] notasDesordenadas, int posicionInicio)
        {
            int posicionMenor = posicionInicio;

            for (int posicionActual = posicionInicio; posicionActual < notasDesordenadas.Length; posicionActual++)
            {
                if (notasDesordenadas[posicionActual].Nota < notasDesordenadas[posicionMenor].Nota)
                {
                    posicionMenor = posicionActual;
                }
            }

            return posicionMenor;

        }

        private int obtenerPosicionMenor(int[] numDesordenados, int posicionInicio)
        {
            int posicionMenor = posicionInicio;

            for (int posicionActual = posicionInicio; posicionActual < numDesordenados.Length; posicionActual++)
            {
                if (numDesordenados[posicionActual] < numDesordenados[posicionMenor])
                {
                    posicionMenor = posicionActual;
                }
            }

            return posicionMenor;
        }




    }

}

