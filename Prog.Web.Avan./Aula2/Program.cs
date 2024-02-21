using Microsoft.Data.Sqlite;

using (var conexao = new SqliteConnection(@"Data Source=db/dados.db"))
{
    conexao.Open();

    //conexao.Close(); vai ser automaticco se usar o using
}

