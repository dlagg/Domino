namespace Domino.Logic
{
    public class Dominoo
    {
        private int _numJugadores;
        private IEnumerable<Ficha>? Fichas;

        public Dominoo(int numJugadores)
        {
            //Crear partida
            _numJugadores = ValidarJugadores(numJugadores);
        }

        private int ValidarJugadores(int numJugadores)
        {
            if (numJugadores < 2 || numJugadores > 4)
            {
                throw new Exception("el numero de jugadores debe ser entre 2 y 4");
            }
            return numJugadores;
        }
    }
}