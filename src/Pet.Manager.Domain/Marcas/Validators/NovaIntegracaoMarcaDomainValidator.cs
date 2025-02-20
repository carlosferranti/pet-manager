using Anima.Inscricao.Domain._Shared.Validations;
using Anima.Inscricao.Domain.IntegracaoSistemas.Entities;
using Anima.Inscricao.Domain.Marcas.Entities;

namespace Anima.Inscricao.Domain.Marcas.Validators;

public class NovaIntegracaoMarcaDomainValidator : DomainValidator
{
    public NovaIntegracaoMarcaDomainValidator()
    {
    }

    public bool Validate(Marca marca, IntegracaoSistemaId integracaoSistemaId)
    {
        var sistemaIntegradorNaoEhUnico = marca.IntegracoesMarcas.Any(i => i.IntegracaoSistemaId == integracaoSistemaId);

        if (sistemaIntegradorNaoEhUnico)
        {
            Validations.Add(new InfoValidation("IntegracaoMarca", "SistemaIntegradorUnico", "Já existe uma integração para o sistema integrador informado."));
        }

        return !Validations.Any();
    }
}
