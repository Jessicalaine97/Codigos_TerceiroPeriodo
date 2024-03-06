
/*
using Dapper;
using Microsoft.Data.Sqlite;

using(var conexao = new SqliteConnection("Data Source=db/dados.db"))
{
    conexao.Open();

    
    var obj = new Contato
    {
        Id = "5",
        Nome = "José",
        Email = "jose@email.com"
    };
    
    const string sql =  "INSERT INTO contato" + 
                        " (id, nome, email)" + 
                        " VALUES (@Id, @Nome, @Email)";
    const string sql = "UPDATE contato" + 
            " SET nome = @Nome, email = @Email" + 
            " WHERE id = @Id";
    const string sql = "DELETE FROM contato WHERE id = @Id";
    
    const string sql = "SELECT * FROM contato WHERE id = @Id";
    var obj = conexao.QuerySingle<Contato>(sql, new { Id = 1 });

    Console.WriteLine($"{obj.Nome} - {obj.Email}");


    const string sql = "SELECT * FROM contato ORDER BY nome";
    const string sql = "SELECT * FROM contato" + 
        " WHERE nome LIKE @ParteNome" + 
        " ORDER BY nome";

    var objetos = conexao.Query<Contato>(sql, new { ParteNome = "%n%"});
    var objetos = conexao.Query<Contato>(sql);

    foreach (var obj in objetos)
        Console.WriteLine($"{obj.Nome} - {obj.Email}");
    conexao.Execute(sql, new { Id = "3" });
    conexao.Execute(sql, obj);
}
*/

/*
var obj = new Contato
{
    Id = "5",
    Nome = "Zé",
    Email = "ze@email.com"
};

//Reflection

var tipo = obj.GetType();
Console.WriteLine(tipo.FullName);

foreach (var prop in tipo.GetProperties())
{
    Console.WriteLine($"{prop.Name}: {prop.GetValue(obj)}");
}
*/

/*
var prop = tipo.GetProperty("Id");

if (prop != null)
{
    Console.WriteLine($"{prop.Name}: {prop.GetValue(obj)}");
}
*/


/*
using(var conexao = new SqliteConnection("Data Source=db/dados.db"))
{
    conexao.Open();

    var obj = new Contato
    {
        Id = "5",
        Nome = "Zé",
        Email = "ze@email.com"
    };

    const string sql =  "INSERT INTO contato" + 
                        " (id, nome, email)" + 
                        " VALUES (@Id, @Nome, @Email)";
    
    conexao.Execute(sql, obj);
}
*/























/*
using(var conexao = new SqliteConnection("Data Source=db/dados.db"))
{
    conexao.Open();

    var cmd = conexao.CreateCommand();
    
    cmd.CommandText = "INSERT INTO contato" + 
                      " (id, nome, email)" + 
                      " VALUES (@id, @nome, @email)";
    cmd.CommandText = "UPDATE contato" + 
        " SET nome=@nome, email=@email WHERE id=@id";
    cmd.CommandText = "DELETE FROM contato WHERE id=@id";
    cmd.Parameters.AddWithValue("@id", 4);
    cmd.Parameters.AddWithValue("@nome", "Daniel da Silva");
    cmd.Parameters.AddWithValue("@email", 
                               "daniel@email.com");
    cmd.ExecuteNonQuery();
}
*/