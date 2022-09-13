namespace Domino.Logic
{
    public class Jugador
    {
        public int Id { get; private set; }
        public List<Ficha> Fichas { get; set; }

        public Jugador(int id)
        {
            Id = id;
        }
    }
}