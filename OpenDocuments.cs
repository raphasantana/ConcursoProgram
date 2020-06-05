using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; // Biblioteca necessária para o MYsql

namespace Calendario2
{
    public partial class OpenDocuments : Form
    {
        int x = 0; // Variáveis globais
        int minutos;
        int segundos = 0;
        public OpenDocuments()
        {
            InitializeComponent();

        }

        string valueTimer(int min,int seg) // Imprimir o valor do tempo corretamente
        {
            if (min > 9 && seg > 9)
                return minutos + " : " + segundos;

            else if (min > 9 && seg < 9)
                return minutos + " : 0" + segundos;

            else if (min <= 9 && seg > 9)
                return "0"+minutos + " : " + segundos;

            else
                return "0"+ minutos + " : 0" + segundos;
        }

        void OpendocumentsWord(string file) // Abrir documentos em word
        {
            Microsoft.Office.Interop.Word.Application word = new Microsoft.Office.Interop.Word.Application();

            word.Visible = true;

            word.Documents.Open(file);
        }

        void Openpdf(string file) // Abrir documentos em pdf
        {
            OpenPDF dest = new OpenPDF(file);
            dest.Show();
        }
        public string Datamysql(string data) // Transformar a data para um valor aceitável em MySQL
        {
            string dia, ano, mes, mysq;

            ano = data.Substring(6, 4);
            dia = data.Substring(0, 2);
            mes = data.Substring(3, 2);

            mysq = ano + '-' + mes + '-' + dia;

            return mysq;
        }

        string calculateDay(string category, int review, DateTime date, ClasseDB DB, int time) // Calcula o dia que será colocado a nova revisão.
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

                    MessageBox.Show("Entrou");

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

        private void OpenDocuments_Load(object sender, EventArgs e)
        {
            ClasseDB DB = new ClasseDB();

            DateTime today = DateTime.Today;

            string data = Datamysql(today.ToShortDateString());
            
            (Disciplinabox.Text, Arquivobox.Text, Categoriabox.Text, TempoRevisaobox.Text, Revisionbox.Text) = DB.ConnectDataBase(data, x);

            minutos = Convert.ToInt32(TempoRevisaobox.Text);

            Cronometro.Text = valueTimer(minutos, segundos);

            Concluded.Enabled = false;

            toolTip1.SetToolTip(Next, "Próxima atividade.");
            toolTip1.SetToolTip(Previous, "Atividade anterior.");
            toolTip1.SetToolTip(StartTime, "Iniciar atividade.");
            toolTip1.SetToolTip(OpenDoc, "Abrir arquivo.");
            toolTip1.SetToolTip(Concluded, "Finalizar atividade.");
            toolTip1.SetToolTip(Back, "Voltar para página principal.");
        }

        private void Next_Click(object sender, EventArgs e)
        {
            ClasseDB DB = new ClasseDB();

            DateTime today = DateTime.Today;

            string data = Datamysql(today.ToShortDateString());

            if (x < DB.CountData(data)-1)
            {
                x ++; // Avançar nos valores do banco somente quando existir.
            }

            (Disciplinabox.Text, Arquivobox.Text, Categoriabox.Text, TempoRevisaobox.Text, Revisionbox.Text) = DB.ConnectDataBase(data, x);

            minutos = Convert.ToInt32(TempoRevisaobox.Text);

            Cronometro.Text = valueTimer(Convert.ToInt32(TempoRevisaobox.Text),0);
            
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (x >= 1)
            x--;

            ClasseDB DB = new ClasseDB();

            DateTime today = DateTime.Today;

            string data = Datamysql(today.ToShortDateString());

            (Disciplinabox.Text, Arquivobox.Text, Categoriabox.Text, TempoRevisaobox.Text, Revisionbox.Text) = DB.ConnectDataBase(data, x);

            minutos = Convert.ToInt32(TempoRevisaobox.Text);

            Cronometro.Text = valueTimer(Convert.ToInt32(TempoRevisaobox.Text),0);

        }

        private void AbrirDocumento_Click(object sender, EventArgs e)
        {
            if (Arquivobox.Text == "" || Arquivobox.Text == "0" || Arquivobox.Text == "ERRO")
                MessageBox.Show("O caminho passado não é válido");
            else
            {
                if (Arquivobox.Text.EndsWith("doc"))
                    OpendocumentsWord(Arquivobox.Text);

                else if (Arquivobox.Text.EndsWith("pdf"))
                    Openpdf(Arquivobox.Text);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (segundos == 0 && minutos !=0)
            {
                minutos--;
                segundos = 59;
            }
            else if (segundos == 0 && minutos == 0)
            {
                timer1.Enabled = false;
                Concluded.Enabled = true;
                SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\rapha\Desktop\Projetos\Sons\alarmeincendio.wav");
                simpleSound.Play();
            }
            else
                segundos--;
            Cronometro.Text = valueTimer(minutos, segundos);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (TempoRevisaobox.Text == "0" || TempoRevisaobox.Text == "ERRO")
                MessageBox.Show("Nao é possível realizar a atividade !!");
            else
                timer1.Enabled = true;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ClasseDB DB = new ClasseDB();

            DB.ConcludedRevision(Disciplinabox.Text,Categoriabox.Text,Revisionbox.Text);

            DateTime today = DateTime.Today;

            string data = Datamysql(today.ToShortDateString());

            string dataatualizada = calculateDay(Categoriabox.Text, Convert.ToInt32(Revisionbox.Text)+1, today, DB, Convert.ToInt32(TempoRevisaobox.Text));

            DB.ChangedbyReview(Disciplinabox.Text, Categoriabox.Text, dataatualizada);

            (Disciplinabox.Text, Arquivobox.Text, Categoriabox.Text, TempoRevisaobox.Text, Revisionbox.Text) = DB.ConnectDataBase(data, x);

            this.Close();
            OpenDocuments Open = new OpenDocuments();
            Open.Show();

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Principal g = new Principal();
            g.Closed += (s, args) => this.Close();
            g.Show();
        }
    }
}
