using Anima.Inscricao.Domain.Campos.Entities;

namespace Anima.Inscricao.Test._Shared.Constants;

public static class CampoConstants
{
    public static readonly Campo CPF =
       Campo.Criar("CPF")
       .ObterRetorno() ?? throw new ArgumentException("Erro ao criar o campo CPF");

    public static readonly Campo Nome =
       Campo.Criar("Nome")
       .ObterRetorno() ?? throw new ArgumentException("Erro ao criar o campo Nome");

    public static readonly Campo Email =
        Campo.Criar("E-mail")
        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar o campo E-mail");

    public static readonly Campo Acessibilidade =
        Campo.Criar("Acessibilidade")
        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar o campo Acessibilidade");

    public static readonly Campo ComprovanteAcessibilidade =
        Campo.Criar("Comprovante de Acessibilidade")
        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar o campo Comprovante de Acessibilidade");

    public static readonly Campo TelefoneCelular =
        Campo.Criar("Telefone Celular")
        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar o campo Telefone Celular");

    public static readonly Campo TelefoneFixo =
        Campo.Criar("Telefone Fixo")
        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar o campo Telefone Fixo");

    public static readonly Campo TelefoneComercial =
        Campo.Criar("Telefone Comercial")
        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar o campo Telefone Comercial");

    public static readonly Campo TelefoneContato =
        Campo.Criar("Telefone Contato")
        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar o campo Telefone Contato");

    public static readonly Campo Deficiencia =
        Campo.Criar("Deficiência")
        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar o campo Deficiência");

    public static readonly Campo ComprovanteDeficiencia =
        Campo.Criar("Comprovante de Deficiência")
        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar o campo Comprovante de Deficiência");

    public static readonly Campo CertificadoEnsinoMedio =
        Campo.Criar("Certificado Ensino Médio")
        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar o campo Certificado Ensino Médio");

    public static readonly Campo ComprovanteResidencia =
        Campo.Criar("Comprovante de Residência")
        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar o campo Comprovante de Residência");

    public static readonly Campo ComprovanteRenda =
        Campo.Criar("Comprovante de Renda")
        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar o campo Comprovante de Renda");

    public static readonly Campo RG =
        Campo.Criar("RG")
        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar o campo RG");

    public static readonly Campo CNH =
        Campo.Criar("CNH")
        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar o campo CNH");

    public static readonly Campo EnderecoResidencialRua =
        Campo.Criar("Endereço Residencial (Rua)")
        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar o campo Endereço Residencial (Rua)");

    public static readonly Campo EnderecoResidencialNumero =
        Campo.Criar("Endereço Residencial (Número)")
        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar o campo Endereço Residencial (Número)");

    public static readonly Campo EnderecoResidencialCep =
        Campo.Criar("Endereço Residencial (Cep)")
        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar o campo Endereço Residencial (Cep)");

    public static readonly Campo EnderecoResidencialComplemento =
        Campo.Criar("Endereço Residencial (Complemento)")
        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar o campo Endereço Residencial (Complemento)");

    public static readonly Campo EnderecoResidencialBairro =
        Campo.Criar("Endereço Residencial (Bairro)")
        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar o campo Endereço Residencial (Bairro)");

    public static readonly Campo EnderecoResidencialCidade =
        Campo.Criar("Endereço Residencial (Cidade)")
        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar o campo Endereço Residencial (Cidade)");

    public static readonly Campo EnderecoResidencialEstado =
        Campo.Criar("Endereço Residencial (Estado)")
        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar o campo Endereço Residencial (Estado)");

    public static readonly Campo EnderecoCobrancaRua =
        Campo.Criar("Endereço Cobrança (Rua)")
        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar o campo Endereço Cobrança (Rua)");

    public static readonly Campo EnderecoCobrancaNumero =
        Campo.Criar("Endereço Cobrança (Número)")
        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar o campo Endereço Cobrança (Número)");

    public static readonly Campo EnderecoCobrancaCep =
        Campo.Criar("Endereço Cobrança (Cep)")
        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar o campo Endereço Cobrança (Cep)");

    public static readonly Campo EnderecoCobrancaComplemento =
        Campo.Criar("Endereço Cobrança (Complemento)")
        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar o campo Endereço Cobrança (Complemento)");

    public static readonly Campo EnderecoCobrancaBairro =
        Campo.Criar("Endereço Cobrança (Bairro)")
        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar o campo Endereço Cobrança (Bairro)");

