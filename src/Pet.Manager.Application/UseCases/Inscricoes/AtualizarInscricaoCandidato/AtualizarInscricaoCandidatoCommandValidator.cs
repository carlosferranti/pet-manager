using Anima.Inscricao.Application._Shared.Validations;
using Anima.Inscricao.Application.Utils;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Acessibilidades;
using Anima.Inscricao.Domain.CursosExternos;
using Anima.Inscricao.Domain.Deficiencias;
using Anima.Inscricao.Domain.Empresas;
using Anima.Inscricao.Domain.Enderecos;
using Anima.Inscricao.Domain.Escolas;
using Anima.Inscricao.Domain.Etapas;
using Anima.Inscricao.Domain.Fichas;
using Anima.Inscricao.Domain.FormasEntrada;
using Anima.Inscricao.Domain.Inscricoes.Enums;
using Anima.Inscricao.Domain.OfertaConcursos;
using Anima.Inscricao.Domain.Ofertas;
using Anima.Inscricoes.Domain.Inscricoes;

using FluentValidation;

namespace Anima.Inscricao.Application.UseCases.Inscricoes.AtualizarInscricaoCandidato;

public class AtualizarInscricaoCandidatoCommandValidator : ApplicationRequestValidator<AtualizarInscricaoCandidatoCommand>
{
    private const int LimiteCaracteresNome = 100;
    private const int LimiteCaracteresValor = 100;
    private const int LimiteCaracteresEndereco = 150;
    private const int LimiteCaracteresCep = 50;
    private const int LimiteCaracteresCupom = 100;
    private const int LimiteOutraEmpresa = 200;

    private readonly IFichaRepository _fichaRepository;
    private readonly IEstadoRepository _estadoRepository;
    private readonly ICidadeRepository _cidadeRepository;
    private readonly IEscolaRepository _escolaRepository;
    private readonly IOfertaConcursoRepository _ofertaConcursoRepository;
    private readonly IOfertaRepository _ofertaRepository;
    private readonly IAcessibilidadeRepository _acessibilidadeRepository;
    private readonly IDeficienciaRepository _deficienciaRepository;
    private readonly IEtapaTemplateRepository _etapaTemplateRepository;
    private readonly IInscricaoRepository _inscricaoRepository;
    private readonly IFormaEntradaRepository _formaEntradaRepository;
    private readonly IOfertaConcursoOpcaoAcessoRepository _ofertaConcursoOpcaoAcessoRepository;
    private readonly IEmpresaRepository _empresaRepository;
    private readonly ICursoExternoRepository _cursoExternoRepository;

