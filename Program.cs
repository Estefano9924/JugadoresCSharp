using JUGADORES.clases;

 List<Jugador> jugadoresRegistrados = new List<Jugador>();
        
        Jugador jugador1 = new Jugador("Jugador 1", "mediocampista", 10);
        Jugador jugador2 = new Jugador("Jugador 2", "defensa", 6);
        Jugador jugador3 = new Jugador("Jugador 3", "delantero", 8);
        Jugador jugador4 = new Jugador("Jugador 4", "defensa", 9);
        Jugador jugador5 = new Jugador("Jugador 5", "delantero", 7);
        Jugador jugador6 = new Jugador("Jugador 6", "mediocampista", 6);
        
        jugadoresRegistrados.Add(jugador1);
        jugadoresRegistrados.Add(jugador2);
        jugadoresRegistrados.Add(jugador3);
        jugadoresRegistrados.Add(jugador4);
        jugadoresRegistrados.Add(jugador5);
        jugadoresRegistrados.Add(jugador6);
       
        Equipo equipo1 = new Equipo();
        Equipo equipo2 = new Equipo();

        Random random = new Random();
        while (equipo1.CalcularPuntaje() < 20 || equipo2.CalcularPuntaje() < 20)
        {
            int indiceAleatorio = random.Next(jugadoresRegistrados.Count);
            Jugador jugadorSeleccionado = jugadoresRegistrados[indiceAleatorio];

            if (equipo1.CalcularPuntaje() <= equipo2.CalcularPuntaje())
            {
                equipo1.AgregarJugador(jugadorSeleccionado);
                
            }
            else
            {
                equipo2.AgregarJugador(jugadorSeleccionado);
            }

            jugadoresRegistrados.RemoveAt(indiceAleatorio);
        }

        Console.WriteLine("Jugadores del Equipo 1:");
        equipo1.MostrarJugadores();
        Console.WriteLine();
        Console.WriteLine("Jugadores del Equipo 2:");
        equipo2.MostrarJugadores();
        Console.WriteLine();

        int puntajeEquipo1 = equipo1.CalcularPuntaje();
        int puntajeEquipo2 = equipo2.CalcularPuntaje();

        Console.WriteLine($"Equipo 1: {puntajeEquipo1} puntos");
        Console.WriteLine($"Equipo 2: {puntajeEquipo2} puntos");

        if (puntajeEquipo1 > puntajeEquipo2)
        {
            Console.WriteLine("El Equipo 1 gana el partido.");
        }
        else if (puntajeEquipo2 > puntajeEquipo1)
        {
            Console.WriteLine("El Equipo 2 gana el partido.");
        }
        else
        {
            Console.WriteLine("El partido termina en empate.");
        }