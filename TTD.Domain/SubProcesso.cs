using System;

namespace TTD.Domain
{
    public class SubProcesso
    {
        
        public int Id { get; set; }
        public int NumeroOrdem { get; set; }
        public string Nome { get; set; }
        public DateTime DataCadastro { get; set; }
        public string Descricao { get; set; }
    }
}