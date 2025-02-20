using Anima.Inscricao.Domain.FormasEntrada.Entities;

namespace Anima.Inscricao.Test._Shared.Constants;

public static class FormaEntradaConstants
{
    public static readonly FormaEntrada FormaEntradaVestibular =
       FormaEntrada.Criar("Vestibular", "Descrição", 2, true, null, null, Application.Constants.FormaEntradaConstants.VestibularTradicionalKey)
       .ObterRetorno() ?? throw new ArgumentException("Erro ao criar a forma de entrada Vestibular");
   
    public static readonly FormaEntrada FormaEntradaEnem =
       FormaEntrada.Criar("ENEM", "Descrição", 0, true, null, null, Application.Constants.FormaEntradaConstants.EnemKey)
       .ObterRetorno() ?? throw new ArgumentException("Erro ao criar a forma de entrada ENEM");

    public static readonly FormaEntrada FormaEntradaTransferencia =
      FormaEntrada.Criar("Transferência", "Descrição", 3, true, null, null, Application.Constants.FormaEntradaConstants.Transferencia)
      .ObterRetorno() ?? throw new ArgumentException("Erro ao criar a forma de entrada Transferência");

    public static readonly FormaEntrada FormaEntradaDestrancamentoRetorno =
      FormaEntrada.Criar("Destrancamento/Retorno", "Descrição", 5, true, null, null, Application.Constants.FormaEntradaConstants.DestrancamentoRetorno)
      .ObterRetorno() ?? throw new ArgumentException("Erro ao criar a forma de entrada DestrancamentoRetorno");
    
    public static readonly FormaEntrada FormaEntradaReopcao =
      FormaEntrada.Criar("Reopção", "Descrição", 6, true, null, null, Application.Constants.FormaEntradaConstants.Reopcao)
      .ObterRetorno() ?? throw new ArgumentException("Erro ao criar a forma de entrada Reopção");
    
    public static readonly FormaEntrada FormaEntradaSegundaGraduacao =
      FormaEntrada.Criar("Segunda Graduação", "Descrição", 4, true, null, null, Application.Constants.FormaEntradaConstants.SegundaGraduacao)
      .ObterRetorno() ?? throw new ArgumentException("Erro ao criar a forma de entrada Segunda Graduação");
    
    public static readonly FormaEntrada FormaEntradaVestibularEscola =
         FormaEntrada.Criar("Vestibular Escolar", "Descrição", 5, true, null, null, Application.Constants.FormaEntradaConstants.VestibularEscolar)
         .ObterRetorno() ?? throw new ArgumentException("Erro ao criar a forma de entrada Vestibular Escolar");
    
    public static readonly FormaEntrada FormaEntradaVestibularCorporativo =
         FormaEntrada.Criar("Vestibular Corportivo", "Descrição", 6, true, null, null, Application.Constants.FormaEntradaConstants.VestibularCorporativo)
         .ObterRetorno() ?? throw new ArgumentException("Erro ao criar a forma de entrada Vestibular Corportivo");

    public static readonly FormaEntrada FormaEntradaVestibularSimplificado =
     FormaEntrada.Criar("Vestibular Simplificado", "Descrição", 7, true, null, null, Application.Constants.FormaEntradaConstants.EntradaSimplificadaKey)
     .ObterRetorno() ?? throw new ArgumentException("Erro ao criar a forma de entrada Vestibular Simplificado");
}
