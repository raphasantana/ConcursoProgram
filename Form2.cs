using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.Office.Interop.Word;


namespace Calendario2
{
    public partial class Adicionar : Form
    {
        public Adicionar()
        {
            InitializeComponent();
        }

        public string Datamysql(string data) // Transformar uma string na forma do Mysql - Outra forma de fazer na do form1;
        {
            string dia, ano, mes,mysq;
            ano = data.Substring(6);
            dia = data.Substring(0, 2);
            mes = data.Substring(3, 2);

            mysq = ano + '-' + mes + '-' + dia;

            return mysq;
        }

        int TimeCalculate(string file)// Calcular o tempo de revisão pelo tamanho do arquivo.
        {
            int kbytes, time;

            FileInfo Fi = new FileInfo(file);

            kbytes = Convert.ToInt32(Fi.Length) / 1000;

            if (kbytes < 100)
                time = 10;
            else if (kbytes < 400)
                time = 15;
            else if (kbytes < 800)
                time = 20;
            else
                time = 25;
            return time;
        }

        string calculateDay(string category, int review, DateTime date, ClasseDB DB, int time) // Calcular o dia que será salvo a revisão da tarefa.
        {
            int tempodiario = 50, aux = 0;
            DateTime datefinal = date;

            while (tempodiario > 30)
            {
                
                if (aux == 0)
                {
                    aux++;
                    if (review == 0)
                        datefinal = datefinal.AddDays(7);
                    else if (review == 1)
                        datefinal = datefinal.AddDays(21);
                    else if (review >= 2)
                        datefinal = datefinal.AddDays(45);
                    tempodiario = DB.catchDB(datefinal, category) + time;
                }
                else
                {
                    datefinal = datefinal.AddDays(1);

                    tempodiario = DB.catchDB(datefinal, category) + time;
                }
            }
            string datedb = datefinal.ToString("yyyy-MM-dd");

            return datedb;
        }
            
        private void Save_Click(object sender, EventArgs e)
        {
            string data, datamysql;

            data = Data.Value.ToShortDateString();// Transforma a datatimepicker em apenas data

            datamysql = Datamysql(data.ToString());// Utilizar da função criada na parte superior para transformar para a data na forma correta.

            ClasseDB Database = new ClasseDB();
            string trans = Data.Value.ToShortDateString(); // Transformar o DateTime somente em data, retirar o tempo.
            DateTime datefunction = Convert.ToDateTime(trans);

            if (NomedaDisciplina.Text == "" || Categoria.Text == "" || Arquivo.Text == "" || Revisao.Text == "")
                MessageBox.Show("Preencha todos os campos !!!");
            else
            {
                int time = TimeCalculate(Arquivo.Text);
                string datereview = calculateDay(Categoria.Text, Convert.ToInt32(Revisao.Text), datefunction, Database, time);
                (string salva, int i) = Database.SaveData(NomedaDisciplina.Text,Arquivo.Text,Categoria.Text,datamysql,Convert.ToString(Revisao.Text),time,datereview);
                if (i == 1)
                {
                    NomedaDisciplina.Text = "";
                    Categoria.Text = "";
                    Arquivo.Text = "";
                    Revisao.Text = "";
                    MessageBox.Show(salva);
                    this.Close();
                    new Principal().Show();
                }
                else
                    MessageBox.Show(salva);

            }
        }

        private void AbrirArquivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog(); // Abre a caixa do computador para selecionar um arquivo.

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK) // Confirmar se deu certo.
            {
                string strfile = openFileDialog1.FileName;

                Arquivo.Text = strfile;
            }

        }

        private void Voltar_Click(object sender, EventArgs e)
        {
            // Forma de mudar de tela como anteriormente.
            this.Hide();
            Principal g = new Principal();
            g.Closed += (s, args) => this.Close();
            g.Show();
      

        }

        private void Adicionar_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(Back, "Voltar para Página principal.");
            toolTip1.SetToolTip(OpenFile, "Procurar arquivo no Computador.");
            toolTip1.SetToolTip(Save, "Salvar no Banco de Dados.");
        }

        private void TestarPdfForm_Click(object sender, EventArgs e)
        {
            OpenPDF destino = new OpenPDF(Arquivo.Text); // Iniciar um outro construtor do OpenPDF.
            destino.Show();
        }

        private void Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nessa página de cadastro, você cadastra conteúdos já estudados no programa, com o objetivo de revisá-lo futuramanete.");
        }
    }
}
