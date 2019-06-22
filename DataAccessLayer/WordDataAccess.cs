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
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public int Create(Word arg)
        {
            throw new NotImplementedException();
        }

        public void Delete(int arg)
        {
            throw new NotImplementedException();
        }

        public List<Word> GetAll()
        {
            List<Word> wordList = new List<Word>();
            string connectionString = @"Data Source=MERVE-PC\MERVE; Initial Catalog=KelimeOgretici;Integrated Security=True;MultipleActiveResultSets=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand();
                command.CommandText = "SELECT * FROM Words";
                command.Connection = connection;
                connection.Open();

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Word wrd = new Word();
                        wrd.WordID = (int)reader["WordID"];
                        wrd.Turkish = (string)reader["Turkish"];
                        wrd.English = (string)reader["English"];
                        wordList.Add(wrd);

                    }
                }
                return wordList;
            }

        public int Update(Word arg)
        {
            throw new NotImplementedException();
        }
    }
}
