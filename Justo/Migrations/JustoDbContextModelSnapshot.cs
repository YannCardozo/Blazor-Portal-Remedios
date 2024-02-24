﻿// <auto-generated />
using System;
using Justo.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Justo.Migrations
{
    [DbContext(typeof(JustoDbContext))]
    partial class JustoDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("Justo-ADV")
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Justo.Models.Advogado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("varchar")
                        .HasColumnName("Nome");

                    b.Property<string>("Oab")
                        .IsRequired()
                        .HasMaxLength(6)
                        .HasColumnType("varchar")
                        .HasColumnName("Oab");

                    b.Property<string>("Oab_UF")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("varchar")
                        .HasColumnName("Oab_UF");

                    b.Property<int>("ProcessosId")
                        .HasColumnType("int")
                        .HasColumnName("ProcessosId");

                    b.Property<bool>("Status_Oab_Ativo")
                        .HasColumnType("bit")
                        .HasColumnName("Status_Oab_Ativo");

                    b.Property<int>("atualizadopor")
                        .HasColumnType("int")
                        .HasColumnName("atualizadopor");

                    b.Property<int>("cadastradopor")
                        .HasColumnType("int")
                        .HasColumnName("cadastradopor");

                    b.Property<string>("cpf")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("varchar")
                        .HasColumnName("cpf");

                    b.Property<DateTime>("dataatualizacao")
                        .HasColumnType("datetime2")
                        .HasColumnName("data_atualizacao");

                    b.Property<DateTime>("datacadastro")
                        .HasColumnType("datetime2")
                        .HasColumnName("data_cadastro");

                    b.HasKey("Id")
                        .HasName("PK_Advogados");

                    b.HasIndex("Oab")
                        .IsUnique();

                    b.HasIndex("ProcessosId");

                    b.HasIndex("cpf")
                        .IsUnique();

                    b.ToTable("Advogados", "Justo-ADV");
                });

            modelBuilder.Entity("Justo.Models.Advogado_especialidade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AdvogadoId")
                        .HasColumnType("int")
                        .HasColumnName("AdvogadoId");

                    b.Property<string>("Nome_area_direito")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("varchar")
                        .HasColumnName("Nome_area_direito");

                    b.Property<int>("atualizadopor")
                        .HasColumnType("int")
                        .HasColumnName("atualizadopor");

                    b.Property<int>("cadastradopor")
                        .HasColumnType("int")
                        .HasColumnName("cadastradopor");

                    b.Property<DateTime>("dataatualizacao")
                        .HasColumnType("datetime2")
                        .HasColumnName("data_atualizacao");

                    b.Property<DateTime>("datacadastro")
                        .HasColumnType("datetime2")
                        .HasColumnName("data_cadastro");

                    b.HasKey("Id")
                        .HasName("PK_Advogados_Especialidades");

                    b.HasIndex("AdvogadoId");

                    b.ToTable("Advogados_Especialidades", "Justo-ADV");
                });

            modelBuilder.Entity("Justo.Models.Clientes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Agencia_bancaria_cliente")
                        .HasMaxLength(35)
                        .HasColumnType("varchar")
                        .HasColumnName("Agencia_bancaria_cliente");

                    b.Property<string>("Banco_cliente")
                        .HasMaxLength(35)
                        .HasColumnType("varchar")
                        .HasColumnName("Banco_cliente");

                    b.Property<string>("Certificado_reservista_cliente")
                        .HasMaxLength(30)
                        .HasColumnType("varchar")
                        .HasColumnName("Certificado_reservista_cliente");

                    b.Property<string>("Cnh_cliente")
                        .HasMaxLength(20)
                        .HasColumnType("varchar")
                        .HasColumnName("Cnh_cliente");

                    b.Property<string>("Cnpj_cliente")
                        .HasMaxLength(30)
                        .HasColumnType("varchar")
                        .HasColumnName("Cnpj_cliente");

                    b.Property<string>("Contato_de_confianca_cliente")
                        .HasMaxLength(35)
                        .HasColumnType("varchar")
                        .HasColumnName("Contato_de_confianca_cliente");

                    b.Property<string>("Contrato_social_cliente")
                        .HasMaxLength(50)
                        .HasColumnType("varchar")
                        .HasColumnName("Contrato_social_cliente");

                    b.Property<string>("Cpf_cliente")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("varchar")
                        .HasColumnName("Cpf_cliente");

                    b.Property<DateTime>("Data_nascimento_cliente")
                        .HasColumnType("datetime2")
                        .HasColumnName("Data_nascimento_cliente");

                    b.Property<string>("Email_cliente")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("varchar")
                        .HasColumnName("Email_cliente");

                    b.Property<int>("EnderecoId")
                        .HasColumnType("int");

                    b.Property<string>("Estado_civil_cliente")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("varchar")
                        .HasColumnName("Estado_civil_cliente");

                    b.Property<string>("Genero_cliente")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("varchar")
                        .HasColumnName("Genero_cliente");

                    b.Property<string>("Nacionalidade_cliente")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("varchar")
                        .HasColumnName("Nacionalidade_cliente");

                    b.Property<string>("Nome_cliente")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("varchar")
                        .HasColumnName("Nome_cliente");

                    b.Property<string>("Ocupacao_cliente")
                        .HasMaxLength(35)
                        .HasColumnType("varchar")
                        .HasColumnName("Ocupacao_cliente");

                    b.Property<int>("ProcessoId")
                        .HasColumnType("int");

                    b.Property<int?>("ProcessosId")
                        .HasColumnType("int");

                    b.Property<string>("Procuracao_representacao_legal_cliente")
                        .HasMaxLength(30)
                        .HasColumnType("varchar")
                        .HasColumnName("Procuracao_representacao_legal_cliente");

                    b.Property<string>("Rg_cliente")
                        .IsRequired()
                        .HasMaxLength(9)
                        .HasColumnType("varchar")
                        .HasColumnName("Rg_cliente");

                    b.Property<string>("Telefone_cliente")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("varchar")
                        .HasColumnName("Telefone_cliente");

                    b.Property<string>("Tipo_cliente")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("varchar")
                        .HasColumnName("Tipo_cliente");

                    b.Property<int>("atualizadopor")
                        .HasColumnType("int")
                        .HasColumnName("atualizadopor");

                    b.Property<int>("cadastradopor")
                        .HasColumnType("int")
                        .HasColumnName("cadastradopor");

                    b.Property<DateTime>("dataatualizacao")
                        .HasColumnType("datetime2")
                        .HasColumnName("data_atualizacao");

                    b.Property<DateTime>("datacadastro")
                        .HasColumnType("datetime2")
                        .HasColumnName("data_cadastro");

                    b.HasKey("Id")
                        .HasName("PK_Clientes");

                    b.HasIndex("ProcessosId");

                    b.ToTable("Clientes", "Justo-ADV");
                });

            modelBuilder.Entity("Justo.Models.Endereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<string>("Municipio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Referencia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rua")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UF")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("atualizadopor")
                        .HasColumnType("int");

                    b.Property<int>("cadastradopor")
                        .HasColumnType("int");

                    b.Property<DateTime>("dataatualizacao")
                        .HasColumnType("datetime2")
                        .HasColumnName("data_atualizacao");

                    b.Property<DateTime>("datacadastro")
                        .HasColumnType("datetime2")
                        .HasColumnName("data_cadastro");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId")
                        .IsUnique();

                    b.ToTable("Endereco", "Justo-ADV");
                });

            modelBuilder.Entity("Justo.Models.Processos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Cod_processo_TJ")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Comarca_inicial")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Conteudo_inicial")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Data_abertura")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Data_fim")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nome_autor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome_cliente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome_reu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Obs_processo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Polo_cliente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProcessosDetalhesId")
                        .HasColumnType("int");

                    b.Property<string>("Situacao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tipo_processo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("atualizadopor")
                        .HasColumnType("int");

                    b.Property<int>("cadastradopor")
                        .HasColumnType("int");

                    b.Property<DateTime>("dataatualizacao")
                        .HasColumnType("datetime2")
                        .HasColumnName("data_atualizacao");

                    b.Property<DateTime>("datacadastro")
                        .HasColumnType("datetime2")
                        .HasColumnName("data_cadastro");

                    b.HasKey("Id");

                    b.ToTable("Processos", "Justo-ADV");
                });

            modelBuilder.Entity("Justo.Models.Processos_ClientesReu", b =>
                {
                    b.Property<int>("ProcessoId")
                        .HasColumnType("int");

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DataEntrouNoProcesso")
                        .HasColumnType("datetime2");

                    b.HasKey("ProcessoId", "ClienteId");

                    b.HasIndex("ClienteId");

                    b.ToTable("Processos_ClientesReu", "Justo-ADV");
                });

            modelBuilder.Entity("Justo.Models.Site_contato", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Analisado_contato")
                        .HasColumnType("bit")
                        .HasColumnName("Analisado_contato");

                    b.Property<string>("Assunto_contato")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar")
                        .HasColumnName("Assunto_contato");

                    b.Property<string>("Conteudo_contato")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("varchar")
                        .HasColumnName("Conteudo_contato");

                    b.Property<string>("Email_contato")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("varchar")
                        .HasColumnName("Email_contato");

                    b.Property<string>("Nome_contato")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("varchar")
                        .HasColumnName("Nome_contato");

                    b.Property<string>("Telefone_contato")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("varchar")
                        .HasColumnName("Telefone_contato");

                    b.Property<string>("Tipo_causa_contato")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("varchar")
                        .HasColumnName("Tipo_causa_contato");

                    b.Property<bool>("Virar_cliente_contato")
                        .HasColumnType("bit")
                        .HasColumnName("Virar_cliente_contato");

                    b.Property<int>("atualizadopor")
                        .HasColumnType("int")
                        .HasColumnName("atualizadopor");

                    b.Property<int>("cadastradopor")
                        .HasColumnType("int")
                        .HasColumnName("cadastradopor");

                    b.Property<DateTime>("dataatualizacao")
                        .HasColumnType("datetime2")
                        .HasColumnName("data_atualizacao");

                    b.Property<DateTime>("datacadastro")
                        .HasColumnType("datetime2")
                        .HasColumnName("data_cadastro");

                    b.HasKey("Id")
                        .HasName("PK_Site_contato");

                    b.ToTable("Site_contato", "Justo-ADV");
                });

            modelBuilder.Entity("Justo.Models.Advogado", b =>
                {
                    b.HasOne("Justo.Models.Processos", null)
                        .WithMany("Advogados")
                        .HasForeignKey("ProcessosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Justo.Models.Advogado_especialidade", b =>
                {
                    b.HasOne("Justo.Models.Advogado", "Advogados_FK")
                        .WithMany("Advogados_Especialidades_FK")
                        .HasForeignKey("AdvogadoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Advogados_FK");
                });

            modelBuilder.Entity("Justo.Models.Clientes", b =>
                {
                    b.HasOne("Justo.Models.Processos", null)
                        .WithMany("Lisconsorcio_autor")
                        .HasForeignKey("ProcessosId");
                });

            modelBuilder.Entity("Justo.Models.Endereco", b =>
                {
                    b.HasOne("Justo.Models.Clientes", null)
                        .WithOne("Endereco_cliente")
                        .HasForeignKey("Justo.Models.Endereco", "ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Justo.Models.Processos_ClientesReu", b =>
                {
                    b.HasOne("Justo.Models.Clientes", "Cliente")
                        .WithMany("Processos_ClientesReu")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Justo.Models.Processos", "Processo")
                        .WithMany("Processos_ClientesReu")
                        .HasForeignKey("ProcessoId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Processo");
                });

            modelBuilder.Entity("Justo.Models.Advogado", b =>
                {
                    b.Navigation("Advogados_Especialidades_FK");
                });

            modelBuilder.Entity("Justo.Models.Clientes", b =>
                {
                    b.Navigation("Endereco_cliente")
                        .IsRequired();

                    b.Navigation("Processos_ClientesReu");
                });

            modelBuilder.Entity("Justo.Models.Processos", b =>
                {
                    b.Navigation("Advogados");

                    b.Navigation("Lisconsorcio_autor");

                    b.Navigation("Processos_ClientesReu");
                });
#pragma warning restore 612, 618
        }
    }
}
