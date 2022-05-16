﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_GitHub_1oDAWSemi_Calculadora
{
    public partial class Form1 : Form
    {
        /**
         * @Author: Tonet / S3ll4rd0 (Antonio Nicolás Salmerón Rubio)
         * 
         * @Variables: Declaro 3 variables double para que acepten decimales, 
         * con las que trabajaremos en todo el programa.
         * Declaro 1 variable operador string que servirá para añadir en ella todos los 
         * números con las pulsaciones de botones, y hasta que no queramos operar, en 
         * cuyo caso lo convertiremos a double para trabajar con el valor que contenga.
         * Declaro una variable boleana para almacenar si el operador tiene coma o no,
         * que nos servirá para poder comprobar que cada operador que introduzcamos solo
         * pueda tener 1 coma.
         */

        private double operador1;
        private double operador2;
        private double resultado;
        private string operador;
        private bool tieneComa;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /**
             *  @Author: Tonet / S3ll4rd0 (Antonio Nicolás Salmerón Rubio)
             *  
             *  @Method: Este método inicia las variables privadas y pone en las pantallas,
             *  el valor de 0 en ambas, tanto la de resultado, que es la que va a mostrar el 
             *  resultado de todas las operaciones consecutivas, por ejemplo si vamos sumando
             *  muchos números, esa pantalla mostrará el valor final de todas las operaciones,
             *  como en la pantalla de operador, que es la pantalla que contendrá en pantalla
             *  el valor del operador con el que estamos trabajando en el momento.
             *  
             *  @Variables: operadores definidos como double para que acepten decimales,
             *  y una variable resultado que almacenará el resultado de la operació entre ambas.
             *  Cuando se introduzcan más de dos operadores, resultado almacenará el valor de 
             *  todo lo calculado, mientras que operador1 se vaciará para poder recibir el nuevo 
             *  operador que introduzcamos, y operador2 mantendrá el valor que ya tenemos para 
             *  hacer las debidas operaciones.
             */

            operador1 = 0;
            operador2 = 0;
            resultado = 0;
            operador = "";
            tieneComa = false;
            textBoxOperador.Text = "0";
            textBoxResultado.Text = "0";
        }

        private void btnUno_Click(object sender, EventArgs e)
        {

        }

        private void btnDos_Click(object sender, EventArgs e)
        {

        }

        private void btnTres_Click(object sender, EventArgs e)
        {

        }

        private void btnCuatro_Click(object sender, EventArgs e)
        {

        }

        private void btnCinco_Click(object sender, EventArgs e)
        {

        }

        private void btnSeis_Click(object sender, EventArgs e)
        {

        }

        private void btnSiete_Click(object sender, EventArgs e)
        {

        }

        private void btnOcho_Click(object sender, EventArgs e)
        {

        }

        private void btnNueve_Click(object sender, EventArgs e)
        {

        }

        private void btnCero_Click(object sender, EventArgs e)
        {

        }

        private void btnPunto_Click(object sender, EventArgs e)
        {

        }

        private void btnSumar_Click(object sender, EventArgs e)
        {

        }

        private void btnResta_Click(object sender, EventArgs e)
        {

        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {

        }

        private void btnDividir_Click(object sender, EventArgs e)
        {

        }

        private void btnIgual_Click(object sender, EventArgs e)
        {

        }

        private void btnPorcentaje_Click(object sender, EventArgs e)
        {

        }

        private void btnRaizCuadrada_Click(object sender, EventArgs e)
        {

        }

        private void btnPotencia_Click(object sender, EventArgs e)
        {

        }

        private void btnTangente_Click(object sender, EventArgs e)
        {

        }

        private void btnCoseno_Click(object sender, EventArgs e)
        {

        }

        private void btnSeno_Click(object sender, EventArgs e)
        {

        }

        private void btnBorrarOperador_Click(object sender, EventArgs e)
        {

        }

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {

        }
    }
}
