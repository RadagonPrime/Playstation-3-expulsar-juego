using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Playstation_3_expulsar_juego
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "Radagon")
            {
                Process.Start("cmd", "/C @echo off &title Radagon &color 04 &start https://r-roms.github.io/megathread/sony/#sony-playstation-3 $exit");
            }
            else
            {
                Process.Start("cmd", "/C @echo off &title Radagon&color 04 &echo Se abrio el navegador de preferencia para ejecutar el comando, ya puede cerrar la ventana. &start http://" + textBox1.Text + "/xmb.ps3 $exit");
                label2.Text = "1.-Escribe en el cuadro de texto Radagon \n2.-Da click en el boton expulsar\n3.-De esta manera ingresaras al sitio para \ndescargar juegos,updates,etc.";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("cmd", "/C @echo off &title Radagon &color 04 &start https://www.youtube.com/@Ing.Radagon?sub_confirmation=1 $exit");
        }
    }
}
