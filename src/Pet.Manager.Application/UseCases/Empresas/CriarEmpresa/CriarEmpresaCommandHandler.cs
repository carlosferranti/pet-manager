using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Application._Shared.DTOs;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Empresas;
using Anima.Inscricao.Domain.Empresas.Entities;
using Anima.Inscricao.Domain.Enderecos;
using Anima.Inscricao.Domain.IntegracaoSistemas;

namespace Anima.Inscricao.Application.UseCases.Empresas.CriarEmpresa;

public class CriarEmpresaCommandHandler : ICommandHandler<CriarEmpresaCommand, EntityKeyDto?>
{
    private readonly INotificationContext _notificationContext;
    private readonly IEmpresaRepository _empresaRepository;
    private readonly ICidadeRepository _cidadeRepository;
    private readonly IIntegracaoSistemaRepository _sistemasIntegracaoRepository;
    private readonly IUnitOfWork _unitOfWork;

    public CriarEmpresaCommandHandler(
        INotificationContext notificationContext,
        IEmpresaRepository empresaRepository,
        ICidadeRepository cidadeRepository,
        IIntegracaoSistemaRepository sistemasIntegracaoRepository,
        IUnitOfWork unitOfWork)
    {
        _notificationContext = notificationContext;
        _empresaRepository = empresaRepository;
        _sistemasIntegracaoRepository = sistemasIntegracaoRepository;
        _cidadeRepository = cidadeRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<EntityKeyDto?> Handle(CriarEmpresaCommand request, CancellationToken cancellationToken)
    {
        var empresa = Empresa
            .Criar(request.Cnpj, request.NomeFantasia, request.RazaoSocial)
            .NotificarFalhas(_notificationContext)
            .ObterRetorno();

        if (empresa == null)
        {
            return null;
        }

        if (request.Integracao != null)
        {
            var sistema = await _sistemasIntegracaoRepository.GetAsync(s => s.Nome.ToUpper() == request.Integracao.NomeSistema.ToUpper());
            empresa.AdicionarIntegracao(sistema.Id, request.Integracao.CodigoOrigem);
        }

        if(request.Enderecos != null && request.Enderecos.Any())
        {
            foreach (var endereco in request.Enderecos)
            {
                var cidade = await _cidadeRepository.GetAsync(endereco.CidadeKey);
                empresa.AdicionarEndereco(cidade.Id, endereco.Logradouro, endereco.Cep, endereco.Numero, endereco.Complemento, endereco.Bairro);
            }
        }

        await _empresaRepository.InsertAsync(empresa);

        await _unitOfWork.CommitAsync(cancellationToken);

        return new EntityKeyDto(empresa.Key);
    }
}
