namespace JUGADORES.clases; 

public class Jugador 
{
    private string nombre;
    private string posicion;
    private int rendimiento;

    public Jugador(string nombre, string posicion, int rendimiento)
    {
        this.nombre = nombre;
        this.posicion = posicion;
        this.rendimiento = rendimiento;
    }

    public string getNombre(){
        return nombre;
    } 
    public string getPosicion(){
        return posicion;
    } 
    public int getRendimiento(){
        return rendimiento;
    } 
}