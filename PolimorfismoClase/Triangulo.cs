using System;

namespace PolimorfismoClase 
{
    public class Triangulo : Figura
    {
        #region Propiedades
        public double Base { get; set; }
        public double Altura { get; set; }
        #endregion

        #region Constructor
        public Triangulo(double baseTriangulo, double altura)
        {
            Base = baseTriangulo;
            Altura = altura;
        }
        #endregion

        #region Metodos
        public override double CalcularArea()
        {
            return (Base * Altura) / 2;
        }
        #endregion

    }
}
