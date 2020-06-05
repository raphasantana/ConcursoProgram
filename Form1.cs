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
using Microsoft.Office.Interop.Word;
using System.IO;
using DataTable = System.Data.DataTable;

namespace Calendario2
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        void opendocumentsWord(string file) // Utiliza da integração o pacote office para abrir arquivos do word.
        {
            Microsoft.Office.Interop.Word.Application word = new Microsoft.Office.Interop.Word.Application();

            word.Visible = true;

            word.Documents.Open(file);
        }

        void ListinDataGrid(MySqlCommand comand, DataGridView grid) // Analisar o valores e listar no DataGridView
        {
            try
            {
                MySqlDataAdapter objnew = new MySqlDataAdapter(comand);

                DataTable dtlista = new DataTable();

                objnew.Fill(dtlista);

                grid.DataSource = dtlista;
            }
            catch(Exception E)
            {
                MessageBox.Show(E.ToString());
            }
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();// Esconder a tela atual, se fechar essa tela, o programa para a execução

            Form Adicionar = new Adicionar();// Criação do novo form

            Adicionar.Show(); // Mostrar o novo form criado.
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ClasseDB DB = new ClasseDB();
            
            string oi=System.Windows.Forms.Application.OpenForms.Count.ToString(); // Analisar quantas telas foram abertas - Consumir pouca memória

            if (Convert.ToInt32(oi) >= 25)
            {
                MessageBox.Show("Fechando o aplicativo para garantir o salvamento de todos os dados com sucesso. Se necessário pode abrir novamente.");
               
                System.Windows.Forms.Application.Exit(); // Fechar aplicação
            }
            else
            {
                string data1;
                string[] marcar;
                int[] rev;

                (marcar, rev,data1) = DB.BoldedDates(); // Executa o método da ClassDB.

                    DateTime[] negrito = new DateTime[Convert.ToInt32(data1)];

                    for (int i = 1; i <= Convert.ToInt32(data1); i++)
                    {
                        negrito[i - 1] = Convert.ToDateTime(marcar[i - 1]);
                    }

                    monthCalendar1.BoldedDates = negrito; // Marcar no calendário as datas em negrito as datas com revisão.
             }

            toolTip1.SetToolTip(Scheduling, "Salvar novo Resumo.");// Tooltip - Mensagem de texto que é mostrado quando o mouse é colocado em cima do botão.
            toolTip1.SetToolTip(Filter, "Selecione um intervalo de Datas e Filtre.");
            toolTip1.SetToolTip(Fechar, "Fechar o programa");
            toolTip1.SetToolTip(Scheduling, "Salvar novo Resumo");
            toolTip1.SetToolTip(StartRevision, "Iniciar revisão diaria");
        }
   
        private void Fechar_Click_1(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();// Parar a execução do programa.
        }

        private void Filter_Click_1(object sender, EventArgs e)
        {
            string strinit, strend;
            DateTime initial, end;

            initial = monthCalendar1.SelectionRange.Start;// Propriedade que captura o valor selecionado no calendário
            end = monthCalendar1.SelectionRange.End;

            strinit = initial.ToString("yyyy-MM-dd");// Transformar a data em uma string na forma do Mysql.
            strend = end.ToString("yyyy-MM-dd");

            const string conectabanco = "server=localhost;port=3306;User Id = root; database=calendario;password=vertrigo;";

            MySqlConnection conexao = null;
            MySqlCommand comando;
            try
            {

                conexao = new MySqlConnection(conectabanco);
                comando = new MySqlCommand("SELECT * FROM concurso WHERE DataRevisao BETWEEN '" + strinit + "' AND '" + strend + "' ", conexao); // Filtrar valores entre as datas selecionadas.

                conexao.Open();

                ListinDataGrid(comando, dataGridView1);

                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.ToString());
            }
        }

        private void StartRevision_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new OpenDocuments();
            form.Show();
        }
    }
}

