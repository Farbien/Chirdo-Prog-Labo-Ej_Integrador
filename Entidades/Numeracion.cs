using Entidades.Enums;

namespace Entidades
{
    public class Numeracion
    {
        private ESistema sistema;
        private double valorNumerico;

        public ESistema Sistema { get { return sistema; } }
        public string Valor { get { return valorNumerico.ToString(); } }

        public Numeracion(double valor, ESistema sistema)
        {
            this.InicializarValores(valor.ToString(), sistema);
        }

        public Numeracion(string valor, ESistema sistema)
        {
            this.InicializarValores(valor, sistema);
        }

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

        private double BinarioADecimal (string valor)
        {
            if (!EsBinario(valor))
                return 0;

            return double.Parse(Convert.ToInt32(this.valorNumerico.ToString(), 2).ToString());
        }

        private string DecimalABinario (int valor)
        {
            return Convert.ToString(valor, 2);
        }

        private string DecimalABinario (string valor)
        {
            bool exito = int.TryParse(valor, out int result) && result >= 0;
            return exito ? this.DecimalABinario(result) : "Numero invalido";
        }

        public static bool operator !=(ESistema sistema, Numeracion numeracion)
        {
            return sistema != numeracion.sistema;
        }

        public static bool operator ==(ESistema sistema, Numeracion numeracion)
        {
            return sistema == numeracion.sistema;
        }

        public static Numeracion operator +(Numeracion n1, Numeracion n2)
        {
            return new Numeracion(n1.valorNumerico + n2.valorNumerico, ESistema.Decimal);
        }

        public static Numeracion operator -(Numeracion n1, Numeracion n2)
        {
            return new Numeracion(n1.valorNumerico - n2.valorNumerico, ESistema.Decimal);
        }

        public static Numeracion operator *(Numeracion n1, Numeracion n2)
        {
            return new Numeracion(n1.valorNumerico * n2.valorNumerico, ESistema.Decimal);
        }

        public static Numeracion operator /(Numeracion n1, Numeracion n2)
        {
            return new Numeracion(n1.valorNumerico / n2.valorNumerico, ESistema.Decimal);
        }

        public static bool operator !=(Numeracion n1, Numeracion n2)
        {
            return n1.sistema != n2.sistema;
        }

        public static bool operator ==(Numeracion n1, Numeracion n2)
        {
            return n1.sistema == n2.sistema;
        }
    }
}