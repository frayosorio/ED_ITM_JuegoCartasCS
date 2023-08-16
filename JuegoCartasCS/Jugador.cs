using System;
using System.Windows.Forms;

namespace JuegoCartasCS
{
    public class Jugador
    {

        private const int TOTAL_CARTAS = 10;
        private const int DISTANCIA = 40;
        private const int MARGEN = 5;

        private Carta[] cartas = new Carta[TOTAL_CARTAS];
        private Random r;

        public Jugador(int semilla)
        {
            r = new Random(semilla);
        }

        public void repartir()
        {
            for (int i = 0; i < TOTAL_CARTAS; i++)
            {
                cartas[i] = new Carta(r);
            }
        }

        public void mostrar(TabPage tpJugador)
        {
            tpJugador.Controls.Clear();
            for (int i = 0; i < cartas.Length; i++)
            {
                cartas[i].mostrar(tpJugador, MARGEN + TOTAL_CARTAS * DISTANCIA - i * DISTANCIA, MARGEN);
            }
        }

        public String getGrupos()
        {
            String mensaje = "No hay grupos";
            int[] contadores = new int[Enum.GetNames(typeof(NombreCarta)).Length];

            for (int i = 0; i < cartas.Length; i++)
            {
                contadores[(int)cartas[i].getNombre()]++;
            }

            int totalGrupos = 0;
            for (int i = 0; i < contadores.Length; i++)
            {
                if (contadores[i] >= 2)
                {
                    totalGrupos++;
                }
            }
            if (totalGrupos > 0)
            {
                mensaje = "Los grupos encontrados fueron:\n";
                for (int i = 0; i < contadores.Length; i++)
                {
                    if (contadores[i] >= 2)
                    {
                        mensaje += (Grupo)contadores[i] + " de " + (NombreCarta)i + "\n";
                    }
                }
            }

            return mensaje;
        }
    }
}
