using Dapper;
using Microsoft.Data.Sqlite;
//using Teste;

/*var obj = new Contato
{
    Id = "5",
    Nome = "Zé",
    Gmail = "ze@email.com"
};

//Reflection

var tipo = obj.GetType();
Console.WriteLine(tipo.FullName);

//imprimindo todas as propriedades do objeto
foreach (var prop in tipo.GetProperties())
{
    Console.WriteLine($"{prop.Name}: {prop.GetValue(obj)}");
}*/

/*
//imprimindo so uma propriedade do objeto
var prop = tipo.GetProperty("Id");

if (prop != null)
{
    Console.WriteLine($"{prop.Name}: {prop.GetValue(obj)}");
}
*/

using (var conexao = new SqliteConnection(@"Data Source=db/dados.db"))
{
    conexao.Open();

    var obj = new Contato{
        Id="5",
        Nome="Jessica",
        Gmail = "jessica@gmail.com"
    };

    const string sql = "INSERT INTO contato (id, nome, gmail) VALUES (@Id, @Nome, @Gmail)";
    conexao.Execute(sql, obj);
}