    public AtualizarInscricaoCandidatoCommandValidator(
        INotificationContext notificationContext,
        IFichaRepository fichaRepository,
        IOfertaRepository ofertaRepository,
        IOfertaConcursoRepository ofertaConcursoRepository,
        IEstadoRepository estadoRepository,
        ICidadeRepository cidadeRepository,
        IEscolaRepository escolaRepository,
        IDeficienciaRepository deficienciaRepository,
        IAcessibilidadeRepository acessibilidadeRepository,
        IEtapaTemplateRepository etapaTemplateRepository,
        IInscricaoRepository inscricaoRepository,
        IFormaEntradaRepository formaEntradaRepository,
        IOfertaConcursoOpcaoAcessoRepository ofertaConcursoOpcaoAcessoRepository,
        IEmpresaRepository empresaRepository,
        ICursoExternoRepository cursoExternoRepository)
        : base(notificationContext)
    {
        _fichaRepository = fichaRepository;
        _estadoRepository = estadoRepository;
        _cidadeRepository = cidadeRepository;
        _escolaRepository = escolaRepository;
        _ofertaConcursoRepository = ofertaConcursoRepository;
        _ofertaRepository = ofertaRepository;
        _acessibilidadeRepository = acessibilidadeRepository;
        _deficienciaRepository = deficienciaRepository;
        _etapaTemplateRepository = etapaTemplateRepository;
        _inscricaoRepository = inscricaoRepository;
        _formaEntradaRepository = formaEntradaRepository;
        _ofertaConcursoOpcaoAcessoRepository = ofertaConcursoOpcaoAcessoRepository;
        _cursoExternoRepository = cursoExternoRepository;
        _empresaRepository = empresaRepository;

        RuleFor(x => x.InscricaoKey)
            .NotEmpty()
                .WithMessage("A chave da inscrição é obrigatória.")
            .MustAsync(ValidarInscricaoExistenteAsync)
                .WithMessage("Inscrição não encontrada.");

        #region Validaçoes de InfosFicha
        When(x => x.InfosFicha != null, () =>
        {
            RuleFor(x => x.InfosFicha!.FichaKey)
            .NotEmpty()
                .WithMessage("A chave da ficha é obrigatória.")
            .MustAsync(ValidarFichaExistenteAsync)
                .WithMessage("Ficha de inscrição não encontrada.");

            RuleFor(x => x.InfosFicha!.EtapaKey)
            .NotEmpty()
                .WithMessage("A chave da etapa é obrigatória.")
            .MustAsync(ValidarEtapaExistenteAsync)
                .WithMessage("Etapa da inscrição não encontrada.");
        });
        #endregion

        #region Validações de InfosPessoais
        When(x => x.InfosPessoais != null, () =>
        {
            RuleFor(x => x.InfosPessoais!.Nome)
            .MaximumLength(LimiteCaracteresNome)
                .WithMessage("O nome do candidato deve ter no máximo {MaxLength} caracteres.")
            .When(x => !string.IsNullOrWhiteSpace(x.InfosPessoais!.Nome));

            RuleFor(x => x.InfosPessoais!.NomeSocial)
            .MaximumLength(LimiteCaracteresNome)
                .WithMessage("O nome social do candidato deve ter no máximo {MaxLength} caracteres.")
            .When(x => !string.IsNullOrWhiteSpace(x.InfosPessoais!.NomeSocial));

            RuleFor(x => x.InfosPessoais!.Sexo)
            .Must(x => x.Equals(1) || x.Equals(2))
                .WithMessage("Sexo do candidato inválido.")
            .When(x => x.InfosPessoais!.Sexo != null);

            RuleFor(x => x.InfosPessoais!.DataNascimento)
            .GreaterThan(DateTime.MinValue)
                .WithMessage("Data de nascimento do candidato inválida.")
            .When(x => x.InfosPessoais!.DataNascimento.HasValue);
        });
        #endregion

        #region Validações de InfosOferta
        When(x => x.InfosOferta != null, () =>
        {
            RuleFor(x => x.InfosOferta!.OfertaKey!.Value)
            .MustAsync(ValidarOfertaExistenteAsync)
                .WithMessage("Chave da oferta não encontrada.")
            .When(x => x.InfosOferta!.OfertaKey.HasValue);

            RuleFor(x => x.InfosOferta!.OfertaConcursoKey!.Value)
            .MustAsync(ValidarOfertaConcursoExistenteAsync)
                .WithMessage("Chave da oferta concurso não encontrada.")
            .When(x => x.InfosOferta!.OfertaConcursoKey.HasValue);

            RuleFor(x => x.InfosOferta!.FormaEntradaKey!.Value)
            .MustAsync(ValidarFormaEntradaExistenteAsync)
                .WithMessage("Chave da forma de entrada não encontrada.")
            .When(x => x.InfosOferta!.FormaEntradaKey.HasValue);

            RuleForEach(x => x.InfosOferta!.OfertaConcursoOpcaoAcessos).ChildRules(opcaoAcesso =>
            {
                opcaoAcesso.RuleFor(x => x.Key)
                .MustAsync(ValidarOpcaoAcessoExistenteAsync)
                .WithMessage("Chave da opção de acesso não encontrada.");
            });
        });
        #endregion

        #region Validações de InfosContato
        When(x => x.InfosContato != null && x.InfosContato.Any(), () =>
        {
            RuleForEach(x => x.InfosContato).ChildRules(contato =>
            {
                contato.RuleFor(x => x.Valor)
                .MaximumLength(LimiteCaracteresValor)
                .WithMessage("O valor do contato deve ter no máximo {MaxLength} caracteres.");
            });

            RuleForEach(x => x.InfosContato).ChildRules(contato =>
            {
                contato.RuleFor(x => x.Valor)
                .Must(EmailUtils.ValidarEmail)
                .WithMessage("E-mail inválido.")
                .When(s => s.Tipo == TipoContatoInscricao.Email);
            });
        });
        #endregion

        #region Validações de InfosCupons
        When(x => x.InfosCupons != null && x.InfosCupons.Any(), () =>
        {
            RuleForEach(x => x.InfosCupons).ChildRules(doc =>
            {
                doc.RuleFor(x => x.Codigo)
                .MaximumLength(LimiteCaracteresCupom)
                .WithMessage("O código do cupom deve ter no máximo {MaxLength} caracteres.");
            });
        });
        #endregion

        #region Validações de InfosEndereco
        When(x => x.InfosEndereco != null && x.InfosEndereco.Any(), () =>
        {
            RuleForEach(x => x.InfosEndereco).ChildRules(endereco =>
            {
                endereco.When(e => e.Cep != null, () =>
                {
                    endereco.RuleFor(x => x.Cep)
                    .MaximumLength(LimiteCaracteresCep)
                    .WithMessage("O valor do CEP deve ter no máximo {MaxLength} caracteres.");
                });

                endereco.When(e => e.Complemento != null, () =>
                {
                    endereco.RuleFor(x => x.Complemento)
                    .MaximumLength(LimiteCaracteresEndereco)
                    .WithMessage("O valor do complemento do endereço deve ter no máximo {MaxLength} caracteres.");
                });

                endereco.When(e => e.Estado != null, () =>
                {
                    endereco.RuleFor(x => x.Estado)
                    .MaximumLength(LimiteCaracteresEndereco)
                    .WithMessage("O estado do endereço deve ter no máximo {MaxLength} caracteres.");
                });

                endereco.When(e => e.Bairro != null, () =>
                {
                    endereco.RuleFor(x => x.Bairro)
                    .MaximumLength(LimiteCaracteresEndereco)
                    .WithMessage("O valor do bairro do endereço deve ter no máximo {MaxLength} caracteres.");
                });

                endereco.When(e => e.Cidade != null, () =>
                {
                    endereco.RuleFor(x => x.Cidade)
                    .MaximumLength(LimiteCaracteresEndereco)
                    .WithMessage("O valor da cidade do endereço deve ter no máximo {MaxLength} caracteres.");
                });

                endereco.When(e => e.Rua != null, () =>
                {
                    endereco.RuleFor(x => x.Rua)
                    .MaximumLength(LimiteCaracteresEndereco)
                    .WithMessage("O valor da rua do endereço deve ter no máximo {MaxLength} caracteres.");
                });

                endereco.When(e => e.Numero != null, () =>
                {
                    endereco.RuleFor(x => x.Numero)
                    .MaximumLength(LimiteCaracteresCep)
                    .WithMessage("O valor do número do endereço deve ter no máximo {MaxLength} caracteres.");
                });

            });
        });
        #endregion

        #region Validações de InfosDocumento
        When(x => x.InfosDocumento != null && x.InfosDocumento.Any(), () =>
        {
            RuleForEach(x => x.InfosDocumento).ChildRules(doc =>
            {
                doc.RuleFor(x => x.Valor)
                .MaximumLength(LimiteCaracteresValor)
                .WithMessage("O valor do documento deve ter no máximo {MaxLength} caracteres.");
            });

            RuleForEach(x => x.InfosDocumento).ChildRules(doc =>
            {
                doc.RuleFor(x => x.Valor)
                .Must(CpfUtils.ValidarCpf)
                .WithMessage("CPF inválido.")
                .When(s => s.Tipo == TipoDocumentoInscricao.Cpf);
            });
        });
        #endregion

        #region Validações de InfoOrigem
        // Nenhuma validação específica
        #endregion

        #region Validações de InfosSeguroFianca
        When(x => x.InfosSeguroFianca != null && x.InfosSeguroFianca.Any(), () =>
        {
            RuleForEach(x => x.InfosSeguroFianca).ChildRules(fiador =>
            {
                fiador.When(f => f.NomeFiador != null, () =>
                {
                    fiador.RuleFor(x => x.NomeFiador)
                    .MaximumLength(LimiteCaracteresNome)
                    .WithMessage("O nome do fiador deve ter no máximo {MaxLength} caracteres.");
                });

                fiador.When(f => f.ValorDocumento != null, () =>
                {
                    fiador.RuleFor(x => x.ValorDocumento)
                    .MaximumLength(LimiteCaracteresValor)
                    .WithMessage("O documento do fiador deve ter no máximo {MaxLength} caracteres.");
                });

                fiador.When(f => f.ValorContato != null, () =>
                {
                    fiador.RuleFor(x => x.ValorContato)
                    .MaximumLength(LimiteCaracteresValor)
                    .WithMessage("O contato do fiador deve ter no máximo {MaxLength} caracteres.");
                });
            });
        });
        #endregion

        #region Validações de InfosAcessibilidade
        When(x => x.InfosAcessibilidade != null && x.InfosAcessibilidade.Any(), () =>
        {
            RuleForEach(x => x.InfosAcessibilidade).ChildRules(acessibilidade =>
            {
                acessibilidade.When(a => a.AcessibilidadeKey.HasValue, () =>
                {
                    acessibilidade.RuleFor(x => x.AcessibilidadeKey!.Value)
                    .MustAsync(ValidarAcessibilidadeExistenteAsync)
                        .WithMessage("Chave da acessibilidade não encontrada.");
                });
            });
        });
        #endregion

        #region Validações de InfosDeficiencia
        When(x => x.InfosDeficiencia != null && x.InfosDeficiencia.Any(), () =>
        {
            RuleForEach(x => x.InfosDeficiencia).ChildRules(deficiencia =>
            {
                deficiencia.When(a => a.DeficienciaKey.HasValue, () =>
                {
                    deficiencia.RuleFor(x => x.DeficienciaKey!.Value)
                    .MustAsync(ValidarDeficienciaExistenteAsync)
                        .WithMessage("Chave da deficiência não encontrada.");
                });
            });
        });
        #endregion

        #region Validações de InfosEscolaridade
        When(x => x.InfosEscolaridade != null && x.InfosEscolaridade.Any(), () =>
        {
            RuleForEach(e => e.InfosEscolaridade).ChildRules(escolaridade =>
            {
                escolaridade.RuleFor(x => x.EstadoKey!)
                .MustAsync(ValidarEstadoExistenteAsync)
                    .WithMessage("Estado da escolaridade não encontrado.")
                .When(x => x.EstadoKey! != null);

                escolaridade.RuleFor(x => x.CidadeKey!)
                .MustAsync(ValidarCidadeExistenteAsync)
                    .WithMessage("Cidade da escolaridade não encontrada.")
                .When(x => x.CidadeKey! != null);

                escolaridade.When(x => x.EscolaKey!.HasValue, () =>
                {
                    escolaridade.RuleFor(x => x.EscolaKey!.Value)
                    .MustAsync(ValidarEscolaExistenteAsync)
                    .WithMessage("Escola não encontrada.")
                    .When(x => x.EscolaKey!.HasValue);
                });

                escolaridade.RuleFor(x => x.CursoExternoKey!)
                .MustAsync(ValidarCursoExternoExistenteAsync)
                    .WithMessage("Curso Externo não encontrado.")
                .When(x => x.CursoExternoKey! != null);
            });
        });
        #endregion

        #region Validações de InfosEmpresa
        When(x => x.InfosEmpresa != null, () =>
        {
            RuleFor(x => x.InfosEmpresa!.EmpresaKey!.Value)
            .MustAsync(ValidarEmpresaExistenteAsync)
                .WithMessage("Empresa não encontrada.")
            .When(x => x.InfosEmpresa!.EmpresaKey.HasValue);

            
            When(x => !string.IsNullOrWhiteSpace(x!.InfosEmpresa?.OutraEmpresa), () =>
            {
                RuleFor(x => x!.InfosEmpresa!.OutraEmpresa)
                .MaximumLength(LimiteOutraEmpresa)
                .WithMessage("Outra empresa deve ter no máximo {MaxLength} caracteres.");
            });
        });
        #endregion

        #region Validações de InfosFiliacao
        When(x => x.InfosFiliacao != null && x.InfosFiliacao.Any(), () =>
        {
            RuleForEach(e => e.InfosFiliacao).ChildRules(filiacao =>
            {
                filiacao.RuleFor(x => x.Nome)
                .NotEmpty()
                    .WithMessage("O nome da filiação não pode ser vazio.")
                .MaximumLength(LimiteCaracteresNome)
                    .WithMessage("O nome da filiação deve ter no máximo {MaxLength} caracteres.");
            });
        });
        #endregion
    }

