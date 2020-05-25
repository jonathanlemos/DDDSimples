
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Data.Mapping
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User"); //nome tabela
            builder.HasKey(c => c.Id); //chave primária
            builder.Property(c => c.Cpf).IsRequired().HasColumnName("CPF"); //isRequired=not null - HasColumnName=nome da coluna
            builder.Property(c => c.DtAniversario).IsRequired().HasColumnName("DataAniversario");
            builder.Property(c => c.Nome).IsRequired().HasColumnName("Nome");
        }
    }
}
