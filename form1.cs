using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//using Bunifu.Framework.UI;


namespace KBteste
{
    public partial class Form1 : Form
    {
        List<Button> ListaPressionados = new List<Button>();

        public Form1()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
            //btn_Q.BackColor = System.Drawing.Color.DarkOrange;
            //btn_Q.OnIdleState.FillColor = System.Drawing.Color.Green; // Define a cor padrão para o botão 'Q'
            List<Button> lstALLBtn = this.Controls.OfType<Button>().Where(a => a.Name.StartsWith("btn")).ToList();
            lstALLBtn.ForEach(Console.WriteLine);
        }




        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            List<Button> ListaPressionados = new List<Button>();

            
            //Console.WriteLine("Tecla"+e.KeyCode);




            if (e.KeyCode == Keys.Escape)
            {
                btn_Esc.BackColor = System.Drawing.Color.DarkOrange;
                ListaPressionados.Add(btn_Esc);
                Console.WriteLine("Tecla down" + e.KeyCode);

            }

            if (e.KeyCode == Keys.Q)
            {
                btn_Q.BackColor = System.Drawing.Color.DarkOrange;
                ListaPressionados.Add(btn_Q);
                Console.WriteLine("Tecla down" + e.KeyCode);

            }

            if (e.KeyCode == Keys.W)
            {
                btn_W.BackColor = System.Drawing.Color.DarkOrange;
                ListaPressionados.Add(btn_W);
                Console.WriteLine("Tecla down" + e.KeyCode);

            }

            if (e.KeyCode == Keys.E)
            {
                btn_e.BackColor = System.Drawing.Color.DarkOrange;
                ListaPressionados.Add(btn_e);
                Console.WriteLine("Tecla down" + e.KeyCode);

            }


        }




        private void resetarCor(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is Button)
                {
                    c.BackColor = System.Drawing.Color.Transparent;
                }
            }


   



        }
    }
}











            

