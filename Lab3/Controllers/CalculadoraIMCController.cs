using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
namespace WebApplication1.Controllers
{
    public class CalculadoraIMCController : Controller
    {
        public ActionResult ResultadoIMC()
        {
            PersonaModel persona = new PersonaModel(1, "Cristiano Ronaldo", 84.0,
           1.87);
            double IMC = persona.Peso / (persona.Estatura * persona.Estatura);
            ViewBag.IMC = IMC;
            ViewBag.persona = persona;
            // GET: CalculadoraIMC
            return View();
        }
        public ActionResult ResultadosAleatoriosIMC()
        {
            List<PersonaModel> personas = new List<PersonaModel>();
            double[] resultIMC = new double[30];
            Random aleatorio = new Random();

            for (int indice = 0; indice < 30; indice++)
            {
                PersonaModel persona = new PersonaModel(indice, "Sin nombre", GetRandom(aleatorio, 20, 150), GetRandom(aleatorio, 1, 2));
                personas.Add(persona);
                resultIMC[indice] = personas[indice].Peso / (personas[indice].Estatura * personas[indice].Estatura);
            }

            ViewBag.resultIMC = resultIMC;
            ViewBag.personas = personas;
            return View();
        }
        double GetRandom(Random aleatorio, double minimo, double maximo)
        {
            return aleatorio.NextDouble() * (maximo - minimo) + minimo;
        }




    }
}