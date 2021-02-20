using System.Collections.Generic;
using MyAcademy.Business.Notificacoes;

namespace MyAcademy.Business.Intefaces
{
    public interface INotificador
    {
        bool TemNotificacao();
        List<Notificacao> ObterNotificacoes();
        void Handle(Notificacao notificacao);
    }
}