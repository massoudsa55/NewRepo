using System.Data.Entity;

namespace Gestion_Cabinet_Medical.DAL
{
    public partial class Database : DbContext
    {
        public Database()
            : base("name=Database")
        {
        }

        public virtual DbSet<Analyse> Analyse { get; set; }
        public virtual DbSet<Antecedents> Antecedents { get; set; }
        public virtual DbSet<Attende> Attende { get; set; }
        public virtual DbSet<Bilans> Bilans { get; set; }
        public virtual DbSet<BilansCategories> BilansCategories { get; set; }
        public virtual DbSet<CabientMedical> CabientMedical { get; set; }
        public virtual DbSet<Civilite> Civilite { get; set; }
        public virtual DbSet<Consultations> Consultations { get; set; }
        public virtual DbSet<Daira> Daira { get; set; }
        public virtual DbSet<EtatMaladie> EtatMaladie { get; set; }
        public virtual DbSet<FamAnalyse> FamAnalyse { get; set; }
        public virtual DbSet<GroupeSanguin> GroupeSanguin { get; set; }
        public virtual DbSet<Medicament> Medicament { get; set; }
        public virtual DbSet<ModePaiement> ModePaiement { get; set; }
        public virtual DbSet<Motifs> Motifs { get; set; }
        public virtual DbSet<Ordonnances> Ordonnances { get; set; }
        public virtual DbSet<Paiement> Paiement { get; set; }
        public virtual DbSet<Patient> Patient { get; set; }
        public virtual DbSet<Pays> Pays { get; set; }
        public virtual DbSet<Permissions> Permissions { get; set; }
        public virtual DbSet<Posologies> Posologies { get; set; }
        public virtual DbSet<Quantites> Quantites { get; set; }
        public virtual DbSet<Radiographie> Radiographie { get; set; }
        public virtual DbSet<Radiologie> Radiologie { get; set; }
        public virtual DbSet<RanduFaut> RanduFaut { get; set; }
        public virtual DbSet<Sexe> Sexe { get; set; }
        public virtual DbSet<SituationFam> SituationFam { get; set; }
        public virtual DbSet<StatusAttende> StatusAttende { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Test> Test { get; set; }
        public virtual DbSet<TypePaiement> TypePaiement { get; set; }
        public virtual DbSet<TypeRanduFaut> TypeRanduFaut { get; set; }
        public virtual DbSet<TypeUser> TypeUser { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Vaccins> Vaccins { get; set; }
        public virtual DbSet<Wilaya> Wilaya { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Analyse>()
                .HasMany(e => e.Test)
                .WithOptional(e => e.Analyse)
                .WillCascadeOnDelete();

            modelBuilder.Entity<CabientMedical>()
                .HasMany(e => e.Paiement)
                .WithOptional(e => e.CabientMedical)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Consultations>()
                .HasOptional(e => e.Antecedents)
                .WithRequired(e => e.Consultations)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Consultations>()
                .HasOptional(e => e.Ordonnances)
                .WithRequired(e => e.Consultations)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Consultations>()
                .HasMany(e => e.Paiement)
                .WithOptional(e => e.Consultations)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Daira>()
                .HasMany(e => e.Patient)
                .WithOptional(e => e.Daira)
                .WillCascadeOnDelete();

            modelBuilder.Entity<EtatMaladie>()
                .HasMany(e => e.Attende)
                .WithOptional(e => e.EtatMaladie)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Medicament>()
                .HasMany(e => e.Ordonnances)
                .WithOptional(e => e.Medicament)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Motifs>()
                .HasMany(e => e.Consultations)
                .WithOptional(e => e.Motifs)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Permissions>()
                .HasMany(e => e.TypeUser)
                .WithOptional(e => e.Permissions)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Posologies>()
                .HasMany(e => e.Ordonnances)
                .WithOptional(e => e.Posologies)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Quantites>()
                .HasMany(e => e.Ordonnances)
                .WithOptional(e => e.Quantites)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Radiographie>()
                .HasMany(e => e.Test)
                .WithOptional(e => e.Radiographie)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Radiologie>()
                .HasMany(e => e.Test)
                .WithOptional(e => e.Radiologie)
                .WillCascadeOnDelete();

            modelBuilder.Entity<StatusAttende>()
                .HasMany(e => e.Attende)
                .WithOptional(e => e.StatusAttende)
                .WillCascadeOnDelete();

            modelBuilder.Entity<TypeRanduFaut>()
                .HasMany(e => e.RanduFaut)
                .WithOptional(e => e.TypeRanduFaut)
                .WillCascadeOnDelete();

            modelBuilder.Entity<TypeUser>()
                .HasMany(e => e.Users)
                .WithOptional(e => e.TypeUser)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Paiement)
                .WithRequired(e => e.Users)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Vaccins>()
                .HasMany(e => e.Ordonnances)
                .WithOptional(e => e.Vaccins)
                .WillCascadeOnDelete();
        }
    }
}
