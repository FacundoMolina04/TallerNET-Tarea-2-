#pragma warning disable CA1416
using System.Drawing;

namespace _01_02b_pipelinePattern.pipelinepattern.pipelineImpl
{
    internal class ImageContext : IContexto
    {
        public Bitmap Image { get; set; }

        public ImageContext()
        {
            Image = new Bitmap(1, 1); //inicializar elbitmap 
        }
    }
}
