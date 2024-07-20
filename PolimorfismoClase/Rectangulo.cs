

namespace PolimorfismoClase
{
    public class Rectangulo : Figura
    {
        #region Propiedades
        public double Ancho { get; set; }
        public double Alto { get; set; }



        #endregion

        #region Constructor
        public Rectangulo(double ancho, double alto)
        {
            Ancho = ancho;
            Alto = alto;
        }
        #endregion

        #region Metodos
        public override double CalcularArea()
        {
            return Ancho * Alto;
        }
        #endregion




    }
}