    private async Task<bool> ValidarFichaExistenteAsync(Guid key, CancellationToken token = default)
    {
        return await _fichaRepository.ExistsAsync(key, token);
    }

    private async Task<bool> ValidarEtapaExistenteAsync(Guid key, CancellationToken token = default)
    {
        return await _etapaTemplateRepository.ExistsAsync(key, token);
    }

    private async Task<bool> ValidarEstadoExistenteAsync(Guid? key, CancellationToken token = default)
    {
        if (!key.HasValue)
        {
            return false;
        }

        return await _estadoRepository.ExistsAsync(key.Value, token);
    }

    private async Task<bool> ValidarCidadeExistenteAsync(Guid? key, CancellationToken token = default)
    {
        if (!key.HasValue)
        {
            return false;
        }

        return await _cidadeRepository.ExistsAsync(key.Value, token);
    }

    private async Task<bool> ValidarEscolaExistenteAsync(Guid key, CancellationToken token = default)
    {
        return await _escolaRepository.ExistsAsync(key, token);
    }

    private async Task<bool> ValidarOfertaExistenteAsync(Guid key, CancellationToken token = default)
    {
        return await _ofertaRepository.ExistsAsync(key, token);
    }

    private async Task<bool> ValidarOfertaConcursoExistenteAsync(Guid key, CancellationToken token = default)
    {
        return await _ofertaConcursoRepository.ExistsAsync(key, token);
    }

