namespace mvc_project.Models.POO.Observer
{
    public class Referi : Sujeto
    {
        public override void CometiFalta()
        {
            base.NotificarFalta();
        }
    }
}