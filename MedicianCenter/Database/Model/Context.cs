using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace MedicianCenter.Database.Model
{
    public partial class Context : DbContext
    {
        public Context()
            : base(StateSingleton.getInstance().connectionString)
        {
        }

        public virtual DbSet<contra> contras { get; set; }
        public virtual DbSet<doctor> doctors { get; set; }
        public virtual DbSet<healing> healings { get; set; }
        public virtual DbSet<healing_list_pills> healing_list_pills { get; set; }
        public virtual DbSet<istoria_priemov> istoria_priemov { get; set; }
        public virtual DbSet<list_pills> list_pills { get; set; }
        public virtual DbSet<list_pills_list_tests> list_pills_list_tests { get; set; }
        public virtual DbSet<list_tests> list_tests { get; set; }
        public virtual DbSet<med_card> med_card { get; set; }
        public virtual DbSet<med_card_contra> med_card_contra { get; set; }
        public virtual DbSet<Template> Templates { get; set; }
        public virtual DbSet<TestResult> TestResults { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<registar_visits> registar_visits { get; set; }
        public virtual DbSet<visit_history> visit_history { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<contra>()
                .Property(e => e.banned_pill)
                .IsUnicode(false);

            modelBuilder.Entity<contra>()
                .HasMany(e => e.med_card_contra)
                .WithRequired(e => e.contra)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<doctor>()
                .Property(e => e.surname)
                .IsUnicode(false);

            modelBuilder.Entity<doctor>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<doctor>()
                .Property(e => e.middle_name)
                .IsUnicode(false);

            modelBuilder.Entity<doctor>()
                .Property(e => e.work_number)
                .IsUnicode(false);

            modelBuilder.Entity<doctor>()
                .Property(e => e.specialization)
                .IsUnicode(false);

            modelBuilder.Entity<doctor>()
                .HasMany(e => e.istoria_priemov)
                .WithRequired(e => e.doctor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<healing>()
                .Property(e => e.bed_rest)
                .IsUnicode(false);

            modelBuilder.Entity<healing>()
                .HasMany(e => e.istoria_priemov)
                .WithRequired(e => e.healing)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<istoria_priemov>()
                .Property(e => e.disease)
                .IsUnicode(false);

            modelBuilder.Entity<istoria_priemov>()
                .Property(e => e.time)
                .IsUnicode(false);

            modelBuilder.Entity<istoria_priemov>()
                .Property(e => e.status)
                .IsUnicode(false);

            modelBuilder.Entity<istoria_priemov>()
                .HasMany(e => e.istoria_priemov1)
                .WithOptional(e => e.istoria_priemov2)
                .HasForeignKey(e => e.ID_istoria_priemov_redirect);

            modelBuilder.Entity<list_pills>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<list_pills>()
                .Property(e => e.opisanie)
                .IsUnicode(false);

            modelBuilder.Entity<list_pills>()
                .HasMany(e => e.healing_list_pills)
                .WithRequired(e => e.list_pills)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<list_pills>()
                .HasMany(e => e.list_pills_list_tests)
                .WithRequired(e => e.list_pills)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<list_tests>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<list_tests>()
                .Property(e => e.opisanie)
                .IsUnicode(false);

            modelBuilder.Entity<list_tests>()
                .HasMany(e => e.TestResults)
                .WithRequired(e => e.list_tests)
                .HasForeignKey(e => e.TestId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<med_card>()
                .Property(e => e.surname)
                .IsUnicode(false);

            modelBuilder.Entity<med_card>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<med_card>()
                .Property(e => e.middle_name)
                .IsUnicode(false);

            modelBuilder.Entity<med_card>()
                .Property(e => e.phone_number)
                .IsUnicode(false);

            modelBuilder.Entity<med_card>()
                .Property(e => e.number_passport)
                .IsUnicode(false);

            modelBuilder.Entity<med_card>()
                .Property(e => e.seria_passport)
                .IsUnicode(false);

            modelBuilder.Entity<med_card>()
                .Property(e => e.snils)
                .IsUnicode(false);

            modelBuilder.Entity<med_card>()
                .Property(e => e.place_of_residence)
                .IsUnicode(false);

            modelBuilder.Entity<med_card>()
                .Property(e => e.settlenment)
                .IsUnicode(false);

            modelBuilder.Entity<med_card>()
                .Property(e => e.street)
                .IsUnicode(false);

            modelBuilder.Entity<med_card>()
                .Property(e => e.profession)
                .IsUnicode(false);

            modelBuilder.Entity<med_card>()
                .HasMany(e => e.healing_list_pills)
                .WithRequired(e => e.med_card)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<med_card>()
                .HasMany(e => e.istoria_priemov)
                .WithRequired(e => e.med_card)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<med_card>()
                .HasMany(e => e.list_tests)
                .WithRequired(e => e.med_card)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<med_card>()
                .HasMany(e => e.med_card_contra)
                .WithRequired(e => e.med_card)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Template>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Template>()
                .Property(e => e.Minimum)
                .IsUnicode(false);

            modelBuilder.Entity<Template>()
                .Property(e => e.Maximum)
                .IsUnicode(false);

            modelBuilder.Entity<Template>()
                .HasMany(e => e.TestResults)
                .WithRequired(e => e.Template)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .Property(e => e.server_login)
                .IsUnicode(false);

            modelBuilder.Entity<registar_visits>()
                .Property(e => e.disease)
                .IsUnicode(false);

            modelBuilder.Entity<registar_visits>()
                .Property(e => e.time)
                .IsUnicode(false);

            modelBuilder.Entity<registar_visits>()
                .Property(e => e.status)
                .IsUnicode(false);

            modelBuilder.Entity<registar_visits>()
                .Property(e => e.surname)
                .IsUnicode(false);

            modelBuilder.Entity<registar_visits>()
                .Property(e => e.middle_name)
                .IsUnicode(false);

            modelBuilder.Entity<registar_visits>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<registar_visits>()
                .Property(e => e.specialization)
                .IsUnicode(false);

            modelBuilder.Entity<registar_visits>()
                .Property(e => e.work_number)
                .IsUnicode(false);

            modelBuilder.Entity<registar_visits>()
                .Property(e => e.Expr1)
                .IsUnicode(false);

            modelBuilder.Entity<registar_visits>()
                .Property(e => e.Expr2)
                .IsUnicode(false);

            modelBuilder.Entity<registar_visits>()
                .Property(e => e.Expr3)
                .IsUnicode(false);

            modelBuilder.Entity<registar_visits>()
                .Property(e => e.phone_number)
                .IsUnicode(false);

            modelBuilder.Entity<registar_visits>()
                .Property(e => e.number_passport)
                .IsUnicode(false);

            modelBuilder.Entity<registar_visits>()
                .Property(e => e.seria_passport)
                .IsUnicode(false);

            modelBuilder.Entity<registar_visits>()
                .Property(e => e.snils)
                .IsUnicode(false);

            modelBuilder.Entity<registar_visits>()
                .Property(e => e.place_of_residence)
                .IsUnicode(false);

            modelBuilder.Entity<registar_visits>()
                .Property(e => e.settlenment)
                .IsUnicode(false);

            modelBuilder.Entity<registar_visits>()
                .Property(e => e.street)
                .IsUnicode(false);

            modelBuilder.Entity<visit_history>()
                .Property(e => e.surname)
                .IsUnicode(false);

            modelBuilder.Entity<visit_history>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<visit_history>()
                .Property(e => e.middle_name)
                .IsUnicode(false);

            modelBuilder.Entity<visit_history>()
                .Property(e => e.work_number)
                .IsUnicode(false);

            modelBuilder.Entity<visit_history>()
                .Property(e => e.specialization)
                .IsUnicode(false);

            modelBuilder.Entity<visit_history>()
                .Property(e => e.disease)
                .IsUnicode(false);

            modelBuilder.Entity<visit_history>()
                .Property(e => e.time)
                .IsUnicode(false);

            modelBuilder.Entity<visit_history>()
                .Property(e => e.status)
                .IsUnicode(false);

            modelBuilder.Entity<visit_history>()
                .Property(e => e.Expr1)
                .IsUnicode(false);

            modelBuilder.Entity<visit_history>()
                .Property(e => e.Expr2)
                .IsUnicode(false);

            modelBuilder.Entity<visit_history>()
                .Property(e => e.Expr3)
                .IsUnicode(false);

            modelBuilder.Entity<visit_history>()
                .Property(e => e.phone_number)
                .IsUnicode(false);

            modelBuilder.Entity<visit_history>()
                .Property(e => e.number_passport)
                .IsUnicode(false);

            modelBuilder.Entity<visit_history>()
                .Property(e => e.seria_passport)
                .IsUnicode(false);

            modelBuilder.Entity<visit_history>()
                .Property(e => e.snils)
                .IsUnicode(false);

            modelBuilder.Entity<visit_history>()
                .Property(e => e.place_of_residence)
                .IsUnicode(false);

            modelBuilder.Entity<visit_history>()
                .Property(e => e.settlenment)
                .IsUnicode(false);

            modelBuilder.Entity<visit_history>()
                .Property(e => e.street)
                .IsUnicode(false);

            modelBuilder.Entity<visit_history>()
                .Property(e => e.profession)
                .IsUnicode(false);
        }
    }
}
