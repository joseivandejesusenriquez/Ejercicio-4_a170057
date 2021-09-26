using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UNACH.CALCULADORA.WS.Clases
{
    public class Calcular
    {
        public decimal lado1 { get; set; }
        public decimal lado2 { get; set; }
        public double radio1 { get; set; }
        public decimal AreaCuadrado()
        {
            return lado1 * lado2;
        }

        public decimal triangulo(decimal basee, decimal altura)
        {
            lado1 = basee;
            lado2 = altura;
            return basee * altura / 2;
        }
      
  
            public double circulo(double radio)
            {
                double pi = 3.1416;
                radio1 = radio;
                return (radio * radio) * pi;

            }
        
        
    }

}