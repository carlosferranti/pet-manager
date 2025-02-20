namespace Anima.Inscricao.Domain._Shared.ValueObjects;

public class Semestre
{
    private const int PrimeiroSemestre = 1;
    private const int UltimoSemestre = 2;

    public Semestre(int numero, int ano)
    {
        if (numero < PrimeiroSemestre || numero > UltimoSemestre)
        {
            throw new ArgumentException("O número do semestre deve ser 1 ou 2.");
        }

        Numero = numero;
        Ano = ano;
    }

    public int Numero { get; }

    public int Ano { get; }

    public override bool Equals(object? obj)
        => obj is Semestre semestre && Numero == semestre.Numero && Ano == semestre.Ano;

    public override int GetHashCode()
        => HashCode.Combine(Numero, Ano);

    public override string ToString()
        => $"Semestre {Numero} de {Ano}";
}
