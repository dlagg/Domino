namespace Domino.Logic
{
    public class Ficha
    {
        public Cara CaraR { get; set; }
        public Cara CaraL { get; set; }
        public Estado Estado { get; set; }
        public Jugador? Propietario { get; set; }
    }

    public enum Estado
    {
        Fuera,
        enMano,
        enJuego
    }

    public class Cara
    {
        public int Valor { get; set; }

        //Solo pueden estar conectadas con caras del mismo valor.
        public Cara? Conexion { get; set; }
    }
}