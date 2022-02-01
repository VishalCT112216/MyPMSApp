using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace InboxAPI.Models
{
    public partial class PMSContext : DbContext
    {
        public PMSContext()
        {
        }

        public PMSContext(DbContextOptions<PMSContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Allergy> Allergy { get; set; }
        public virtual DbSet<Diagnosis> Diagnosis { get; set; }
        public virtual DbSet<Drug> Drug { get; set; }
        public virtual DbSet<Login> Login { get; set; }
        public virtual DbSet<PatientAllergyInfo> PatientAllergyInfo { get; set; }
        public virtual DbSet<PatientDemoInfo> PatientDemoInfo { get; set; }
        public virtual DbSet<PatientDiagnosisInfo> PatientDiagnosisInfo { get; set; }
        public virtual DbSet<PatientMedicationInfo> PatientMedicationInfo { get; set; }
        public virtual DbSet<PatientProcedureInfo> PatientProcedureInfo { get; set; }
        public virtual DbSet<PatientVitalSignInfo> PatientVitalSignInfo { get; set; }
        public virtual DbSet<ProcedureData> ProcedureData { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Scheduling> Scheduling { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
               //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=IMCCBCP268-MSL2\\SQLEXPRESS2019;Initial Catalog=PMS;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Allergy>(entity =>
            {
                entity.HasKey(e => e.AllergyId)
                    .HasName("PK__Allergy__A49EBE423BC4C87C");

                entity.Property(e => e.AllergyId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AllergyName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AllergyType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClinicalInfo)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Diagnosis>(entity =>
            {
                entity.HasKey(e => e.DiagnosisId)
                    .HasName("PK__Diagnosi__0C54CC73A0C406C9");

                entity.Property(e => e.DiagnosisCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.DiagnosisDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DiagnosisIsDepricated)
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Drug>(entity =>
            {
                entity.Property(e => e.DrugBrandName)
                    .HasColumnName("Drug_Brand_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DrugForm)
                    .HasColumnName("Drug_Form")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DrugGenericName)
                    .HasColumnName("Drug_Generic_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DrugId)
                    .HasColumnName("Drug_ID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DrugName)
                    .HasColumnName("Drug_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DrugStrength)
                    .HasColumnName("Drug_Strength")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Login>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__Login__206D917016BF7F53");

                entity.Property(e => e.UserId).HasColumnName("User_Id");

                entity.Property(e => e.ContactNo)
                    .HasColumnName("Contact_No")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("Created_By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("Created_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasColumnType("datetime");

                entity.Property(e => e.Doj)
                    .HasColumnName("DOJ")
                    .HasColumnType("datetime");

                entity.Property(e => e.EmailId)
                    .HasColumnName("Email_Id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Firstname)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Lastname)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OldPassword)
                    .HasColumnName("Old_Password")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RoleId).HasColumnName("Role_Id");

                entity.Property(e => e.Status)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Login)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK__Login__Role_Id__3B75D760");
            });

            modelBuilder.Entity<PatientAllergyInfo>(entity =>
            {
                entity.HasKey(e => e.PatientAllergyInfoId)
                    .HasName("PK__PatientA__CFE0EBC996EB59C8");

                entity.Property(e => e.AllergyDescription)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.AllergyId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AllergyName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AllergyType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClinicalInfo)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IsFatal)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("User_Id");
            });

            modelBuilder.Entity<PatientDemoInfo>(entity =>
            {
                entity.HasKey(e => e.PatientDemoInfoId)
                    .HasName("PK__PatientD__C5B1958620BB1FAD");

                entity.Property(e => e.Age)
                    .HasColumnName("age")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNumber)
                    .HasColumnName("contactNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("createdDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dob)
                    .HasColumnName("dob")
                    .HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmergencyAddress)
                    .HasColumnName("emergencyAddress")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmergencyEmail)
                    .HasColumnName("emergencyEmail")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmergencyFname)
                    .HasColumnName("emergencyFname")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmergencyLname)
                    .HasColumnName("emergencyLname")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmergencyMobileNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ethinicity)
                    .HasColumnName("ethinicity")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fname)
                    .HasColumnName("fname")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasColumnName("gender")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HomeAddress)
                    .HasColumnName("homeAddress")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LanguagesKnown)
                    .HasColumnName("languagesKnown")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Lname)
                    .HasColumnName("lname")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Portalaccess)
                    .HasColumnName("portalaccess")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Race)
                    .HasColumnName("race")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Relationship)
                    .HasColumnName("relationship")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TypeofAllergies)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("User_Id");
            });

            modelBuilder.Entity<PatientDiagnosisInfo>(entity =>
            {
                entity.HasKey(e => e.PatientDiagnosisInfoId)
                    .HasName("PK__PatientD__6A254563878793C7");

                entity.Property(e => e.CreatedBy).HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("Created_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.DiagnosisCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.DiagnosisDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DiagnosisIsDepricated)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.PatientId).HasColumnName("Patient_Id");

                entity.Property(e => e.PhysicianId).HasColumnName("Physician_Id");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.PatientDiagnosisInfoCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK__PatientDi__Creat__3C69FB99");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.PatientDiagnosisInfoPatient)
                    .HasForeignKey(d => d.PatientId)
                    .HasConstraintName("FK__PatientDi__Patie__3D5E1FD2");

                entity.HasOne(d => d.Physician)
                    .WithMany(p => p.PatientDiagnosisInfoPhysician)
                    .HasForeignKey(d => d.PhysicianId)
                    .HasConstraintName("FK__PatientDi__Physi__3E52440B");
            });

            modelBuilder.Entity<PatientMedicationInfo>(entity =>
            {
                entity.HasKey(e => e.PatientMedicationInfoId)
                    .HasName("PK__PatientM__0DFA37D7064F6EB4");

                entity.Property(e => e.CreatedBy).HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("Created_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.DrugBrandName)
                    .HasColumnName("Drug_Brand_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DrugForm)
                    .HasColumnName("Drug_Form")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DrugGenericName)
                    .HasColumnName("Drug_Generic_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DrugId)
                    .HasColumnName("Drug_ID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DrugName)
                    .HasColumnName("Drug_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DrugStrength)
                    .HasColumnName("Drug_Strength")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PatientId).HasColumnName("Patient_Id");

                entity.Property(e => e.PhysicianId).HasColumnName("Physician_Id");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.PatientMedicationInfoCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK__PatientMe__Creat__3F466844");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.PatientMedicationInfoPatient)
                    .HasForeignKey(d => d.PatientId)
                    .HasConstraintName("FK__PatientMe__Patie__403A8C7D");

                entity.HasOne(d => d.Physician)
                    .WithMany(p => p.PatientMedicationInfoPhysician)
                    .HasForeignKey(d => d.PhysicianId)
                    .HasConstraintName("FK__PatientMe__Physi__412EB0B6");
            });

            modelBuilder.Entity<PatientProcedureInfo>(entity =>
            {
                entity.HasKey(e => e.PatientProcedureInfoId)
                    .HasName("PK__PatientP__DF114ABA9ABD125B");

                entity.Property(e => e.CreatedBy).HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("Created_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PatientId).HasColumnName("Patient_Id");

                entity.Property(e => e.PhysicianId).HasColumnName("Physician_Id");

                entity.Property(e => e.ProcedureCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ProcedureDescription)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ProcedureIsDepricated)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.PatientProcedureInfoCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK__PatientPr__Creat__4222D4EF");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.PatientProcedureInfoPatient)
                    .HasForeignKey(d => d.PatientId)
                    .HasConstraintName("FK__PatientPr__Patie__4316F928");
            });

            modelBuilder.Entity<PatientVitalSignInfo>(entity =>
            {
                entity.HasKey(e => e.PatientVitalSignInfoId)
                    .HasName("PK__PatientV__4C8A2F1A1EEA13A9");

                entity.Property(e => e.BloodPressure).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.BodyTemperature).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CreatedBy).HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("Created_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Height).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PatientId).HasColumnName("Patient_Id");

                entity.Property(e => e.PhysicianId).HasColumnName("Physician_Id");

                entity.Property(e => e.RespirationRate).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Weight).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.PatientVitalSignInfoCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK__PatientVi__Creat__440B1D61");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.PatientVitalSignInfoPatient)
                    .HasForeignKey(d => d.PatientId)
                    .HasConstraintName("FK__PatientVi__Patie__44FF419A");

                entity.HasOne(d => d.Physician)
                    .WithMany(p => p.PatientVitalSignInfoPhysician)
                    .HasForeignKey(d => d.PhysicianId)
                    .HasConstraintName("FK__PatientVi__Physi__45F365D3");
            });

            modelBuilder.Entity<ProcedureData>(entity =>
            {
                entity.HasKey(e => e.ProcedureId)
                    .HasName("PK__Procedur__54C2E52D89BD1E07");

                entity.Property(e => e.ProcedureCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ProcedureDescription)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ProcedureIsDepricated)
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasKey(e => e.RoleId)
                    .HasName("PK__Role__D80AB4BB6CC09E02");

                entity.Property(e => e.RoleId).HasColumnName("Role_Id");

                entity.Property(e => e.RoleName)
                    .HasColumnName("Role_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Scheduling>(entity =>
            {
                entity.Property(e => e.SchedulingId).HasColumnName("Scheduling_Id");

                entity.Property(e => e.CreatedBy).HasColumnName("Created_By");

                entity.Property(e => e.DateOfAppointment).HasColumnType("datetime");

                entity.Property(e => e.DescriptiveInformation)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingTitle)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PatientId).HasColumnName("Patient_Id");

                entity.Property(e => e.PhysicianId).HasColumnName("Physician_Id");

                entity.Property(e => e.TimeOfAppointment)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.SchedulingCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK__Schedulin__Creat__46E78A0C");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.SchedulingPatient)
                    .HasForeignKey(d => d.PatientId)
                    .HasConstraintName("FK__Schedulin__Patie__47DBAE45");

                entity.HasOne(d => d.Physician)
                    .WithMany(p => p.SchedulingPhysician)
                    .HasForeignKey(d => d.PhysicianId)
                    .HasConstraintName("FK__Schedulin__Physi__48CFD27E");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
