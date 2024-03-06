using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula03.models;
using Dapper;
using Microsoft.Data.Sqlite;

namespace Aula03.daos;

public class ContatoDAO
{
    public void Inserir(Contato obj)
    {
        //if (obj.Id == null || obj.Id.Trim().Equals(""))
        if (string.IsNullOrWhiteSpace(obj.Id))
            obj.Id = Guid.NewGuid().ToString();

        using(var conexao = new SqliteConnection("Data Source=db/dados.db"))
        {
            conexao.Open();
            
            const string sql =  "INSERT INTO contato" +
                                " (id, nome, email)" +
                                " VALUES (@Id, @Nome, @Email)";

            conexao.Execute(sql, obj);
        }
    }

    public void Alterar(Contato obj)
    {
        using(var conexao = new SqliteConnection("Data Source=db/dados.db"))
        {
            conexao.Open();
            
            const string sql = "UPDATE contato" +
                " SET nome = @Nome, email = @Email" +
                " WHERE id = @Id";

            conexao.Execute(sql, obj);
        }
    }

    public void Excluir(string id)
    {
        using(var conexao = new SqliteConnection("Data Source=db/dados.db"))
        {
            conexao.Open();
            
            const string sql = "DELETE FROM contato WHERE id = @Id";
  
            conexao.Execute(sql, new { Id = id });
        }
    }

    public IList<Contato> RetornarTodos()
    {
        using(var conexao = new SqliteConnection("Data Source=db/dados.db"))
        {
            conexao.Open();
            
            const string sql = "SELECT * FROM contato" +
                " ORDER BY nome";

            var objetos = conexao.Query<Contato>(sql);

            return objetos.ToList();
        }
    }

    public Contato RetornarPorId(string id)
    {
        using(var conexao = new SqliteConnection("Data Source=db/dados.db"))
        {
            conexao.Open();
            
            const string sql = "SELECT * FROM contato WHERE id = @Id";

            var obj = conexao.QuerySingle<Contato>(sql, new { Id = id });

            return obj;
        }
    }
}