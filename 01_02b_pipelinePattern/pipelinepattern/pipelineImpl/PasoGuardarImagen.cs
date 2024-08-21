#pragma warning disable CA1416
using System.Drawing;

namespace _01_02b_pipelinePattern.pipelinepattern.pipelineImpl
{
    internal class PasoGuardarImagen : IPipellinePaso
    {
        public void cambiarColor(IContexto contexto)
        {
            string rutaResultado = @"C:\Users\Facu\Desktop\IMAGENES\imagen_resultado.png"; //cambiar ruta

        ((ImageContext)contexto).Image.Save(rutaResultado);
            Console.WriteLine("Imagen guardada en archivo");
        }
    }
}
