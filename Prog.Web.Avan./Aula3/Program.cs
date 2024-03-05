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

/*aula que faltei
/* USANDO DAPPER */ 
// INSERT
// using (var conexao = new SqliteConnection("DataSource=db/dados.db"))
// {
//     conexao.Open();

//     var obj = new Contato{
//         Id = "5",
//         Nome = "Cláudia",
//         Email = "claudinho_almeida@hotmail.com"
//     };

//     const string sql = "insert into contato" + "(id, nome, email)" + "values (@Id, @Nome, @Email)";

//     conexao.Execute(sql, obj);
// }
// UPDATE
//     const string sql = "update contato set nome=@Nome, email=@Email where id=@Id";
// DELETE
//     const string sql = "delete from contato where id=@Id";


// using (var conexao = new SqliteConnection("DataSource=db/dados.db")){
//     conexao.Open();

    // QUERY DE LINHAS MÚLTIPLAS
    // const string sql = "select * from contato where nome like @parteNome order by nome";

    // var objetos = conexao.Query<Contato>(sql, new { parteNome = "%a%"});

    // foreach (var item in objetos)
    // {
    //     Console.WriteLine($"{item.Nome} - {item.Email}");
    // }

    // QUERY DE LINHA ÚNICA
//     const string sql = "select * from contato where id = @Id";

//     var obj = conexao.QuerySingle<Contato>(sql, new { Id = 1 });

//     Console.WriteLine($"{obj.Nome} - {obj.Email}");

// }
//

