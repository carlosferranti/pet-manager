using System;
namespace Anima.Inscricao.Domain._Shared.MessageQueue.Interfaces
{
    public interface ISqsClient<T>
    {
        Task SendMessageAsync(T message);
    }
}

