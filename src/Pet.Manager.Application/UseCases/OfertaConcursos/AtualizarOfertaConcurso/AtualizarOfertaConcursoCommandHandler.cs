using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Concursos;
using Anima.Inscricao.Domain.OfertaConcursos;
using Anima.Inscricao.Domain.Ofertas;

namespace Anima.Inscricao.Application.UseCases.OfertaConcursos.AtualizarOfertaConcurso
{
    public class AtualizarOfertaConcursoCommandHandler : ICommandHandler<AtualizarOfertaConcursoCommand>
    {
        private readonly INotificationContext _notificationContext;
        private readonly IOfertaConcursoRepository _ofertaConcursoRepository;
        private readonly IOfertaRepository _ofertaRepository ;
        private readonly IConcursoRepository _concursoRepository; 
        private readonly IUnitOfWork _unitOfWork;

        public AtualizarOfertaConcursoCommandHandler(
            INotificationContext notificationContext, 
            IOfertaConcursoRepository ofertaConcursoRepository, 
            IOfertaRepository ofertaRepository, 
            IConcursoRepository concursoRepository, 
            IUnitOfWork unitOfWork)
        {
            _notificationContext = notificationContext;
            _ofertaConcursoRepository = ofertaConcursoRepository;
            _ofertaRepository = ofertaRepository;
            _concursoRepository = concursoRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task Handle(AtualizarOfertaConcursoCommand request, CancellationToken cancellationToken)
        {
            var concurso = await _concursoRepository.GetAsync(request.ConcursoKey);

            var oferta = await _ofertaRepository.GetAsync(request.OfertaKey);

            var ofertaConcurso = await _ofertaConcursoRepository.GetAsync(request.Key);

            var ofertaConcursoAtualizada = ofertaConcurso.AtualizarInfos(concurso.Id, oferta.Id)
                .NotificarFalhas(_notificationContext)
                .IsSuccess;
            if(ofertaConcursoAtualizada)
            {
                _ofertaConcursoRepository.Update(ofertaConcurso);
                await 
                    _unitOfWork.CommitAsync(cancellationToken);
            }
        }
    }
}
