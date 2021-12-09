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
using mvc_project.Models.POO.FacadePattern;
using mvc_project.Models.POO.Observer;
using mvc_project.Models.POO.StatePattern;
using mvc_project.Models.ViewModels;

namespace mvc_project.Controllers
{
    public class ObserverController : Controller
    {
        private readonly ILogger<ObserverController> _logger;

        public ObserverController(ILogger<ObserverController> logger)
        {
            _logger = logger;
        }

        public IActionResult EjemploObserver()
        {
            //TODO - Esto lo obtengo de la BD
            List<Observador> jugadores = this.ObtenerJugadores();
            Observador tribuna = this.ObtenerTribuna();

            Sujeto sujeto = this.AgregarObservadores(jugadores);
            sujeto.AgregarObservador(tribuna);
            
            EjemploObserverViewModel ejemploObserverViewModel = ObtenerViewModel(jugadores, tribuna);

            return View(ejemploObserverViewModel);
        }

        public IActionResult CometiFalta()
        {
            //TODO - Esto lo obtengo de la BD
            List<Observador> jugadores = this.ObtenerJugadores();
            Observador tribuna = this.ObtenerTribuna();

            Sujeto sujeto = this.AgregarObservadores(jugadores);
            sujeto.AgregarObservador(tribuna);
            
            sujeto.NotificarFalta();

            EjemploObserverViewModel ejemploObserverViewModel = ObtenerViewModel(jugadores, tribuna);

            return View("~/Views/Observer/EjemploObserver.cshtml", ejemploObserverViewModel);
        }

        private static EjemploObserverViewModel ObtenerViewModel(List<Observador> jugadores, Observador tribuna)
        {
            EjemploObserverViewModel ejemploObserverViewModel = new EjemploObserverViewModel();

            ejemploObserverViewModel.ModeloEquipo = new Models.DTO.ModeloEquipo();

            ejemploObserverViewModel.ModeloEquipo.Jugadores = new List<Models.DTO.ModeloJugador>();

            foreach (Observador observador in jugadores)
            {
                ejemploObserverViewModel.ModeloEquipo.Jugadores.Add(new Models.DTO.ModeloJugador
                {
                    JugadorDice = ((Jugador)observador).JugadorDice
                });
            }

            ejemploObserverViewModel.ModeloEquipo.Jugadores.Add(new Models.DTO.ModeloJugador
            {
                JugadorDice = ((Tribuna)tribuna).TribunaDice
            });

            return ejemploObserverViewModel;
        }

        public List<Observador> ObtenerJugadores()
        {
            List<Observador> jugadores = new List<Observador>(4);
            for(int i = 0; i < 4; i++)
            {
                jugadores.Add(new Jugador());
            }

            return jugadores;
        }

        public Tribuna ObtenerTribuna()
        {
            return new Tribuna();
        }

        public Sujeto AgregarObservadores(List<Observador> observadores)
        {
            Sujeto sujeto = new Referi();

            foreach(Observador observador in observadores)
            {
                sujeto.AgregarObservador(observador);
            }

            return sujeto;
        }
    }
}
