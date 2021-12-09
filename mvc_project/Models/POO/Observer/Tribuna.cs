namespace mvc_project.Models.POO.Observer
{
    public class Tribuna : Observador
    {
        public string TribunaDice { get; set; } = "¡Aguante Tomás!";

        public override void CometioFalta()
        {
            TribunaDice = "¡Uhhhhhhhhhhhhhhhhhhhhh!";
        }
    }
}