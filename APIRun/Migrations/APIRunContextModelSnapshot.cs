﻿// <auto-generated />
using System;
using APIRun.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace APIRun.Migrations
{
    [DbContext(typeof(APIRunContext))]
    partial class APIRunContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.29")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Models.Boleto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DataVencimento")
                        .HasColumnType("datetime2");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Boleto");
                });

            modelBuilder.Entity("Models.Cargo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cargo");
                });

            modelBuilder.Entity("Models.Carro", b =>
                {
                    b.Property<string>("Placa")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AnoFabricacao")
                        .HasColumnType("int");

                    b.Property<int>("AnoModelo")
                        .HasColumnType("int");

                    b.Property<string>("Cor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Vendido")
                        .HasColumnType("bit");

                    b.HasKey("Placa");

                    b.ToTable("Carro");
                });

            modelBuilder.Entity("Models.CarroServico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CarroPlaca")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("ServicoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CarroPlaca");

                    b.HasIndex("ServicoId");

                    b.ToTable("CarroServico");
                });

            modelBuilder.Entity("Models.Cartao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CodigoSeguranca")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DataValidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeCartao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroCartao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cartao");
                });

            modelBuilder.Entity("Models.Categoria", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categoria");
                });

            modelBuilder.Entity("Models.CNH", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<long>("CategoriaId")
                        .HasColumnType("bigint");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataVencimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("NomeMae")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomePai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rg")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.ToTable("CNH");
                });

            modelBuilder.Entity("Models.Compra", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CarroPlaca")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("DataCompra")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("CarroPlaca");

                    b.ToTable("Compra");
                });

            modelBuilder.Entity("Models.Endereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Complemento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<string>("TipoLogradouro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Uf")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Endereco");
                });

            modelBuilder.Entity("Models.Pagamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("BoletoId")
                        .HasColumnType("int");

                    b.Property<int>("CartaoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataPagamento")
                        .HasColumnType("datetime2");

                    b.Property<int>("PixId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BoletoId");

                    b.HasIndex("CartaoId");

                    b.HasIndex("PixId");

                    b.ToTable("Pagamento");
                });

            modelBuilder.Entity("Models.PendenciaFinanceira", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.HasKey("Id");

                    b.ToTable("PendenciaFinanceira");
                });

            modelBuilder.Entity("Models.Pessoa", b =>
                {
                    b.Property<string>("Documento")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EnderecoId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Documento");

                    b.HasIndex("EnderecoId");

                    b.ToTable("Pessoa");
                });

            modelBuilder.Entity("Models.Pix", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ChavePix")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TipoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TipoId");

                    b.ToTable("Pix");
                });

            modelBuilder.Entity("Models.Servico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Servico");
                });

            modelBuilder.Entity("Models.TipoPix", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TipoPix");
                });

            modelBuilder.Entity("Models.Venda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CarroPlaca")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ClienteDocumento")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("DataVenda")
                        .HasColumnType("datetime2");

                    b.Property<string>("FuncionarioDocumento")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("PagamentoId")
                        .HasColumnType("int");

                    b.Property<decimal>("ValorVenda")
                        .HasColumnType("decimal(18,4)");

                    b.HasKey("Id");

                    b.HasIndex("CarroPlaca");

                    b.HasIndex("ClienteDocumento");

                    b.HasIndex("FuncionarioDocumento");

                    b.HasIndex("PagamentoId");

                    b.ToTable("Venda");
                });

            modelBuilder.Entity("Models.Cliente", b =>
                {
                    b.HasBaseType("Models.Pessoa");

                    b.Property<decimal>("Renda")
                        .HasColumnType("decimal(18,2)");

                    b.ToTable("Cliente", (string)null);
                });

            modelBuilder.Entity("Models.Condutor", b =>
                {
                    b.HasBaseType("Models.Pessoa");

                    b.Property<long>("CnhId")
                        .HasColumnType("bigint");

                    b.HasIndex("CnhId");

                    b.ToTable("Condutor", (string)null);
                });

            modelBuilder.Entity("Models.Funcionario", b =>
                {
                    b.HasBaseType("Models.Pessoa");

                    b.Property<int>("CargoId")
                        .HasColumnType("int");

                    b.Property<decimal>("Comissao")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ValorComissao")
                        .HasColumnType("decimal(18,2)");

                    b.HasIndex("CargoId");

                    b.ToTable("Funcionario", (string)null);
                });

            modelBuilder.Entity("Models.CarroServico", b =>
                {
                    b.HasOne("Models.Carro", "Carro")
                        .WithMany()
                        .HasForeignKey("CarroPlaca");

                    b.HasOne("Models.Servico", "Servico")
                        .WithMany()
                        .HasForeignKey("ServicoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Carro");

                    b.Navigation("Servico");
                });

            modelBuilder.Entity("Models.CNH", b =>
                {
                    b.HasOne("Models.Categoria", "Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("Models.Compra", b =>
                {
                    b.HasOne("Models.Carro", "Carro")
                        .WithMany()
                        .HasForeignKey("CarroPlaca");

                    b.Navigation("Carro");
                });

            modelBuilder.Entity("Models.Pagamento", b =>
                {
                    b.HasOne("Models.Boleto", "Boleto")
                        .WithMany()
                        .HasForeignKey("BoletoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Cartao", "Cartao")
                        .WithMany()
                        .HasForeignKey("CartaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Pix", "Pix")
                        .WithMany()
                        .HasForeignKey("PixId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Boleto");

                    b.Navigation("Cartao");

                    b.Navigation("Pix");
                });

            modelBuilder.Entity("Models.Pessoa", b =>
                {
                    b.HasOne("Models.Endereco", "Endereco")
                        .WithMany()
                        .HasForeignKey("EnderecoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Endereco");
                });

            modelBuilder.Entity("Models.Pix", b =>
                {
                    b.HasOne("Models.TipoPix", "Tipo")
                        .WithMany()
                        .HasForeignKey("TipoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tipo");
                });

            modelBuilder.Entity("Models.Venda", b =>
                {
                    b.HasOne("Models.Carro", "Carro")
                        .WithMany()
                        .HasForeignKey("CarroPlaca");

                    b.HasOne("Models.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteDocumento");

                    b.HasOne("Models.Funcionario", "Funcionario")
                        .WithMany()
                        .HasForeignKey("FuncionarioDocumento");

                    b.HasOne("Models.Pagamento", "Pagamento")
                        .WithMany()
                        .HasForeignKey("PagamentoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Carro");

                    b.Navigation("Cliente");

                    b.Navigation("Funcionario");

                    b.Navigation("Pagamento");
                });

            modelBuilder.Entity("Models.Cliente", b =>
                {
                    b.HasOne("Models.Pessoa", null)
                        .WithOne()
                        .HasForeignKey("Models.Cliente", "Documento")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Models.Condutor", b =>
                {
                    b.HasOne("Models.CNH", "Cnh")
                        .WithMany()
                        .HasForeignKey("CnhId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Pessoa", null)
                        .WithOne()
                        .HasForeignKey("Models.Condutor", "Documento")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.Navigation("Cnh");
                });

            modelBuilder.Entity("Models.Funcionario", b =>
                {
                    b.HasOne("Models.Cargo", "Cargo")
                        .WithMany()
                        .HasForeignKey("CargoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Pessoa", null)
                        .WithOne()
                        .HasForeignKey("Models.Funcionario", "Documento")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.Navigation("Cargo");
                });
#pragma warning restore 612, 618
        }
    }
}
