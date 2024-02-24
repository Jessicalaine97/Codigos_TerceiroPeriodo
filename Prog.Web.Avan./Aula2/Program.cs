using Microsoft.Data.Sqlite;

using (var conexao = new SqliteConnection(@"Data Source=db/dados.db"))
{
    conexao.Open();

    var cmd = conexao.CreateCommand();
    /*
    cmd.CommandText="SELECT * FROM contato";
    var dr = cmd.ExecuteReader();

    while (dr.Read())
    {
        Console.WriteLine($"{dr["nome"]}: {dr["gmail"]}");
    }
    dr.Close();*/

    /*var cmd = conexao.CreateCommand();*/

    /*cmd.CommandText = "INSERT INTO contato(id, nome, gmail)" + 
                      "VALUES (@id, @nome, @gmail)";
    cmd.Parameters.AddWithValue("@id", 4);
    cmd.Parameters.AddWithValue("@nome", "Daniel");
    cmd.Parameters.AddWithValue("@gmail", "daniel@gmail.com");*/

    cmd.CommandText = "UPDATE contato SET nome=@nome, gmail=@gmail WHERE id=@id";
    cmd.Parameters.AddWithValue("@nome", "Daniel da Silva");
    cmd.Parameters.AddWithValue("@id", 4);
    cmd.Parameters.AddWithValue("@gmail", "daniel@gmail.com");

    /*cmd.CommandText = "DELETE from contato where id=@id";
    cmd.Parameters.AddWithValue("@id", "3");*/

    cmd.ExecuteNonQuery();
    conexao.Close(); //vai ser automatico se usar o using
}

