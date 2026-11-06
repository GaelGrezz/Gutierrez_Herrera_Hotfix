using PracticaHotfix;

Personaje personaje = new Personaje
{
    Nombre = "Guerrero",
    Vida = 100,
    Ataque = 50,
    Defensa = 39,
    Nivel = 1
};

Console.WriteLine($"Nombre: {personaje.Nombre}, Ataque:{personaje.Ataque}, Vida: {personaje.Vida}, Defensa:{personaje.Defensa}, Nivel: {personaje.Nivel}");