    public static readonly Campo EnderecoCobrancaCidade =
        Campo.Criar("Endereço Cobrança (Cidade)")
        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar o campo Endereço Cobrança (Cidade)");

    public static readonly Campo EnderecoCobrancaEstado =
        Campo.Criar("Endereço Cobrança (Estado)")
        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar o campo Endereço Cobrança (Estado)");

    public static readonly Campo EnderecoComercialRua =
        Campo.Criar("Endereço Comercial (Rua)")
        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar o campo Endereço Comercial (Rua)");

    public static readonly Campo EnderecoComercialNumero =
        Campo.Criar("Endereço Comercial (Número)")
        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar o campo Endereço Comercial (Número)");

    public static readonly Campo EnderecoComercialCep =
        Campo.Criar("Endereço Comercial (Cep)")
        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar o campo Endereço Comercial (Cep)");

    public static readonly Campo EnderecoComercialComplemento =
        Campo.Criar("Endereço Comercial (Complemento)")
        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar o campo Endereço Comercial (Complemento)");

    public static readonly Campo EnderecoComercialBairro =
        Campo.Criar("Endereço Comercial (Bairro)")
        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar o campo Endereço Comercial (Bairro)");

    public static readonly Campo EnderecoComercialCidade =
        Campo.Criar("Endereço Comercial (Cidade)")
        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar o campo Endereço Comercial (Cidade)");

    public static readonly Campo EnderecoComercialEstado =
        Campo.Criar("Endereço Comercial (Estado)")
        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar o campo Endereço Comercial (Estado)");

    public static readonly Campo AnoConclusaoEM =
        Campo.Criar("Ano de Conclusão do Ensino Médio")
        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar o campo Ano de Conclusão do Ensino Médio");
    
    public static readonly Campo EstadoEscolaEM =
        Campo.Criar("Estado da escola do Ensino Médio")
        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar o campo Estado da escola do Ensino Médio");
    
    public static readonly Campo CidadeEscolaEM =
        Campo.Criar("Cidade da escola do Ensino Médio")
        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar o campo Cidade da escola do Ensino Médio");
    
    public static readonly Campo EscolaEM =
        Campo.Criar("Escola do Ensino Médio")
        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar o campo Escola do Ensino Médio");
    
    public static readonly Campo DataNascimento =
        Campo.Criar("Data de Nascimento")
        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar o campo Data de Nascimento");
    
    public static readonly Campo Sexo =
        Campo.Criar("Sexo")
        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar o campo Sexo");
    
    public static readonly Campo NecessidadeEspecial =
        Campo.Criar("Necessidade Especial")
        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar o campo Necessidade Especial");
    
    public static readonly Campo NomeSocial =
        Campo.Criar("Nome Social")
        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar o campo Nome Social");
    
    public static readonly Campo Cupom =
        Campo.Criar("Cupom")
        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar o campo Cupom");

    public static readonly Campo Oferta =
        Campo.Criar("Oferta")
        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar o campo Oferta");
    
    public static readonly Campo OfertaConcurso =
        Campo.Criar("Oferta-Concurso")
        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar o campo Oferta-Concurso");
    
    public static readonly Campo Origem =
        Campo.Criar("Origem")
        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar o campo Origem");
    
    public static readonly Campo Marca =
        Campo.Criar("Marca")
        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar o campo Marca");
    
    public static readonly Campo Ficha =
        Campo.Criar("Ficha")
        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar o campo Ficha");
    
    public static readonly Campo NomeFiador =
        Campo.Criar("Nome Fiador")
        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar o campo Nome Fiador");
    
    public static readonly Campo RelacionamentoFiador =
        Campo.Criar("Relacionamento Fiador")
        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar o campo Relacionamento Fiador");
    
    public static readonly Campo PercentualFiador =
        Campo.Criar("Percentual Fiador")
        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar o campo Percentual Fiador");
    
    public static readonly Campo RendaMediaMensalFiador =
        Campo.Criar("Renda Média Mensal Fiador")
        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar o campo Renda Média Mensal Fiador");

    public static readonly Campo DocumentoFiador =
        Campo.Criar("Documento Fiador")
        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar o campo Documento Fiador");

    public static readonly Campo ContatoFiador =
        Campo.Criar("Contato Fiador")
        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar o campo Contato Fiador");

    public static readonly Campo FormaEntrada =
        Campo.Criar("Forma de entrada")
        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar o campo Forma de entrada");
}