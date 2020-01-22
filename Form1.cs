using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Analizador_léxico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_evaluar_Click(object sender, EventArgs e)
        {
            //instancia a clase donde analizo
            Analizador_Léxico inst = new Analizador_Léxico();
            //llamo a la función que analiza mi cadena
            inst.analizar(txtentrada.Text);
            //imprimo los tokens
            inst.show_tokens();
        }
    }
}
