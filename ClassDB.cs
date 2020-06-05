using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Calendario2
{
    class ClasseDB
    {
        private const string conectabanco = "server=localhost;port=3306;User Id = root; database=calendario;password=vertrigo;";
        private MySqlConnection con = null;
        private MySqlCommand command, command2;

        public ClasseDB()
        {

        }

        public string teste(int c)
        {
            return Convert.ToString(c);
        }
        public (string[], int[], string) BoldedDates()
        {
            string data1;
            try
            {

                con = new MySqlConnection(conectabanco);
                command = new MySqlCommand("SELECT count(Data) FROM concurso", con);

                con.Open();
                command.Parameters.Clear();

                MySqlDataReader Leitura;

                Leitura = command.ExecuteReader();

                Leitura.Read();

                data1 = Leitura.GetString(0);

                Leitura.Close();

                string[] marcar = new string[Convert.ToInt32(data1)];
                int[] rev = new int[Convert.ToInt32(data1)];

                for (int i = 1; i <= Convert.ToInt32(data1); i++)
                {
                    command = new MySqlCommand("SELECT DataRevisao FROM concurso WHERE Id = ?", con);
                    command.Parameters.Clear();
                    command.Parameters.Add("@Id", MySqlDbType.Int32).Value = i;

                    Leitura = command.ExecuteReader();
                    Leitura.Read();

                    marcar[i - 1] = Leitura.GetString(0);
                    Leitura.Close();
                }

                con.Close();
                return (marcar, rev, data1);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public (string, int) SaveData(string name, string path, string category, string date, string rev, int time, string datereview)
        {
            try
            {
                con = new MySqlConnection(conectabanco);
                command = new MySqlCommand("INSERT INTO Concurso(NomedaDisciplina,Arquivo,Categoria,Data,Revisao,Tempo,DataRevisao) values(?,?,?,?,?,?,?)", con);

                con.Open();

                command.Parameters.Add("@NomedaDisciplina", MySqlDbType.VarChar).Value = name;
                command.Parameters.Add("@Arquivo", MySqlDbType.Text).Value = path;
                command.Parameters.Add("@Categoria", MySqlDbType.VarChar).Value = category;
                command.Parameters.Add("@Data", MySqlDbType.Date).Value = date;
                command.Parameters.Add("@Revisao", MySqlDbType.Int32).Value = Convert.ToInt32(rev);
                command.Parameters.Add("@Tempo", MySqlDbType.Int32).Value = time;
                command.Parameters.Add("@DataRevisao", MySqlDbType.Date).Value = datereview;

                command.ExecuteNonQuery();

                con.Close();
                return ("Salvo com sucesso", 1);
            }
            catch (Exception erro)
            {
                return (Convert.ToString(erro), 0);
            }
        }

        public int catchDB(DateTime date, string category)
        {
            string datedb = date.ToString("yyyy-MM-dd");

            int result;

            MySqlConnection con = null;

            MySqlCommand command, command2;

            con = new MySqlConnection(conectabanco);

            command = new MySqlCommand("SELECT SUM(Tempo) FROM `concurso` WHERE Categoria = '" + category + "' AND DataRevisao = '" + datedb + "'", con);

            command2 = new MySqlCommand("SELECT count(DataRevisao) FROM concurso WHERE Categoria = '" + category + "' AND DataRevisao = '" + datedb + "'", con);

            con.Open();

            MySqlDataReader Reader1, Reader2;

            Reader2 = command2.ExecuteReader();
            Reader2.Read();
            string valid = Reader2.GetString(0);
            Reader2.Close();
            if (Convert.ToInt32(valid) > 0)
            {
                Reader1 = command.ExecuteReader();

                Reader1.Read();

                result = Convert.ToInt32(Reader1.GetString(0));

                Reader1.Close();
                return result;
            }
            else
                return 0;

        }

        public int CountData(string Data)
        {
            try
            {
                con = new MySqlConnection(conectabanco);
                command2 = new MySqlCommand("SELECT count(Data) FROM concurso where DataRevisao='" + Data + "'", con);
                con.Open();

                MySqlDataReader Reader;

                Reader = command2.ExecuteReader();
                Reader.Read();

                string v = Reader.GetString(0);

                return Convert.ToInt32(v);
            }
            catch (Exception Erro)
            {
                MessageBox.Show(Convert.ToString(Erro));
                return 0;

            }
        }

        public (string, string, string, string,string) ConnectDataBase(string Data, int nextresult)
        {

            string name, path, cate, time,revision;
            name = "0"; path = "0"; cate = "0"; time = "0";

            try
            {

                con = new MySqlConnection(conectabanco);
                command2 = new MySqlCommand("SELECT count(Data) FROM concurso where DataRevisao='" + Data + "'", con);
                command = new MySqlCommand("SELECT * FROM concurso where DataRevisao='" + Data + "'", con);

                con.Open();

                MySqlDataReader Reader1, Reader2;

                Reader2 = command2.ExecuteReader();
                Reader2.Read();

                string v = Reader2.GetString(0);
                int tam = Convert.ToInt32(v);
                string[] namestr, pathstr, catestr, timestr,revistr;
                namestr = new string[tam];
                pathstr = new string[tam];
                catestr = new string[tam];
                timestr = new string[tam];
                revistr = new string[tam];
                Reader2.Close();
                Reader1 = command.ExecuteReader();
                int valid = Convert.ToInt32(v) - nextresult;
                if (Convert.ToInt32(valid) > 0)
                {
                    while (Reader1.HasRows)
                    {
                        int aux = 0;

                        while (Reader1.Read())
                        {
                            namestr[aux] = Reader1.GetString(0);
                            pathstr[aux] = Reader1.GetString(1);
                            catestr[aux] = Reader1.GetString(2);
                            revistr[aux] = Reader1.GetString(5);
                            timestr[aux] = Reader1.GetString(6);

                            aux++;
                        }
                        Reader1.NextResult();
                    }
                    name = namestr[nextresult];
                    path = pathstr[nextresult];
                    cate = catestr[nextresult];
                    time = timestr[nextresult];
                    revision = revistr[nextresult];
                }
                else
                {
                    name = "0"; path = "0"; cate = "0"; time = "0";revision="0";

                }
            }
            catch (Exception erro)
            {
                name = "ERRO"; path = "ERRO"; cate = "ERRO"; time = "ERRO";revision = "ERRO" ;
                MessageBox.Show(Convert.ToString(erro));
            }
            return (name, path, cate, time, revision);

        }

        public void ConcludedRevision(string name, string Category, string revision)
        {
            int rev = Convert.ToInt32(revision);
            MessageBox.Show(Convert.ToString(rev));
            rev = rev + 1;

            try
            {
                con = new MySqlConnection(conectabanco);
                command = new MySqlCommand("UPDATE concurso set Revisao = '" + rev + "' where NomedaDisciplina='" + name + "' and Categoria = '" + Category + "' ", con);

                con.Open();
                command.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception Erro)
            {
                MessageBox.Show(Convert.ToString(Erro));
            }
        }

        public void ChangedbyReview(string name, string Category, string date)
        {
            try
            {
                con = new MySqlConnection(conectabanco);
                command = new MySqlCommand("UPDATE concurso set DataRevisao = '" + date + "' where NomedaDisciplina='" + name + "' and Categoria = '" + Category + "' ", con);

                con.Open();
                command.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception Erro)
            {
                MessageBox.Show(Convert.ToString(Erro));
            }


        }
    }
}
