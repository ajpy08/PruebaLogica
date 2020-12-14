using MYTSoft.Operaciones.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaLogica
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void btnGo_Click(object sender, EventArgs e)
    {
      int casos = 0;
      Int32.TryParse(TxtCasos.Text, out casos);
      string output = string.Empty;

      if (casos > 0)
      {
        for (int i = 0; i < casos; i++)
        {
          string filasT = Inputbox.Show("Filas", "Ingrese el numero de Filas ", FormStartPosition.CenterScreen);
          string columnasT = Inputbox.Show("Columnas", "Ingrese el numero de columnas ", FormStartPosition.CenterScreen);

          int filas = 0;
          int columnas = 0;

          Int32.TryParse(filasT, out filas);
          Int32.TryParse(columnasT, out columnas);

          if (filas == columnas && filas > 1)
          {
            if (filas % 2 == 0)
            {
              MessageBox.Show("L");
              output += "L-";
            }
            else
            {
              MessageBox.Show("R");
              output += "R-";
            }
          }
          else
          {
            if (filas > columnas && columnas > 1)
            {
              if (columnas % 2 == 0)
              {
                MessageBox.Show("U");
                output += "U-";
              }
              else
              {
                MessageBox.Show("D");
                output += "D-";
              }
            }
            else
            {
              if (columnas > filas)
              {
                if (filas % 2 == 0)
                {
                  MessageBox.Show("L");
                  output += "L-";
                }
                else
                {
                  MessageBox.Show("R");
                  output += "R-";
                }
              }
              else
              {
                if (columnas == 1)
                {
                  if (filas == 1)
                  {
                    MessageBox.Show("R");
                    output += "R-";
                  }
                  else
                  {
                    MessageBox.Show("D");
                    output += "D-";
                  }
                }
              }
            }
          }
        }
        output = output.Length > 0 ? output.Substring(0, output.Length - 1) : string.Empty;
        label1.Text = "OUTPUT " + output;
      }
      else
      {
        MessageBox.Show("Debes escribir un número válido", "Error");
      }
    }
  }
}
