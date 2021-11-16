using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mvc_project.Models;
using mvc_project.Models.POO;
using mvc_project.Models.ViewModels;

namespace mvc_project.Controllers
{
    public class PersonaController : Controller
    {
        private readonly ILogger<PersonaController> _logger;

        public PersonaController(ILogger<PersonaController> logger)
        {
            _logger = logger;
        }

        public IActionResult FichaPersonal()
        {
            //TODO - Fede: Obtener de base de datos.
            PersonaModel personaModel = PersonaController.obtenerPersona();

            FichaPersonalViewModel fichaPersonalViewModel = new FichaPersonalViewModel
            {
                Persona = personaModel
            };

            return View(fichaPersonalViewModel);
        }

        private static PersonaModel obtenerPersona()
        {
            return new PersonaModel
            {
                Altura = 1.74f,
                Apellido = "Piedrasanta",
                FechaNacimiento = new DateTime(1982, 7, 27),
                Nombre = "Federico",
                NumeroDocumento = 29711907
            };
        }

        public IActionResult FichaPersonalTrabajo()
        {
            //TODO - Fede: Obtener de base de datos.
            PersonaModel personaModel = PersonaController.obtenerPersona();

            OcupacionModel ocupacion = ObtenerOcupacion();
            personaModel.Ocupacion = ocupacion;
            
            FichaPersonalViewModel fichaPersonalViewModel = new FichaPersonalViewModel
            {
                Persona = personaModel
            };

            return View(fichaPersonalViewModel);
        }
    
        public IActionResult FichaPersonalTrabajo2()
        {
            //TODO - Fede: Obtener de base de datos.
            PersonaModel personaModel = PersonaController.obtenerPersona();

            Ocupacion2Model ocupacion2 = ObtenerOcupacion2();

            personaModel.Ocupacion2 = ocupacion2;

            FichaPersonalViewModel fichaPersonalViewModel = new FichaPersonalViewModel
            {
                Persona = personaModel
            };

            return View("~/Views/Persona/FichaPersonalTrabajo2.cshtml", fichaPersonalViewModel);
        }

        public OcupacionModel ObtenerOcupacion()
        {
            Random r = new Random();
            int i = r.Next(0, 3);
            
            if(i == 1)
            {
                return new FreelanceModel 
                {
                     DomicilioLaboral = "Mi casa", 
                     ValorHora = 100 
                };
            }
            else
            {
                return new RelacionDependenciaModel
                {
                    DomicilioLaboral = "En la empresa",
                    Sueldo = 40000
                };
            }
        }
    
        public Ocupacion2Model ObtenerOcupacion2()
        {
            Random r = new Random();
            int i = r.Next(0, 3);

            IMetodoTrabajo metodoTrabajo = null;
            if(i == 1)
            {
                metodoTrabajo = new Freelance2Model()
                {
                    ValorHora = 200
                };
            }
            else
            {
                metodoTrabajo = new RelacionDependencia2Model()
                {
                    Sueldo = 80000
                };
            }

            Ocupacion2Model ocupacion2 = new Ocupacion2Model(
                metodoTrabajo,
                "El domicilio laboral no es un método polimorfico");

            return ocupacion2;
        }
    }
}
