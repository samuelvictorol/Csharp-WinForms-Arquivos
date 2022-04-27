using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AulaWF01Arquivos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_criar_Click(object sender, EventArgs e)
        {
            string pastaCriada = @"C:\" + txt_criar.Text;
            if (!Directory.Exists(pastaCriada)) Directory.CreateDirectory(pastaCriada);
            else MessageBox.Show("Pasta já existe", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        private void btn_del_Click(object sender, EventArgs e)
        {
            string pastaDeletada = @"C:\" + txt_del.Text;
            if (!Directory.Exists(pastaDeletada)) MessageBox.Show("Pasta não Existe");
            else
            {
                Directory.Delete(pastaDeletada);
                MessageBox.Show($"Pasta {txt_del.Text} excluída");
                txt_del.Focus();
            }
        }
    }
}
