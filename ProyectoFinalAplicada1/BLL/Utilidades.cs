﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Controls;

namespace ProyectoFinalAplicada1.BLL
{
    public class Utilidades
    {
        public static int ToInt(string valor)
        {
            int retorno = 0;
            int.TryParse(valor, out retorno);
            return retorno;
        }

        public static void ValidarSoloLetras(KeyEventArgs v)
        {
            if (Char.IsDigit(Convert.ToChar(v.Key)))
            {
                v.Handled = false;
            }
            else if (Char.IsSeparator(Convert.ToChar(v.Key)))
            {
                v.Handled = false;
            }
            else if (Char.IsControl(Convert.ToChar(v.Key)))
            {
                v.Handled = false;
            }
            else
            {
                v.Handled = true;
                MessageBox.Show("Solo Puede Digitar Letras", "Informacion Importante", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }


             public static void ValidarSoloNumeros(KeyEventArgs v)
             {
                 if (Char.IsLetter(Convert.ToChar(v.Key)))
                 {
                     v.Handled = false;
                 }
                 else if (Char.IsSeparator(Convert.ToChar(v.Key)))
                 {
                     v.Handled = false;
                 }
                 else if (Char.IsControl(Convert.ToChar(v.Key)))
                 {
                     v.Handled = false;
                 }
                 else
                 {
                     v.Handled = true;
                     MessageBox.Show("Solo Puede Digitar Numero","Informacion Importante",MessageBoxButton.OK,MessageBoxImage.Information);
                 }
             }
             


            /* public static void NumerosDecimales(KeyEventArgs v)
             {
                 if (Char.IsDigit(v.Key))
                 {
                     v.Handled = false;
                 }
                 else if (Char.IsSeparator(v.KeyChar))
                 {
                     v.Handled = false;
                 }
                 else if (Char.IsControl(v.KeyChar))
                 {
                     v.Handled = false;
                 }
                 else if (v.KeyChar.ToString().Equals("."))
                 {
                     v.Handled = false;
                 }
                 else
                 {
                     v.Handled = true;
                     MessageBox.Show("Solo numeros o numeros con punto decimal");
                 }
             }*/
        }

    }
    



