using System.Net;
using System.Runtime.Serialization;

namespace Anima.Inscricao.Domain._Shared.Exceptions
{
    [Serializable]
    public class ForbiddenException : BusinessException
    {
        /// <summary>
        /// Inicia uma nova instância da classe <see cref="ForbiddenException"/>.
        /// </summary>
        /// <param name="title">Titulo.</param>
        /// <param name="message">Mensagem.</param>
        /// <param name="details">Detalhes.</param>
        public ForbiddenException(string title, string message, object? details = null)
            : base(title, message)
        {
        }

        /// <summary>
        /// Inicia uma nova instância da classe <see cref="ForbiddenException"/>.
        /// </summary>
        /// <param name="info">Detalhes para Serialização.</param>
        /// <param name="context">contexto para Serialização.</param>
        protected ForbiddenException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        /// <summary>
        /// Obtém o status da resposta.
        /// </summary>
        public new HttpStatusCode StatusCode => HttpStatusCode.Forbidden;
    }
}
