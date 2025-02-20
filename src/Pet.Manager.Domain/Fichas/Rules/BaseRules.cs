using Anima.Inscricao.Domain.Campos.Entities;
using Anima.Inscricao.Domain.Fichas.Entities;

namespace Anima.Inscricao.Domain.Fichas.Rules;

public class BaseRules
{
    protected const string CampoObrigatorio = "CampoObrigatorio";

    private readonly List<CampoFicha> _camposFicha;
    private readonly List<Campo> _campos;

    public BaseRules(
        List<CampoFicha> camposFicha,
        List<Campo> campos)
    {
        _camposFicha = camposFicha;
        _campos = campos;
    }

    protected bool CampoNaoEstaPreenchido<T>(object? valor)
    {
        if (valor == null)
        {
            return true;
        }

        if (typeof(T) == typeof(int) || typeof(T) == typeof(int?))
        {
            return (int)valor <= 0;
        }

        if (typeof(T) == typeof(string))
        {
            return string.IsNullOrWhiteSpace((string)valor);
        }

        if (typeof(T) == typeof(DateTime) || typeof(T) == typeof(DateTime?))
        {
            return (DateTime)valor == DateTime.MinValue;
        }

        return true;
    }

    protected bool CampoEhObrigatorioNaFicha(string campo)
    {
        var campoId = _campos.Find(c => c.Nome.ToUpper().Equals(campo.ToUpper()))?.Id;

        if (campoId == null)
            return false;

        return _camposFicha.Exists(cf => cf.CampoId == campoId && cf.ObrigatorioNaFicha);
    }
}