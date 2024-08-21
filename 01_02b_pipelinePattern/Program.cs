// See https://aka.ms/new-console-template for more information
using _01_02b_pipelinePattern.pipelinepattern;
using _01_02b_pipelinePattern.pipelinepattern.pipelineImpl;
using System.Drawing;

Console.WriteLine("Tarea 2 \n Sólo cambia colores fijos, por ejemplo BLANCO a ROJO.(puede ser que no encuentre el color exacto en otras imágenes)");

IContexto contexto = new ImageContext();
PipelineOrquestador pipeLine = new PipelineOrquestador(contexto);

pipeLine.AgregarPaso(new PasoCargarImagen());
pipeLine.AgregarPaso(new PasoAplicarFiltroColor(Color.White, Color.Red)); 
pipeLine.AgregarPaso(new PasoGuardarImagen());

pipeLine.Ejecutar();





