using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mvc_project.Models;
using mvc_project.Models.POO;
using mvc_project.Models.POO.Composite;
using mvc_project.Models.POO.StatePattern;
using mvc_project.Models.ViewModels;

namespace mvc_project.Controllers
{
    public class MementoController : Controller
    {
        private readonly ILogger<MementoController> _logger;

        public MementoController(ILogger<MementoController> logger)
        {
            _logger = logger;
        }

        public IActionResult EjemploMemento()
        {
            PersonaModel personaModel = new PersonaModel
            {
                Nombre = "Federico",
                Apellido = "Piedrasanta",
                TipoDocumento = "DNI"
            };

            TakeCarer takeCarer = new TakeCarer
            {
                HistorialPersona = new List<PersonaModel>(),
                PersonaModel = personaModel
            };
            
            MockupBaseDatos.Instance.TakeCarer = takeCarer;
            MockupBaseDatos.Instance.PersonaModel = personaModel;

            MementoViewModel mementoViewModel = new MementoViewModel()
            {
                HistorialPersona = new List<PersonaModel>(),
                Persona = personaModel
            };

            return View(mementoViewModel);
        }
    
        public IActionResult CambiarPersona()
        {
            PersonaModel personaModel = MockupBaseDatos.Instance.PersonaModel;
            TakeCarer takeCarer = MockupBaseDatos.Instance.TakeCarer;

            takeCarer.SaveToMemento(personaModel);

            personaModel.Nombre = "Cambio nro " + takeCarer.HistorialPersona.Count;
            personaModel.Apellido += " - " + takeCarer.HistorialPersona.Count + " - ";

            MementoViewModel mementoViewModel = new MementoViewModel()
            {
                HistorialPersona = new List<PersonaModel>(),
                Persona = personaModel
            };

            /*
            foreach(PersonaModel persona in takeCarer.HistorialPersona)
            {
                mementoViewModel.HistorialPersona.Add(persona);
            }
            */

            PersonaModel persona = personaModel.PersonaAnterior;

            while(persona != null)
            {
                mementoViewModel.HistorialPersona.Add(persona);

                persona = persona.PersonaAnterior;
            }

            mementoViewModel.Persona = personaModel;

            return View("~/Views/Memento/EjemploMemento.cshtml", mementoViewModel);
        }
    }
}
