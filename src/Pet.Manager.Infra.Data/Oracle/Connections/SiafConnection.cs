using System.Data;

using Microsoft.Extensions.Configuration;

using Oracle.ManagedDataAccess.Client;

namespace Anima.Inscricao.Infra.Data.Oracle.Connections;

public sealed class SiafConnection
{
    private readonly string _connectionString;

    public SiafConnection(IConfiguration configuration)
    {
        _connectionString = configuration.GetConnectionString("SiafDatabase")
            ?? throw new ArgumentException("Conexão Siaf não encontrada.");
    }

    public IDbConnection ObterConexao()
    {
        var conexao = new OracleConnection(_connectionString);
        conexao.Open();
        return conexao;
    }
}