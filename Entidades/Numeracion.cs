using Entidades.Enums;

namespace Entidades
{
    /// <summary>
    /// Representa un valor numérico en un sistema numérico específico.
    /// </summary>
    public class Numeracion
    {
        private ESistema sistema;
        private double valorNumerico;

        /// <summary>
        /// Obtiene el sistema numérico en el que está representado el valor.
        /// </summary>     
        public ESistema Sistema { get { return sistema; } }

        /// <summary>
        /// Obtiene el valor numérico expresado como cadena.
        /// </summary>
        public string Valor { get { return valorNumerico.ToString(); } }

        /// <summary>
        /// Inicializa una nueva instancia de la clase Numeracion con un valor y sistema numérico específicos.
        /// </summary>
        /// <param name="valor">El valor numérico.</param>
        /// <param name="sistema">El sistema numérico en el que se representa el valor.</param>
        public Numeracion(double valor, ESistema sistema)
        {
            this.InicializarValores(valor.ToString(), sistema);
        }

        /// <summary>
        /// Inicializa una nueva instancia de la clase Numeracion con un valor en cadena y sistema numérico específicos.
        /// </summary>
        /// <param name="valor">El valor numérico en cadena.</param>
        /// <param name="sistema">El sistema numérico en el que se representa el valor.</param>
        public Numeracion(string valor, ESistema sistema)
        {
            this.InicializarValores(valor, sistema);
        }


        /// <summary>
        /// Inicializa los valores de una instancia de Numeracion con un valor en cadena y sistema numérico específicos.
        /// </summary>
        /// <param name="valor">El valor numérico en cadena.</param>
        /// <param name="sistema">El sistema numérico en el que se representa el valor.</param>
        private void InicializarValores(string valor, ESistema sistema)
        {
            this.sistema = sistema;

            if (sistema == ESistema.Binario)
            {
                this.valorNumerico = BinarioADecimal(valor);
                return;
            }

            if (double.TryParse(valor, out double auxValor))
            {
                this.valorNumerico = auxValor;
                return;
            }
            
            this.valorNumerico = double.MinValue;
        }

        // <summary>
        /// Convierte el valor numérico a un sistema numérico específico y devuelve su representación en cadena.
        /// </summary>
        /// <param name="sistema">El sistema numérico al que se debe convertir el valor.</param>
        /// <returns>Una cadena que representa el valor numérico en el sistema especificado.</returns>
        public string ConvertirA(ESistema sistema)
        {
            switch (sistema)
            {
                case ESistema.Binario:
                    return DecimalABinario(this.valorNumerico.ToString());
                case ESistema.Decimal:
                    return BinarioADecimal(this.valorNumerico.ToString()).ToString();
                default:
                    return this.Valor;
            }
        }

        /// <summary>
        /// Determina si una cadena representa un número en sistema binario.
        /// </summary>
        /// <param name="valor">La cadena que se debe verificar.</param>
        /// <returns>True si la cadena es una representación válida en sistema binario; de lo contrario, false.</returns>
        private static bool EsBinario (string valor)
        {
            foreach(char c in valor)
            {
                if (c == '1' || c == '0')
                    continue;
                else
                    return false;
            }

            return true;
        }

        /// <summary>
        /// Convierte una cadena que representa un número en sistema binario a su equivalente en sistema decimal.
        /// </summary>
        /// <param name="valor">La cadena en sistema binario que se debe convertir.</param>
        /// <returns>El valor en sistema decimal resultante de la conversión.</returns>
        private double BinarioADecimal (string valor)
        {
            if (!EsBinario(valor))
                return 0;

            return double.Parse(Convert.ToInt32(this.valorNumerico.ToString(), 2).ToString());
        }

        /// <summary>
        /// Convierte un valor entero en sistema decimal a su representación en sistema binario.
        /// </summary>
        /// <param name="valor">El valor en sistema decimal que se debe convertir.</param>
        /// <returns>Una cadena que representa el valor en sistema binario.</returns>
        private string DecimalABinario (int valor)
        {
            return Convert.ToString(valor, 2);
        }

        /// <summary>
        /// Convierte una cadena que representa un número en sistema decimal a su representación en sistema binario.
        /// </summary>
        /// <param name="valor">La cadena en sistema decimal que se debe convertir.</param>
        /// <returns>
        /// Una cadena que representa el valor en sistema binario si la conversión es exitosa;
        /// de lo contrario, retorna "Numero invalido".
        /// </returns>
        private string DecimalABinario (string valor)
        {
            bool exito = int.TryParse(valor, out int result) && result >= 0;
            return exito ? this.DecimalABinario(result) : "Numero invalido";
        }

