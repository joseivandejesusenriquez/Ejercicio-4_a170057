using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using UNACH.CALCULADORA.WS.Clases;

namespace UNACH.CALCULADORA.WS
{
    /// <summary>
    /// Descripción breve de CalcularService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class CalcularService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }
        [WebMethod(Description = "Este metodo calcula el area de un cuadrado")]
        public decimal cuadrado(decimal valor1, decimal valor2)
        {
            Calcular calcula = new Calcular();
            calcula.lado1 = valor1;
            calcula.lado2 = valor2;
            return calcula.AreaCuadrado();
        }
        [WebMethod(Description = "Este metodo calcula el area de un triangulo")]
        public decimal trianguloo(decimal baseee, decimal alturaa)
        {
            Calcular calcula = new Calcular();
            return calcula.triangulo(baseee, alturaa);
        }
        [WebMethod(Description = "Este metodo calcula el area de un circulo")]
        public double AreaCirculo(double radioo)
        {
            Calcular calcula = new Calcular();
            return calcula.circulo(radioo);
        }
    }
}