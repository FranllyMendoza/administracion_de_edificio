// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using administracion_de_edificio.DAL;

namespace administracion_de_edificio.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20211127223311_inicial")]
    partial class inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("administracion_de_edificio.Entidades.Clientes", b =>
                {
                    b.Property<int>("IDcliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Apartamento")
                        .HasColumnType("TEXT");

                    b.Property<string>("Cedula")
                        .HasColumnType("TEXT");

                    b.Property<string>("Correo")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Fecha_registro")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre_referencia")
                        .HasColumnType("TEXT");

                    b.Property<string>("Numero_referencia")
                        .HasColumnType("TEXT");

                    b.Property<string>("Parqueo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Piso")
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefono")
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefono2")
                        .HasColumnType("TEXT");

                    b.HasKey("IDcliente");

                    b.ToTable("clientes");
                });

            modelBuilder.Entity("administracion_de_edificio.Entidades.Facturar", b =>
                {
                    b.Property<int>("IdFactura")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Fecha_pago")
                        .HasColumnType("TEXT");

                    b.Property<string>("Monto")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .HasColumnType("TEXT");

                    b.HasKey("IdFactura");

                    b.ToTable("factura");
                });

            modelBuilder.Entity("administracion_de_edificio.Entidades.Usuario", b =>
                {
                    b.Property<int>("usuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Cedula")
                        .HasColumnType("TEXT");

                    b.Property<string>("Clave")
                        .HasColumnType("TEXT");

                    b.Property<string>("Correo")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefono")
                        .HasColumnType("TEXT");

                    b.HasKey("usuarioId");

                    b.ToTable("usuarios");
                });
#pragma warning restore 612, 618
        }
    }
}
