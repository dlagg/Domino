namespace Domino.Logic
{
    public class Ficha
    {
        private int Id { get; set; }
        private Cara _caraR { get; set; }
        private Cara _caraL { get; set; }
        public Estado Estado { get; set; }
        public Jugador? Propietario { get; set; }
        public Ficha(int id, Cara caraR, Cara caraL, Estado estado)
        {
            Id = id;
            _caraR = caraR;
            _caraL = caraL;
            Estado = estado;
        }
    }

    public enum Estado
    {
        Fuera,
        enMano,
        enJuego
    }

    public class Cara
    {
        private int _valor { get; set; }

        //Solo pueden estar conectadas con caras del mismo valor.
        public Cara? Conexion { get; set; }
        public Cara(int valor)
        {
            _valor = valor;
        }
    }
}