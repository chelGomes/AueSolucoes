using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AueSolucoes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void labelSexo_Click(object sender, EventArgs e){

        }

        private void buttonInclui_Click(object sender, EventArgs e){
            try {
                string stringcon = "@Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"D:\\Estagio\\Estagio_AuE Software\\AueSolucoes\\auebd.mdb";
                OleDbConnection conn = new OleDbConnection(stringcon);
                conn.Open();

                string SQL;
                SQL = "insert into Contatos(Nome, Sexo, Data, Cidade)Values";
                SQL += "('" + textBoxNome.Text + " ',' " + textBoxCidade.Text + " ',' " + checkBoxMasculino.Checked + " ',' " + checkBoxFeminino.Checked + "','" + dateTime.Checked + "')";
                OleDbCommand cmd = new OleDbCommand(SQL,conn);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Inclusão realizada com sucesso!", "Incluir", MessageBoxButtons.OK, MessageBoxIcon.Information);

                textBoxNome.Clear();
                textBoxCidade.Clear();
                checkBoxMasculino.Checked = false;
                checkBoxFeminino.Checked = false;


                conn.Close();
            }
            catch (Exception erro){

                MessageBox.Show(erro.Message);

                throw;
            }
         
  

        }

        private void buttonAltera_Click(object sender, EventArgs e){
            try
            {
                string stringcon = "@Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"D:\\Estagio\\Estagio_AuE Software\\AueSolucoes\\auebd.mdb";
                OleDbConnection conn = new OleDbConnection(stringcon);
                conn.Open();

                string SQL;
                SQL = "update into Contatos(Nome, Sexo, Data, Cidade)Values";
                SQL += "('" + textBoxNome.Text + " ',' " + textBoxCidade.Text + " ',' " + checkBoxMasculino.Checked + " ',' " + checkBoxFeminino.Checked + "','" + dateTime.Checked + "')";
                OleDbCommand cmd = new OleDbCommand(SQL, conn);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Alteração realizada com sucesso!", "Alterar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                textBoxNome.Clear();
                textBoxCidade.Clear();
                checkBoxMasculino.Checked = false;
                checkBoxFeminino.Checked = false;


                conn.Close();
            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);

                throw;
            }

        }

        private void buttonExclui_Click(object sender, EventArgs e){
            MessageBox.Show("Deseja excluir o cadastro ?", "Excluir", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
        }

        private void buttonContato_Click(object sender, EventArgs e){
             MessageBox.Show("Contagem do numero de contatos!", "Contagem numero",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
