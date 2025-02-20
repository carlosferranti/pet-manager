using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Empresas;
using Anima.Inscricao.Domain.Enderecos;

namespace Anima.Inscricao.Application.UseCases.Empresas.AtualizarEmpresa;

public class AtualizarEmpresaCommandHandler : ICommandHandler<AtualizarEmpresaCommand>
{
    private readonly INotificationContext _notificationContext;
    private readonly IEmpresaRepository _empresaRepository;
    private readonly ICidadeRepository _cidadeRepository;
    private readonly IUnitOfWork _unitOfWork;

    public AtualizarEmpresaCommandHandler(
        INotificationContext notificationContext,
        IEmpresaRepository empresaRepository,
        ICidadeRepository cidadeRepository,
        IUnitOfWork unitOfWork)
    {
        _notificationContext = notificationContext;
        _empresaRepository = empresaRepository;
        _cidadeRepository = cidadeRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task Handle(AtualizarEmpresaCommand request, CancellationToken cancellationToken)
    {
        var empresa = await _empresaRepository.GetAsync(request.Key);

        var empresaAtualizada = empresa
            .AtualizarInfos(request.Cnpj, request.NomeFantasia, request.RazaoSocial)
            .NotificarFalhas(_notificationContext)
            .IsSuccess;

        if (empresaAtualizada)
        {
            if(request.Enderecos != null && !request.Enderecos.Any())
            {
                foreach (var endereco in empresa.Enderecos)
                {
                    empresa.RemoverEndereco(endereco.Key);
                }
            }

            if (request.Enderecos != null && request.Enderecos.Any())
            {
                foreach (var endereco in request.Enderecos.Where(x => x.Key == null))
                {
                    var cidade = await _cidadeRepository.GetAsync(endereco.CidadeKey);
                    empresa.AdicionarEndereco(cidade.Id, endereco.Logradouro, endereco.Cep, endereco.Numero, endereco.Complemento, endereco.Bairro);
                }

                foreach (var enderecoKey in empresa.Enderecos.Select(e => e.Key).Where(e => !request.Enderecos.Select(r => r.Key).Contains(e)))
                {
                    empresa.RemoverEndereco(enderecoKey);
                }
            }

            _empresaRepository.Update(empresa);

            await _unitOfWork.CommitAsync(cancellationToken);
        }
    }
}
