using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Mapping
{
    public class OrcamentoMapping : IEntityTypeConfiguration<OrcamentoEntity>
    {
        public void Configure(EntityTypeBuilder<OrcamentoEntity> builder)
        {
            builder.ToTable("Orcamento");
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Id).ValueGeneratedOnAdd();
            
            builder.Property(a => a.Nome).IsRequired().HasMaxLength(50);
            builder.Property(a => a.Cpf).IsRequired().HasMaxLength(20);
            builder.Property(a => a.Email).IsRequired().HasMaxLength(50);
            builder.Property(a => a.Telefone).IsRequired().HasMaxLength(60);
            builder.Property(a => a.Ramo).IsRequired().HasMaxLength(50);
            builder.Property(a => a.NomeEmpresa).IsRequired().HasMaxLength(50);
            builder.Property(a => a.Templates).IsRequired().HasMaxLength(50);
            builder.Property(a => a.Sugestao).IsRequired().HasMaxLength(350);
        }
    }
}