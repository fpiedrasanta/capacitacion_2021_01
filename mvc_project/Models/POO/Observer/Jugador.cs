namespace mvc_project.Models.POO.Observer
{
    public class Jugador : Observador
    {
        public string JugadorDice { get; set; } = "¡Comencemos!";

        public override void CometioFalta()
        {
            JugadorDice = "¡Que boludo!";
        }
    }
}