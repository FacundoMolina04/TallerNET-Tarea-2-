#pragma warning disable CA1416
using System.Drawing;

namespace _01_02b_pipelinePattern.pipelinepattern.pipelineImpl
{
    internal class PasoCargarImagen : IPipellinePaso
    {
        public void cambiarColor(IContexto contexto)
        {
            string ruta= @"C:\Users\Facu\Desktop\IMAGENES\ORIGINAL.png"; //cambiar

            ((ImageContext)contexto).Image = new Bitmap(ruta);
        }
    }
}
