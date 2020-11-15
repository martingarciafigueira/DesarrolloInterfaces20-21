using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio29
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MostrarNombre(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MostrarNombres(textBox1.Text, textBox2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double salario = 0;
            int anhos = 0;

            double.TryParse(textBox1.Text, out salario);
            int.TryParse(textBox2.Text, out anhos);

            MostrarIngresos(salario, anhos);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            double centimetros, pulgadas;

            double.TryParse(textBox1.Text, out centimetros);

            pulgadas = CalcularPulgadas(centimetros);

            MessageBox.Show(centimetros + " son " + pulgadas + " pulgadas");

        }

        public void MostrarNombre(string nombre)
        {
            MessageBox.Show("El nombre introducido es: " + nombre);
        }

        public void MostrarNombres(string nombre, string apellido)
        {
            MessageBox.Show("El nombre introducido es: " + nombre);
            MessageBox.Show("El apellido introducido es: " + apellido);
        }

        public void MostrarIngresos(double salario, double anhosTrabajados)
        {
            double totalIngresado;

            totalIngresado = salario * anhosTrabajados;

            MessageBox.Show("El total de ingresos es: " + totalIngresado);
        }

        public double CalcularPulgadas(double centimetros)
        {
            double pulgadas = 0;

            pulgadas = centimetros * 0.394;

            return pulgadas;
        }

        public double CalcularAreaCirculo(double radio)
        {
            double area;

            area = Math.PI * Math.Pow(radio, 2);

            return area;
        }

        public int EnSegundos(int horas, int minutos, int segundos)
        {
            int segundosTotales = 0;

            segundosTotales += horas * 3600;
            segundosTotales += minutos * 60;
            segundosTotales += segundos;

            return segundosTotales;
        }

        public void CalcularIncremento(int numero)
        {
            int numeroIncrementado = numero++;
            MessageBox.Show("El número incrementado es: " + numeroIncrementado);
        }

        public void CalcularSumaYDiferencia(int numero1, int numero2)
        {
            int suma, diferencia;

            suma = numero1 + numero2;
            diferencia = numero1 - numero2;

            MessageBox.Show("La suma es: " + suma);
            MessageBox.Show("La diferencia es: " + diferencia);

        }

        public void CalcularSegundosAHMS(int segundos)
        {
            int horas, minutos;

            horas = (int)(segundos / 3600);
            if (horas >= 1)
            {
                segundos -= horas * 3600;
            }
            minutos = (int)(segundos / 60);
            if (minutos >= 1)
            {
                segundos -= minutos * 60;
            }

            MessageBox.Show("Horas: " + horas + ", Minutos: " + minutos + ", Segundos:" + segundos);
        }

        public int CalcularDiferencia

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            double radio, area;

            double.TryParse(textBox1.Text, out radio);

            area = CalcularAreaCirculo(radio);

            MessageBox.Show("El área de un círculo de radio " + radio + " es: " + area);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int horas, minutos, segundos, segundosTotales;

            int.TryParse(textBox1.Text, out horas);
            int.TryParse(textBox2.Text, out minutos);
            int.TryParse(textBox3.Text, out segundos);

            segundosTotales = EnSegundos(horas, minutos, segundos);

            MessageBox.Show("Los segundos totales son: " + segundosTotales);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int numero;

            int.TryParse(textBox1.Text, out numero);

            CalcularIncremento(numero);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int numero1, numero2;

            int.TryParse(textBox1.Text, out numero1);
            int.TryParse(textBox2.Text, out numero2);

            CalcularSumaYDiferencia(numero1, numero2);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int segundos;

            int.TryParse(textBox1.Text, out segundos);

            CalcularSegundosAHMS(segundos);
        }
    }
}
