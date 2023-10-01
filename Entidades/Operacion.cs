using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Representa una operación matemática entre dos valores numéricos.
    /// </summary>
    public class Operacion
    {
        private Numeracion primerOperando;
        private Numeracion segundoOperando;

        /// <summary>
        /// Obtiene o establece el primer operando de la operación.
        /// </summary>
        public Numeracion PrimerOperando { get { return primerOperando; } set { primerOperando = value; } }
        /// <summary>
        /// Obtiene o establece el segundo operando de la operación.
        /// </summary>
        public Numeracion SegundoOperando { get { return segundoOperando; } set {  segundoOperando = value; } }


        /// <summary>
        /// Inicializa una nueva instancia de la clase Operacion con dos operandos.
        /// </summary>
        /// <param name="primerOperando">El primer operando de la operación.</param>
        /// <param name="segundoOperando">El segundo operando de la operación.</param>
        public Operacion (Numeracion primerOperando, Numeracion segundoOperando) 
        {
            this.primerOperando = primerOperando;
            this.segundoOperando = segundoOperando;
        }

        /// <summary>
        /// Realiza la operación matemática especificada y devuelve el resultado como una instancia de Numeracion.
        /// </summary>
        /// <param name="operador">El operador matemático ('+', '-', '*', '/').</param>
        /// <returns>Una instancia de Numeracion que representa el resultado de la operación.</returns>
        public Numeracion Operar (char operador)
        {
            switch (operador)
            {
                case '-':
                    return primerOperando - segundoOperando;
                case '*':
                    return primerOperando * segundoOperando;
                case '/':
                    return primerOperando / segundoOperando;
                default:
                    return primerOperando + segundoOperando;
            }
        }
    }
}
