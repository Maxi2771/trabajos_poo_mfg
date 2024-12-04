using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer004
{
    internal class Electrodomestico
    {
        private double precioBase;
        private string color;
        private char consumoEnergetico;
        private double peso;

        private const double precioBaseDefecto = 100;
        private const string colorDefecto = "Blanco";
        private const char consumoEnergeticoDefecto = 'F';
        private const double pesoDefecto = 5;

        public double PrecioBase { 
            get { return precioBase; } 
        }
        public string Color { 
            get { return color; } 
        }
        public char ConsumoEnergetico { 
            get { return consumoEnergetico; }  
        }
        public double Peso { 
            get { return peso; } 
        }


        public Electrodomestico()
        {
            precioBase = precioBaseDefecto;
            color = colorDefecto;
            consumoEnergetico = consumoEnergeticoDefecto;
            peso = pesoDefecto;
        }

        public Electrodomestico(double precioBase, double peso)
        {
            this.precioBase = precioBase;
            color = colorDefecto;
            consumoEnergetico = consumoEnergeticoDefecto;
            this.peso = peso;
        }

        public Electrodomestico(double precioBase, string color, char consumoEnergetico, double peso)
        {
            this.precioBase = precioBase;
            this.color = color;
            this.consumoEnergetico = consumoEnergetico;
            this.peso = peso;
        }

        public virtual char ComprobarConsumoEnergetico(char letra)
        {
            switch (letra)
            {
                case 'A':
                    return letra;
                case 'B':
                    return letra;
                case 'C':
                    return letra;
                case 'D':
                    return letra;
                case 'E':
                    return letra;
                case 'F':
                    return letra;
                default:
                    return consumoEnergeticoDefecto;
            }
        }

        public string ComprobarColor(string color)
        {
            switch (color)
            {
                case "Blanco":
                    return color;
                case "Negro":
                    return color;
                case "Rojo":
                    return color;
                case "Azul":
                    return color;
                case "Gris":
                    return color;
                default:
                    return colorDefecto;
            }
        }

        public virtual double PrecioFinal()
        {
            double precioFinal = precioBase;
            switch (consumoEnergetico)
            {
                case 'A': 
                    precioFinal += 100; 
                    break;
                case 'B': 
                    precioFinal += 80; 
                    break;
                case 'C': 
                    precioFinal += 60; 
                    break;
                case 'D': 
                    precioFinal += 50; 
                    break;
                case 'E': 
                    precioFinal += 30; 
                    break;
                case 'F': 
                    precioFinal += 10; 
                    break;
            }
            if (peso < 20) precioFinal += 10;

            else if (peso < 50) precioFinal += 50;

            else if (peso < 80) precioFinal += 80;

            else precioFinal += 100;


            return precioFinal;
        }
    }
}

