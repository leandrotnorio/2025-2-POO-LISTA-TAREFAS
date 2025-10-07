
using MySql.Data.MySqlClient;

public class Operacoes
{
    private string connectionString = "";
    public int Criar(Tarefa tarefa)
    {
        using (var conexao = new MySqlConnection(connectionString))
        {
            conexao.Open();
            string sql = @"INSERT INTO tarefa (nome, descricao, dataCriacao, status, dataExecucao)
                           VALUES(@nome, @descricao, @dataCriacao, @status, @dataExecucao);
                           SELECT LAST_INSERT_ID();";
            using (var cmd = new MySqlCommand(sql, conexao))
            {
                cmd.Parameters.AddWithValue("@nome", tarefa.Nome);
                cmd.Parameters.AddWithValue("@descricao", tarefa.Descricao);
                cmd.Parameters.AddWithValue("@dataCriacao", tarefa.DataCriacao);
                cmd.Parameters.AddWithValue("@status", tarefa.Status);
                cmd.Parameters.AddWithValue("@dataExecucao", tarefa.dataExecucao);

                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }
    }
    
    public Tarefa Buscar(int id)
    {
        // Implementação futura
        return null;
    }
    public IList<Tarefa> Listar()
    {
        // Implementação futura
        return Array.Empty<Tarefa>();
    }
    public void Alterar(Tarefa tarefa)
    {
        // Implementação futura
    }
    public void Excluir(int id)
    {
        // Implementação futura
    }
}