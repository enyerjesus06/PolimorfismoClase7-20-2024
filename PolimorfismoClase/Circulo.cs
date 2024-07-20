

namespace PolimorfismoClase
{
    public class Circulo : Figura
    {
        #region Propiedades
        public double Radio { get; set; }
        #endregion

        #region Constructor
        public Circulo(double radio)
        {
            Radio = radio;
        }
        #endregion

        #region Metodos
        public override double CalcularArea()
        {
            return Math.PI * Radio * Radio;
        }
        #endregion

    }
}
