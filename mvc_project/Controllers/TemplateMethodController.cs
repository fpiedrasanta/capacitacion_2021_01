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
using mvc_project.Models.POO.TemplateMethod;
using mvc_project.Models.ViewModels;

namespace mvc_project.Controllers
{
    public class TemplateMethodController : Controller
    {
        private readonly ILogger<TemplateMethodController> _logger;

        public TemplateMethodController(ILogger<TemplateMethodController> logger)
        {
            _logger = logger;
        }

        public IActionResult EjemploTemplateMethod()
        {
            Pago pago = ObtenerPago();
            
            EjemploTemplateMethodViewModel ejemploTemplateMethodViewModel = 
                new EjemploTemplateMethodViewModel();
            
            ejemploTemplateMethodViewModel.Resultado = pago.Cobrar();

            return View(ejemploTemplateMethodViewModel);
        }

        public Pago ObtenerPago()
        {
            Random r = new Random();
            int i = r.Next(1, 4);

            if(i == 1)
            {
                return new PagoEfectivo();
            }
            else if(i == 2)
            {
                return new PagoTarjeta();
            }
            else
            {
                return new PagoCheque();
            }
        }
    }
}
