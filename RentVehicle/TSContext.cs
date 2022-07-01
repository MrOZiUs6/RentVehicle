using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace RentVehicle
{
    public partial class TSContext : DbContext
    {
        public TSContext()
        {
        }

        public TSContext(DbContextOptions<TSContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Client> Clients { get; set; } = null!;
        public virtual DbSet<Contract> Contracts { get; set; } = null!;
        public virtual DbSet<Employee> Employees { get; set; } = null!;
        public virtual DbSet<Model> Models { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<Vehicle> Vehicles { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("Host=postgresql.j72508840.myjino.ru;Port=5432;Database=j72508840_rentvehicle;Username=j72508840_rentvehicle;Password=yZL_Au6z_NRjLVe");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>(entity =>
            {
                entity.HasKey(e => e.DocumentNumber)
                    .HasName("client_pkey");

                entity.ToTable("client");

                entity.Property(e => e.DocumentNumber)
                    .HasPrecision(10)
                    .HasColumnName("document_number");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .HasColumnName("password");

                entity.Property(e => e.Patronymic)
                    .HasMaxLength(50)
                    .HasColumnName("patronymic");

                entity.Property(e => e.Surname)
                    .HasMaxLength(50)
                    .HasColumnName("surname");

                entity.Property(e => e.TelephoneNumber)
                    .HasPrecision(11)
                    .HasColumnName("telephone_number");
            });

            modelBuilder.Entity<Contract>(entity =>
            {
                entity.HasKey(e => e.IdContract)
                    .HasName("contract_pkey");

                entity.ToTable("contract");

                entity.Property(e => e.IdContract).HasColumnName("id_contract");

                entity.Property(e => e.DateOfConclusion).HasColumnName("date_of_conclusion");

                entity.Property(e => e.DocumentNumber)
                    .HasPrecision(10)
                    .HasColumnName("document_number");

                entity.Property(e => e.FinalPrice).HasColumnName("final_price");

                entity.Property(e => e.IdEmployee).HasColumnName("id_employee");

                entity.Property(e => e.SerialNumber)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("serial_number");

                entity.HasOne(d => d.DocumentNumberNavigation)
                    .WithMany(p => p.Contracts)
                    .HasForeignKey(d => d.DocumentNumber)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_document_number");

                entity.HasOne(d => d.IdEmployeeNavigation)
                    .WithMany(p => p.Contracts)
                    .HasForeignKey(d => d.IdEmployee)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_id_employee");

                entity.HasOne(d => d.SerialNumberNavigation)
                    .WithMany(p => p.Contracts)
                    .HasForeignKey(d => d.SerialNumber)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_serial_number");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.IdEmployee)
                    .HasName("employee_pkey");

                entity.ToTable("employee");

                entity.HasIndex(e => e.Login, "employee_login_key")
                    .IsUnique();

                entity.Property(e => e.IdEmployee).HasColumnName("id_employee");

                entity.Property(e => e.IdRole).HasColumnName("id_role");

                entity.Property(e => e.Login)
                    .HasMaxLength(50)
                    .HasColumnName("login");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .HasColumnName("password");

                entity.Property(e => e.Patronymic)
                    .HasMaxLength(50)
                    .HasColumnName("patronymic");

                entity.Property(e => e.Surname)
                    .HasMaxLength(50)
                    .HasColumnName("surname");

                entity.HasOne(d => d.IdRoleNavigation)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.IdRole)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_id_role");
            });

            modelBuilder.Entity<Model>(entity =>
            {
                entity.HasKey(e => e.IdModelType)
                    .HasName("model_pkey");

                entity.ToTable("model");

                entity.Property(e => e.IdModelType).HasColumnName("id_model_type");

                entity.Property(e => e.FrameType)
                    .HasMaxLength(50)
                    .HasColumnName("frame_type");

                entity.Property(e => e.ModelType)
                    .HasMaxLength(50)
                    .HasColumnName("model_type");

                entity.Property(e => e.NumberOfSeats).HasColumnName("number_of_seats");

                entity.Property(e => e.NumberOfWheels)
                    .HasColumnName("number_of_wheels")
                    .HasDefaultValueSql("2");

                entity.Property(e => e.WheelSize).HasColumnName("wheel_size");

                entity.Property(e => e.WheelType)
                    .HasMaxLength(50)
                    .HasColumnName("wheel_type");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasKey(e => e.IdRole)
                    .HasName("role_pkey");

                entity.ToTable("role");

                entity.Property(e => e.IdRole).HasColumnName("id_role");

                entity.Property(e => e.NameRole)
                    .HasMaxLength(50)
                    .HasColumnName("name_role");
            });

            modelBuilder.Entity<Vehicle>(entity =>
            {
                entity.HasKey(e => e.SerialNumber)
                    .HasName("vehicle_pkey");

                entity.ToTable("vehicle");

                entity.Property(e => e.SerialNumber)
                    .ValueGeneratedNever()
                    .HasColumnName("serial_number");

                entity.Property(e => e.IdModelType).HasColumnName("id_model_type");

                entity.Property(e => e.LifeTime).HasColumnName("life_time");

                entity.Property(e => e.RentalPrice).HasColumnName("rental_price");

                entity.HasOne(d => d.IdModelTypeNavigation)
                    .WithMany(p => p.Vehicles)
                    .HasForeignKey(d => d.IdModelType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_id_model_type");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
