using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class User : BaseEntity
    {
        public string Nome { get; set; }

        public DateTime DtAniversario { get; set; }

        public int Cpf { get; set; }
    }
}