        /// <summary>
        /// Compara si un sistema numérico y una instancia de Numeracion son diferentes.
        /// </summary>
        /// <param name="sistema">El sistema numérico a comparar.</param>
        /// <param name="numeracion">La instancia de Numeracion a comparar.</param>
        /// <returns>True si el sistema numérico y la instancia de Numeracion son diferentes; de lo contrario, false.</returns>
        public static bool operator !=(ESistema sistema, Numeracion numeracion)
        {
            return sistema != numeracion.sistema;
        }

        /// <summary>
        /// Compara si un sistema numérico y una instancia de Numeracion son iguales.
        /// </summary>
        /// <param name="sistema">El sistema numérico a comparar.</param>
        /// <param name="numeracion">La instancia de Numeracion a comparar.</param>
        /// <returns>True si el sistema numérico y la instancia de Numeracion son iguales; de lo contrario, false.</returns>
        public static bool operator ==(ESistema sistema, Numeracion numeracion)
        {
            return sistema == numeracion.sistema;
        }

        /// <summary>
        /// Realiza la suma de dos instancias de Numeracion y devuelve el resultado.
        /// </summary>
        /// <param name="n1">La primera instancia de Numeracion.</param>
        /// <param name="n2">La segunda instancia de Numeracion.</param>
        /// <returns>Una nueva instancia de Numeracion que representa la suma de las dos instancias proporcionadas.</returns>
        public static Numeracion operator +(Numeracion n1, Numeracion n2)
        {
            return new Numeracion(n1.valorNumerico + n2.valorNumerico, ESistema.Decimal);
        }

        /// <summary>
        /// Realiza la resta de dos instancias de Numeracion y devuelve el resultado.
        /// </summary>
        /// <param name="n1">La primera instancia de Numeracion.</param>
        /// <param name="n2">La segunda instancia de Numeracion.</param>
        /// <returns>Una nueva instancia de Numeracion que representa la resta de las dos instancias proporcionadas.</returns>
        public static Numeracion operator -(Numeracion n1, Numeracion n2)
        {
            return new Numeracion(n1.valorNumerico - n2.valorNumerico, ESistema.Decimal);
        }

        /// <summary>
        /// Realiza la multiplicación de dos instancias de Numeracion y devuelve el resultado.
        /// </summary>
        /// <param name="n1">La primera instancia de Numeracion.</param>
        /// <param name="n2">La segunda instancia de Numeracion.</param>
        /// <returns>Una nueva instancia de Numeracion que representa la multiplicación de las dos instancias proporcionadas.</returns>
        public static Numeracion operator *(Numeracion n1, Numeracion n2)
        {
            return new Numeracion(n1.valorNumerico * n2.valorNumerico, ESistema.Decimal);
        }

        /// <summary>
        /// Realiza la división de dos instancias de Numeracion y devuelve el resultado.
        /// </summary>
        /// <param name="n1">La primera instancia de Numeracion.</param>
        /// <param name="n2">La segunda instancia de Numeracion.</param>
        /// <returns>Una nueva instancia de Numeracion que representa la división de las dos instancias proporcionadas.</returns>
        public static Numeracion operator /(Numeracion n1, Numeracion n2)
        {
            return new Numeracion(n1.valorNumerico / n2.valorNumerico, ESistema.Decimal);
        }

        /// <summary>
        /// Compara si dos instancias de Numeracion son diferentes en cuanto al sistema numérico.
        /// </summary>
        /// <param name="n1">La primera instancia de Numeracion.</param>
        /// <param name="n2">La segunda instancia de Numeracion.</param>
        /// <returns>True si las dos instancias de Numeracion tienen sistemas numéricos diferentes; de lo contrario, false.</returns>
        public static bool operator !=(Numeracion n1, Numeracion n2)
        {
            return n1.sistema != n2.sistema;
        }

        /// <summary>
        /// Compara si dos instancias de Numeracion son iguales en cuanto al sistema numérico.
        /// </summary>
        /// <param name="n1">La primera instancia de Numeracion.</param>
        /// <param name="n2">La segunda instancia de Numeracion.</param>
        /// <returns>True si las dos instancias de Numeracion tienen el mismo sistema numérico; de lo contrario, false.</returns>
        public static bool operator ==(Numeracion n1, Numeracion n2)
        {
            return n1.sistema == n2.sistema;
        }
    }
}