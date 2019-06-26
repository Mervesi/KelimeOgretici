using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class WordDataAccess : IAccessRepo<Word>
    {
        //SqlConnection con;
        //SqlCommand cmd;
        //SqlDataReader dr;
        public int Create(Word arg)
        {
            string connectionString = @"Data Source=MERVE-PC\MERVE; Initial Catalog=KelimeOgretici;Integrated Security=True;MultipleActiveResultSets=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand();
                command.CommandText = "INSERT INTO Word (WordEnglish, WordTurkish, WordTypeID) VALUES ('" + arg.WordEnglish + "','" + arg.WordTurkish + "','" + arg.WordTypeID + "' )";
                command.Connection = connection;
                connection.Open();
                return command.ExecuteNonQuery();
            }

        }

        public void Delete(int arg)
        {
            string connectionString = @"Data Source=MERVE-PC\MERVE; Initial Catalog=KelimeOgretici;Integrated Security=True;MultipleActiveResultSets=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand();
                command.CommandText = "DELETE FROM Word Where WordID=" + arg;
                command.Connection = connection;
                connection.Open();

                int donen = command.ExecuteNonQuery();
                if (donen < 0)
                {
                    throw new ArgumentException();
                }
               
            }
        }
        public List<Word> GetAll()
        {
            List<Word> wordList = new List<Word>();
            string connectionString = @"Data Source=MERVE-PC\MERVE; Initial Catalog=KelimeOgretici;Integrated Security=True;MultipleActiveResultSets=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand();
                command.CommandText = "SELECT * FROM Word";
                command.Connection = connection;
                connection.Open();


                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Word wrd = new Word();
                        wrd.WordID = (int)reader["WordID"];
                        wrd.WordTurkish = (string)reader["WordTurkish"];
                        wrd.WordEnglish = (string)reader["WordEnglish"];
                        wrd.WordTypeID = (int)reader["WordTypeID"];
                        wordList.Add(wrd);

                    }
                }
                return wordList;
            }

        }

        public int Update(Word arg)
        {
            throw new NotImplementedException();
        }
        public List<DataAccessLayer.Type> GetTip()
        {
            List<Type> typeList = new List<Type>();
            string connectionString = @"Data Source=MERVE-PC\MERVE; Initial Catalog=KelimeOgretici;Integrated Security=True;MultipleActiveResultSets=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand();
                command.CommandText = "SELECT * FROM Type";
                command.Connection = connection;
                connection.Open();


                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DataAccessLayer.Type type = new DataAccessLayer.Type();
                        type.TypeID = (int)reader["TypeID"];
                        type.Type1 = (string)reader["Type"];
                        typeList.Add(type);
                    }
                }
                return typeList;
            }
        }
    }
}
