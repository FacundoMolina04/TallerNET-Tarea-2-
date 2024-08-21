#pragma warning disable CA1416
using System.Drawing;

namespace _01_02b_pipelinePattern.pipelinepattern.pipelineImpl
{
    internal class PasoAplicarFiltroColor : IPipellinePaso
    {
        private Color _colorAcambiar;
        private Color _colorRemplazo;

        public PasoAplicarFiltroColor(Color colorAcambiar, Color colorRemplazo)
        {
            _colorAcambiar= colorAcambiar;
            _colorRemplazo = colorRemplazo;
        }

        public void cambiarColor(IContexto contexto)
        {
            Bitmap image= ((ImageContext)contexto).Image;
            for (int y = 0; y < image.Height; y++)
            {
               for (int x = 0; x < image.Width; x++)
                {
                    Color coordenadasImagen = image.GetPixel(x, y);
                    if (coordenadasImagen.ToArgb()== _colorAcambiar.ToArgb())
                    {
                        image.SetPixel(x, y, _colorRemplazo);
                    }
                }
            }
        }
    }
}
