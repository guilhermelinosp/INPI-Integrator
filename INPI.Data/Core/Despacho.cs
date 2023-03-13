namespace INPI.Data.Core
{
    public class Despacho
    {
        public string? Codigo { get; set; }
        public string? Titulo { get; set; }
        public ProcessoPatente? ProcessoPatente { get; set; }
    }

    public class ProcessoPatente
    {
        public string? Numero { get; set; }
        public PedidoInternacional? PedidoInternacional { get; set; }
        public PublicacaoInternacional? PublicacaoInternacional { get; set; }
        public List<ClassificacaoInternacional>? ClassificacaoInternacionalLista { get; set; }
        public List<PrioridadeUnionista>? PrioridadeUnionistaLista { get; set; }
    }

    public class PedidoInternacional
    {
        public string? NumeroPCT { get; set; }
        public string? DataPCT { get; set; }
    }

    public class PublicacaoInternacional
    {
        public string? NumeroOMPI { get; set; }
        public string? DataOMPI { get; set; }
    }

    public class ClassificacaoInternacional
    {
        public string? Valor { get; set; }
        public string? Ano { get; set; }
        public int Sequencia { get; set; }
    }

    public class PrioridadeUnionista
    {
        public string? SiglaPais { get; set; }
        public string? NumeroPrioridade { get; set; }
        public string? DataPrioridade { get; set; }
        public int Sequencia { get; set; }
    }
}
