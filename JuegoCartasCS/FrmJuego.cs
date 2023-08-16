using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuegoCartasCS
{
    public partial class FrmJuego : Form
    {
        Jugador jugador1;
        Jugador jugador2;

        public FrmJuego()
        {
            InitializeComponent();
            jugador1 = new Jugador(DateTime.Now.Millisecond * 5);
            jugador2 = new Jugador(DateTime.Now.Millisecond * 9);
        }

        private void btnRepartir_Click(object sender, EventArgs e)
        {
            jugador1.repartir();
            jugador2.repartir();

            jugador1.mostrar(tpJugador1);
            jugador2.mostrar(tpJugador2);
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            int pestaña = tcJugadores.SelectedIndex;
            String mensaje = "";
            switch (pestaña)
            {
                case 0:
                    mensaje = jugador1.getGrupos();
                    break;
                case 1:
                    mensaje = jugador2.getGrupos();
                    break;
            }
            MessageBox.Show(mensaje);
        }
    }
}
