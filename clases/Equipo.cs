namespace JUGADORES.clases;

public class Equipo : IEquipo
{
    private List<Jugador> jugadores;

    public Equipo()
    {
        jugadores = new List<Jugador>();
    }

    // Método para agregar un jugador al equipo
    public void AgregarJugador(Jugador jugador)
    {
        if (jugadores.Count < 3)
        {
            jugadores.Add(jugador);
        }
        else
        {
            Console.WriteLine("El equipo ya tiene 3 jugadores.");
        }
    }

    public void MostrarJugadores()
    {
        foreach (Jugador jugador in jugadores)
        {
            Console.WriteLine($"{jugador.getNombre()} su rendimiento es {jugador.getRendimiento()}" );
        }
    }

    // Método para calcular la suma del rendimiento de los jugadores en el equipo{
    public int CalcularPuntaje(){
        return jugadores.Sum(jugador => jugador.getRendimiento());
    }
        
            
}
