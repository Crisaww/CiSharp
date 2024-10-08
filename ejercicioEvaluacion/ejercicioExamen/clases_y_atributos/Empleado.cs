﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioExamen.clases_y_atributos
{
    public class Empleado : Persona, ICalculable
    {
        public double Salario { get; set; }
        public int DiasT { get; set; }


        // Constructor vacío para que los datos puedan ser ingresados por el usuario
        public Empleado()
        {

        }

        //Constructor con parametros
        public Empleado(double salario, int diasT)
        {
            Salario = salario;
            DiasT = diasT;
        }



        // Implementación del método CalcularSalario de la interfaz ICalculable
        public double CalcularSalario()
        {
            double valorDia = Salario / 31;
            double totalPagar = valorDia * DiasT;

            return totalPagar;
        }

        // Nuevo método asincrónico que simula una operación de lectura de datos del salario
        public async Task LeerSalarioAsync()
        {
            Console.WriteLine("Iniciando la lectura asincrónica del salario...");
            await Task.Delay(5000); // Simula una espera de 5 segundos
            Console.WriteLine("Lectura asincrónica del salario completada.");
            Console.WriteLine($"Total a pagar: {CalcularSalario()}");
        }


        // Sobrescribiendo el método para mostrar información
        public void ShowInformation()
        {
            base.ShowInformation(); // Llama al método de la clase base para mostrar info común
            Console.WriteLine($"Salario base: {Salario}");
            Console.WriteLine($"Dias trabajados: {DiasT}");
            
        }
    }
}

        
