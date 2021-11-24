namespace mvc_project.Models.POO
{
    public class RegistroVisita
    {
        private static RegistroVisita instance;

        private RegistroVisita()
        {

        }

        public static RegistroVisita Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new RegistroVisita();
                }

                return instance;
            }
        }

        //
        public int Visitas { get; set; }
    }
}