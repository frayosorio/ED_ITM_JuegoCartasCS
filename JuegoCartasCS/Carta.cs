using System;
using System.Drawing;
using System.Windows.Forms;

namespace JuegoCartasCS
{
    public class Carta
    {

        private int indice;

        //metodo constructor
        public Carta(Random r)
        {
            //generar el indice de la carta de manera aleatoria
            indice = r.Next(1,52);
        }

        public Pinta getPinta()
        {
            //devolver la pinta que corresponde al indice de la carta
            if (indice <= 13)
            {
                return Pinta.TREBOL;
            }
            else if (indice <= 26)
            {
                return Pinta.PICA;
            }
            else if (indice <= 39)
            {
                return Pinta.CORAZON;
            }
            else
            {
                return Pinta.DIAMANTE;
            }
        }

        public NombreCarta getNombre()
        {
            int numero = indice % 13;
            if (numero == 0)
            {
                numero = 13;
            }
            return (NombreCarta)(numero - 1);
        }

        public void mostrar(TabPage tpJugador, int x, int y)
        {

            //obtener el nombre del archivo de la carta
            String nombreImagen = "CARTA" + indice.ToString();

            //cargar la imagen
            Image imagen =(Image)JuegoCartasCS.Properties.Resources.ResourceManager.GetObject(nombreImagen);

            //Instanciar el objeto PICTUREBOX que mostrará la carta
            PictureBox pb = new PictureBox();
            pb.Image = imagen;

            //definir las coordenadas y dimesnion de la imagen
            pb.Bounds=new Rectangle(x, y, imagen.Width, imagen.Height);

            //mostrar la carta en el objeto PANEL de despliegue
            tpJugador.Controls.Add(pb);

        }


    }
}
