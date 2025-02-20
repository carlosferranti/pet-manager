using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.Intakes;
using Anima.Inscricao.Domain.Intakes;

namespace Anima.Inscricao.Application.UseCases.Intakes.ObterIntake;

public class ObterIntakeQueryHandler : IQueryHandler<ObterIntakeQuery, IntakeDto>
{
    private readonly IIntakeRepository _intakeRepository;

    public ObterIntakeQueryHandler(IIntakeRepository intakeRepository)
    {
        _intakeRepository = intakeRepository;
    }

    public async Task<IntakeDto> Handle(ObterIntakeQuery request, CancellationToken cancellationToken)
    {
        var intake = await _intakeRepository.GetAsync(request.Key);

        return new IntakeDto()
        {
            Key = intake.Key,
            Nome = intake.Nome,
            VigenciaInicio = intake.Vigencia.Inicio,
            VigenciaTermino = intake.Vigencia.Termino,
        };
    }
}