    private async Task<bool> ValidarAcessibilidadeExistenteAsync(Guid key, CancellationToken token = default)
    {
        return await _acessibilidadeRepository.ExistsAsync(key, token);
    }

    private async Task<bool> ValidarDeficienciaExistenteAsync(Guid key, CancellationToken token = default)
    {
        return await _deficienciaRepository.ExistsAsync(key, token);
    }

    private async Task<bool> ValidarInscricaoExistenteAsync(Guid key, CancellationToken token = default)
    {
        return await _inscricaoRepository.ExistsAsync(key, token);
    }

    private async Task<bool> ValidarFormaEntradaExistenteAsync(Guid key, CancellationToken token = default)
    {
        return await _formaEntradaRepository.ExistsAsync(key, token);
    }

    private async Task<bool> ValidarOpcaoAcessoExistenteAsync(Guid key, CancellationToken token = default)
    {
        return await _ofertaConcursoOpcaoAcessoRepository.ExistsAsync(key, token);
    }

    private async Task<bool> ValidarCursoExternoExistenteAsync(Guid? key, CancellationToken token = default)
    {
        if (!key.HasValue)
        {
            return false;
        }

        return await _cursoExternoRepository.ExistsAsync(key.Value, token);
    }

    private async Task<bool> ValidarEmpresaExistenteAsync(Guid key, CancellationToken token = default)
    {
        return await _empresaRepository.ExistsAsync(key, token);
    }
}

