using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Playstation_3_expulsar_juego.Properties;

namespace Playstation_3_expulsar_juego
{
    public partial class Form1 : Form
    {
        int x, y, a;
        bool z,w;
        PictureBoxTransparente pb = new PictureBoxTransparente();
        public Form1()
        {
            InitializeComponent();
            x = 532;
            y = 232;
            this.Width = x;
            this.Height = y;
            webBrowser1.Visible = false;
            panel1.Visible = false;
            webBrowser2.ScriptErrorsSuppressed = true;
            pb.Image = Properties.Resources.pad;
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.Dock = DockStyle.Fill;
            Image img = pictureBox4.Image;
            img.RotateFlip(RotateFlipType.Rotate180FlipNone);
            pictureBox4.Image = img;
            panel1.Controls.Add(pb);
        }

        public class PictureBoxTransparente : PictureBox
        {
            protected override void WndProc(ref Message m)
            {
                const int WM_NCHITTEST = 0x84;
                const int HTTRANSPARENT = -1;

                if (m.Msg == WM_NCHITTEST)
                {
                    m.Result = (IntPtr)HTTRANSPARENT; // Ignora el mouse
                    return;
                }

                base.WndProc(ref m);
            }
        }

        void url(string url)
        {
            Process.Start("cmd", "/C @echo off &title Radagon &color 04 &start " + url);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "Radagon")
            {
                url("https://r-roms.github.io/megathread/sony/#sony-playstation-3");
            }
            else
            {
                //Process.Start("cmd", "/C @echo off &title Radagon&color 04 &echo Se abrio el navegador de preferencia para ejecutar el comando, ya puede cerrar la ventana. &start http://" + textBox1.Text + "/xmb.ps3$exit");
                webBrowser1.Navigate("http://" + textBox1.Text + "/xmb.ps3$exit");
                label2.Text = "1.-Escribe en el cuadro de texto Radagon \n2.-Da click en el boton expulsar\n3.-De esta manera ingresaras al sitio para \ncontenido adicional.";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("cmd", "/C @echo off &title Radagon &color 04 &start https://www.youtube.com/@Ing.Radagon?sub_confirmation=1 &exit");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            url("http://" + textBox1.Text + "/");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            label5.Visible = false;
            if (z == false)
            {
                //string ruta = Path.Combine(Application.StartupPath, "Resources/local", "index.html");
                //string html = Properties.Resources.index;
                string html = Properties.Resources.PS3_Remote_Controller;
                webBrowser2.DocumentText = html;
                panel1.Visible = true;
                webBrowser2.Focus();
                panel1.Focus();
                this.Width = 920;
                this.Height = 670;
                z = true;
            }
            else
            {
                panel1.Visible = true;
                this.Width = 920;
                this.Height = 670;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            switch (w)
                {
                case false:
                    w = true;
                    button4.Text = "Ocultar";
                    pb.BringToFront();
                    pictureBox7.SendToBack();
                    pictureBox8.SendToBack();
                    pictureBox9.SendToBack();
                    break;
                case true:
                    w = false;
                    button4.Text = "Mostrar";
                    pb.SendToBack();
                    pictureBox7.BringToFront();
                    pictureBox8.BringToFront();
                    pictureBox9.BringToFront();
                    break;
            }
            button4.BringToFront();
            button3.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            label5.Visible = true;
            this.Width = x;
            this.Height = y;
        }
    }
}
