using System;
using mvc_project.Models.POO;

namespace mvc_project.Models
{
    public class MockupBaseDatos
    {
        #region Instancia
        private static MockupBaseDatos instance;

        public static MockupBaseDatos Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new MockupBaseDatos();
                }

                return instance;
            }
        }
        #endregion

        #region Constructor privado
        private MockupBaseDatos()
        {

        }
        #endregion
    
        public TakeCarer TakeCarer { get; set; }

        public PersonaModel PersonaModel { get; set; }
    }
}
