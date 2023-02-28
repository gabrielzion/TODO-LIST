using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TODO_LIST
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (txtTarefa.Text == "")
            {
                MessageBox.Show("Insira uma tarefa");
            } else
            {
                lista.Items.Add($"{dataPicker.Value:d} - {txtTarefa.Text}");
            }
            
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            lista.Items.Remove(lista.SelectedItem);
        }
    }
}
