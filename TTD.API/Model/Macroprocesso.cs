using System;

namespace TTD.API.Model
{
    public class Macroprocesso
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime? DataCadastro { get; set; }
        public string Descricao { get; set; }
    }
}