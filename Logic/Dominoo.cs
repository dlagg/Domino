namespace Domino.Logic
{
    public class Dominoo
    {
        private int _numJugadores;
        private List<Ficha>? _fichas;

        public Dominoo(int numJugadores)
        {
            //Crear partida
            _numJugadores = ValidarJugadores(numJugadores);
            _fichas = RepartirFichas(_numJugadores);
        }

        private List<Ficha>? RepartirFichas(int numJugadores)
        {
            throw new NotImplementedException();
            List<Ficha> todasFichas = GenerarFichas();    
            return todasFichas;
        }

        private List<Ficha> GenerarFichas()
        {
            var fichas = new List<Ficha>();
            for (int i = 0; i < 6; i++)
            {
                for (int j = i; j < 6; j++)
                {
                    var caraR = new Cara()
                    fichas.Add(new Ficha());
                }
            }
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