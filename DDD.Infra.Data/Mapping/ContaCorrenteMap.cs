using DDD.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DDD.Infra.Data.Mapping
{
    public class ContaCorrenteMap : IEntityTypeConfiguration<ContaCorrente>
	{
    public void Configure(EntityTypeBuilder<ContaCorrente> builder)
    {
      builder.ToTable("ContaCorrente");

      builder.HasKey(c => c.Id);

      builder.Property(c => c.Cpf)
        .IsRequired()
        .HasColumnName("Cpf");

      builder.Property(c => c.Fone)
        .IsRequired()
        .HasColumnName("Fone");

      builder.Property(c => c.Endereco)
        .IsRequired()
        .HasColumnName("Endereco");
       
      builder.Property(c => c.Saldo)
        .IsRequired()
        .HasColumnName("Saldo");

      builder.Property(c => c.LimiteCredito)
        .IsRequired()
        .HasColumnName("LimiteCredito");        
    }
	}
}