using System.Runtime.CompilerServices;

namespace Domino.Logic
{
    public class Dominoo
    {
        private int _numJugadores { get; set; }
        public int? turnoIdJugador { get; set; }
        public List<Ficha> _fichas { get; private set; }
        public List<Jugador> _jugadores { get; private set; }

        public Dominoo(int numJugadores)
        {
            //Crear partida
            _numJugadores = ValidarJugadores(numJugadores);
            _fichas = CrearFichas();
            _jugadores = GenerarJugadoresYRepartirFichas(_numJugadores, _fichas);
            turnoIdJugador = _jugadores.FirstOrDefault().Id;
        }

        private int ValidarJugadores(int numJugadores)
        {
            if (numJugadores < 2 || numJugadores > 4)
            {
                throw new Exception("el numero de jugadores debe ser entre 2 y 4");
            }
            return numJugadores;
        }
        private List<Ficha> CrearFichas()
        {
            var fichas = new List<Ficha>();
            int idCounter = 0;
            for (int i = 0; i <= 6; i++)
            {
                for (int j = i; j <= 6; j++)
                {
                    var caraR = new Cara(i);
                    var caraL = new Cara(j);
                    fichas.Add(new Ficha(idCounter++, caraR, caraL, Estado.Fuera));
                }
            }

            if (fichas.Any())
            {
                return fichas;
            }
            throw new Exception("Error generando fichas.");
        }
        private List<Jugador> GenerarJugadoresYRepartirFichas(int numJugadores, List<Ficha> fichas)
        {
            if (!fichas.Any())
            {
                throw new Exception("No hay fichas para repartir entre los jugadores.");
            }
            List<Jugador> jugadores = new List<Jugador>();

            for (int i = 1; i <= numJugadores; i++)
            {
                var jugador = new Jugador(i);
                jugadores.Add(CogerFichas(jugador, fichas));
            }

            if (!jugadores.Any())
            {
                throw new Exception("Error generando jugadores.");
            }
                return jugadores;
        }

        private Jugador CogerFichas(Jugador jugador ,List<Ficha> todasFichas)
        {
            Random r = new();
            const int nFichasARobarAlInicio = 5;

            var fichasDisponiblesAleatorias = todasFichas.FindAll(f => f.Propietario == null).OrderBy(f => r.Next());
            var fichasParaJugador = fichasDisponiblesAleatorias.Take(nFichasARobarAlInicio).ToList();
            foreach (Ficha f in fichasParaJugador)
            {
                f.Estado = Estado.enMano;
                f.Propietario = jugador;
            }
            jugador.Fichas = fichasParaJugador;
            return jugador;
        }
    }
}