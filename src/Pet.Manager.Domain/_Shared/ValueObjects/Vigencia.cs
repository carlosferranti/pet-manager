namespace Anima.Inscricao.Domain._Shared.ValueObjects;

using System;

/// <summary>
/// Representa uma vigência com data de início e término.
/// </summary>
public class Vigencia
{
    /// <summary>
    /// Inicia uma nova instância da classe <see cref="Vigencia"/> com as datas de início e término especificadas.
    /// </summary>
    /// <param name="inicio">A data de início da vigência. Se não for especificada, será utilizada a data mínima.</param>
    /// <param name="termino">A data de término da vigência. Se não for especificada, será utilizada a data máxima.</param>
    public Vigencia(DateTime? inicio, DateTime? termino)
    {
        Inicio = inicio ?? DateTime.MinValue;
        Termino = termino ?? DateTime.MaxValue;
    }

    protected Vigencia()
    {
    }

    /// <summary>
    /// Obtém ou define a data de início da vigência.
    /// </summary>
    public virtual DateTime Inicio { get; protected set; }

    /// <summary>
    /// Obtém ou define a data de término da vigência.
    /// </summary>
    public virtual DateTime Termino { get; protected set; }

    /// <summary>
    /// Verifica se a vigência está em andamento no momento atual.
    /// </summary>
    /// <returns>True se a vigência estiver em andamento, False caso contrário.</returns>
    public bool EstaEmAndamento()
    {
        return EstaEmAndamento(DateTime.Now);
    }

    /// <summary>
    /// Verifica se a vigência está em andamento em uma determinada data de referência.
    /// </summary>
    /// <param name="dataReferencia">A data de referência.</param>
    /// <returns>True se a vigência estiver em andamento na data de referência, False caso contrário.</returns>
    public bool EstaEmAndamento(DateTime dataReferencia)
    {
        return dataReferencia >= Inicio && dataReferencia <= Termino;
    }

    /// <summary>
    /// Calcula a duração da vigência.
    /// </summary>
    /// <returns>A duração da vigência como um objeto TimeSpan.</returns>
    public TimeSpan? CalcularDuracao()
    {
        return Termino - Inicio;
    }

    /// <summary>
    /// Verifica se a vigência tem início indeterminado.
    /// </summary>
    /// <returns>True se a vigência tiver início indeterminado, False caso contrário.</returns>
    public bool TemInicioIndeterminada()
    {
        return Inicio == DateTime.MinValue;
    }

    /// <summary>
    /// Verifica se a vigência tem término indeterminado.
    /// </summary>
    /// <returns>True se a vigência tiver término indeterminado, False caso contrário.</returns>
    public bool TemTerminoIndeterminada()
    {
        return Termino == DateTime.MaxValue;
    }

    public bool VerificarSobreposicao(Vigencia vigenciaComparacao)
    {
        // Se nenhuma das condições acima for verdadeira, as vigências não se sobrepõem
        return false;
    }

    /// <summary>
    /// Retorna o semestre de início da vigência.
    /// </summary>
    /// <returns>O semestre de início da vigência como um objeto int.</returns>
    public int ObterSemestre()
    {
        return Inicio.Month <= 6 ? 1 : 2;
    }

    /// <summary>
    /// Retorna uma representação em string da vigência, exibindo as datas de início e término.
    /// </summary>
    /// <returns>A representação em string da vigência.</returns>
    public override string ToString()
    {
        if (!TemInicioIndeterminada() && !TemTerminoIndeterminada())
        {
            return $"Vigência de {Inicio.ToShortDateString()} a {Termino.ToShortDateString()}";
        }
        else if (!TemInicioIndeterminada())
        {
            return $"Vigência a partir de {Inicio.ToShortDateString()}";
        }
        else if (!TemTerminoIndeterminada())
        {
            return $"Vigência até {Termino.ToShortDateString()}";
        }
        else
        {
            return "Vigência indeterminada";
        }
    }

    public override bool Equals(object? obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        Vigencia other = (Vigencia)obj;
        return Inicio == other.Inicio && Termino == other.Termino;
    }

    public override int GetHashCode()
    {
        int hash = 17;
        hash = hash * 23 + Inicio.GetHashCode();
        hash = hash * 23 + Termino.GetHashCode();
        return hash;
    }
}
