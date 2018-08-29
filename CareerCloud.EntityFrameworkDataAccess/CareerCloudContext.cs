using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.EntityFrameworkDataAccess
{
    public class CareerCloudContext : DbContext
    {
        public CareerCloudContext() :  base(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString)
        {
            
        }

        public DbSet<ApplicantEducationPoco> ApplicantEducations { get; set; }
        public DbSet<ApplicantJobApplicationPoco> ApplicantJobApplications { get; set; }
        public DbSet<ApplicantProfilePoco> ApplicantProfiles { get; set; }
        public DbSet<ApplicantResumePoco> ApplicantResumes { get; set; }
        public DbSet<ApplicantSkillPoco> ApplicantSkills { get; set; }
        public DbSet<ApplicantWorkHistoryPoco> ApplicantWorkHistories { get; set; }
        public DbSet<CompanyDescriptionPoco> CompanyDescriptions { get; set; }
        public DbSet<CompanyJobDescriptionPoco> CompanyJobDescriptions { get; set; }
        public DbSet<CompanyJobEducationPoco> CompanyJobEducations { get; set; }
        public DbSet<CompanyJobPoco> CompanyJobs { get; set; }
        public DbSet<CompanyJobSkillPoco> CompanyJobSkills { get; set; }
        public DbSet<CompanyLocationPoco> CompanyLocations { get; set; }
        public DbSet<CompanyProfilePoco> CompanyProfiles { get; set; }
        public DbSet<SecurityLoginPoco> SecurityLogins { get; set; }
        public DbSet<SecurityLoginsLogPoco> SecurityLoginsLogs { get; set; }
        public DbSet<SecurityLoginsRolePoco> SecurityLoginsRoles { get; set; }
        public DbSet<SecurityRolePoco> SecurityRoles { get; set; }
        public DbSet<SystemCountryCodePoco> SystemCountryCodes { get; set; }
        public DbSet<SystemLanguageCodePoco> SystemLanguageCodes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
         
            modelBuilder.Entity<ApplicantEducationPoco>()
                .HasKey(ae => ae.Id);
            modelBuilder.Entity<ApplicantEducationPoco>()
                .Property(ae => ae.Applicant).IsRequired();
            modelBuilder.Entity<ApplicantEducationPoco>()
                .Property(ae => ae.Major).IsRequired();
            modelBuilder.Entity<ApplicantEducationPoco>()
                .Property(ae => ae.CertificateDiploma).IsRequired();
            modelBuilder.Entity<ApplicantEducationPoco>()
                .Property(ae => ae.StartDate).IsOptional();
            modelBuilder.Entity<ApplicantEducationPoco>()
                .Property(ae => ae.CompletionDate).IsOptional();
            modelBuilder.Entity<ApplicantEducationPoco>()
                .Property(ae => ae.CompletionPercent).IsOptional();
            modelBuilder.Entity<ApplicantEducationPoco>()
                .Property(ae => ae.TimeStamp).IsRowVersion();
             

            modelBuilder.Entity<ApplicantJobApplicationPoco>()
                .HasKey(aja => aja.Id);
            modelBuilder.Entity<ApplicantJobApplicationPoco>()
                .Property(aja => aja.Applicant).IsRequired();
            modelBuilder.Entity<ApplicantJobApplicationPoco>()
                .Property(aja => aja.Job).IsRequired();
            modelBuilder.Entity<ApplicantJobApplicationPoco>()
                .Property(aja => aja.ApplicationDate).IsRequired();
            modelBuilder.Entity<ApplicantJobApplicationPoco>()
                .Property(aja => aja.TimeStamp).IsRowVersion();
            

            
            modelBuilder.Entity<ApplicantProfilePoco>()
                .HasKey(ap => ap.Id);
            modelBuilder.Entity<ApplicantProfilePoco>()
                .Property(ap => ap.CurrentSalary).IsOptional();
            modelBuilder.Entity<ApplicantProfilePoco>()
                .Property(ap => ap.CurrentRate).IsOptional();
            modelBuilder.Entity<ApplicantProfilePoco>()
                .Property(ap => ap.Currency).IsRequired();
            modelBuilder.Entity<ApplicantProfilePoco>()
                .Property(ap => ap.Country).IsRequired();
            modelBuilder.Entity<ApplicantProfilePoco>()
                .Property(ap => ap.Province).IsRequired();
            modelBuilder.Entity<ApplicantProfilePoco>()
                .Property(ap => ap.Street).IsRequired();
            modelBuilder.Entity<ApplicantProfilePoco>()
                .Property(ap => ap.City).IsRequired();
            modelBuilder.Entity<ApplicantProfilePoco>()
                .Property(ap => ap.PostalCode).IsRequired();
            modelBuilder.Entity<ApplicantProfilePoco>()
                .Property(ap => ap.TimeStamp).IsRowVersion();
            

            
            modelBuilder.Entity<ApplicantResumePoco>()
                .HasKey(ar => ar.Id);
            modelBuilder.Entity<ApplicantResumePoco>()
                .Property(ar => ar.Applicant).IsRequired();
            modelBuilder.Entity<ApplicantResumePoco>()
                .Property(ar => ar.Resume).IsRequired();
            modelBuilder.Entity<ApplicantResumePoco>()
                .Property(ar => ar.LastUpdated).IsOptional();
            

            
            modelBuilder.Entity<ApplicantSkillPoco>()
                .HasKey(aps => aps.Id);
            modelBuilder.Entity<ApplicantSkillPoco>()
                .Property(aps => aps.Applicant).IsRequired();
            modelBuilder.Entity<ApplicantSkillPoco>()
                .Property(aps => aps.Skill).IsRequired();
            modelBuilder.Entity<ApplicantSkillPoco>()
                .Property(aps => aps.SkillLevel).IsRequired();
            modelBuilder.Entity<ApplicantSkillPoco>()
                .Property(aps => aps.StartMonth).IsRequired();
            modelBuilder.Entity<ApplicantSkillPoco>()
                .Property(aps => aps.StartYear).IsRequired();
            modelBuilder.Entity<ApplicantSkillPoco>()
                .Property(aps => aps.EndMonth).IsRequired();
            modelBuilder.Entity<ApplicantSkillPoco>()
                .Property(aps => aps.EndYear).IsRequired();
            modelBuilder.Entity<ApplicantSkillPoco>()
                .Property(aps => aps.TimeStamp).IsRowVersion();
            

            
            modelBuilder.Entity<ApplicantWorkHistoryPoco>()
                .HasKey(aw => aw.Id);
            modelBuilder.Entity<ApplicantWorkHistoryPoco>()
                .Property(aw => aw.Applicant).IsRequired();
            modelBuilder.Entity<ApplicantWorkHistoryPoco>()
                .Property(aw => aw.CompanyName).IsRequired();
            modelBuilder.Entity<ApplicantWorkHistoryPoco>()
                .Property(aw => aw.CountryCode).IsRequired();
            modelBuilder.Entity<ApplicantWorkHistoryPoco>()
                .Property(aw => aw.Location).IsRequired();
            modelBuilder.Entity<ApplicantWorkHistoryPoco>()
                .Property(aw => aw.JobTitle).IsRequired();
            modelBuilder.Entity<ApplicantWorkHistoryPoco>()
                .Property(aw => aw.JobDescription).IsRequired();
            modelBuilder.Entity<ApplicantWorkHistoryPoco>()
                .Property(aw => aw.StartMonth).IsRequired();
            modelBuilder.Entity<ApplicantWorkHistoryPoco>()
                .Property(aw => aw.StartYear).IsRequired();
            modelBuilder.Entity<ApplicantWorkHistoryPoco>()
                .Property(aw => aw.EndMonth).IsRequired();
            modelBuilder.Entity<ApplicantWorkHistoryPoco>()
                .Property(aw => aw.EndYear).IsRequired();
            modelBuilder.Entity<ApplicantWorkHistoryPoco>()
                .Property(aw => aw.TimeStamp).IsRowVersion();
            

            
            modelBuilder.Entity<CompanyDescriptionPoco>()
                .HasKey(cd => cd.Id);
            modelBuilder.Entity<CompanyDescriptionPoco>()
                .Property(cd => cd.Company).IsRequired();
            modelBuilder.Entity<CompanyDescriptionPoco>()
                .Property(cd => cd.LanguageId).IsRequired();
            modelBuilder.Entity<CompanyDescriptionPoco>()
                .Property(cd => cd.CompanyName).IsRequired();
            modelBuilder.Entity<CompanyDescriptionPoco>()
                .Property(cd => cd.CompanyDescription).IsRequired();
            modelBuilder.Entity<CompanyDescriptionPoco>()
                .Property(cd => cd.TimeStamp).IsRowVersion();
            

            
            modelBuilder.Entity<CompanyJobDescriptionPoco>()
                .HasKey(cjd => cjd.Id);
            modelBuilder.Entity<CompanyJobDescriptionPoco>()
                .Property(cjd => cjd.Job).IsRequired();
            modelBuilder.Entity<CompanyJobDescriptionPoco>()
                .Property(cjd => cjd.JobName).IsRequired();
            modelBuilder.Entity<CompanyJobDescriptionPoco>()
                .Property(cjd => cjd.JobDescriptions).IsRequired();
            modelBuilder.Entity<CompanyJobDescriptionPoco>()
                .Property(cjd => cjd.TimeStamp).IsRowVersion();
            

           
            modelBuilder.Entity<CompanyJobEducationPoco>()
                .HasKey(cje => cje.Id);
            modelBuilder.Entity<CompanyJobEducationPoco>()
                .Property(cje => cje.Job).IsRequired();
            modelBuilder.Entity<CompanyJobEducationPoco>()
                .Property(cje => cje.Major).IsRequired();
            modelBuilder.Entity<CompanyJobEducationPoco>()
                .Property(cje => cje.Importance).IsRequired();
            modelBuilder.Entity<CompanyJobEducationPoco>()
                .Property(cje => cje.TimeStamp).IsRowVersion();
            

            
            modelBuilder.Entity<CompanyJobPoco>()
                .HasKey(cj => cj.Id);
            modelBuilder.Entity<CompanyJobPoco>()
                .Property(cj => cj.Company).IsRequired();
            modelBuilder.Entity<CompanyJobPoco>()
                .Property(cj => cj.ProfileCreated).IsRequired();
            modelBuilder.Entity<CompanyJobPoco>()
                .Property(cj => cj.IsInactive).IsRequired();
            modelBuilder.Entity<CompanyJobPoco>()
                .Property(cj => cj.IsCompanyHidden).IsRequired();
            modelBuilder.Entity<CompanyJobPoco>()
                .Property(cj => cj.TimeStamp).IsRowVersion();
            

            
            modelBuilder.Entity<CompanyJobSkillPoco>()
                .HasKey(cjs => cjs.Id);
            modelBuilder.Entity<CompanyJobSkillPoco>()
                .Property(cjs => cjs.Job).IsRequired();
            modelBuilder.Entity<CompanyJobSkillPoco>()
                .Property(cjs => cjs.Skill).IsRequired();
            modelBuilder.Entity<CompanyJobSkillPoco>()
                .Property(cjs => cjs.SkillLevel).IsRequired();
            modelBuilder.Entity<CompanyJobSkillPoco>()
                .Property(cjs => cjs.Importance).IsRequired();
            modelBuilder.Entity<CompanyJobSkillPoco>()
                .Property(cjs => cjs.TimeStamp).IsRowVersion();
            

            
            modelBuilder.Entity<CompanyLocationPoco>()
                .HasKey(cl => cl.Id);
            modelBuilder.Entity<CompanyLocationPoco>()
                .Property(cl => cl.Company).IsRequired();
            modelBuilder.Entity<CompanyLocationPoco>()
                .Property(cl => cl.CountryCode).IsRequired();
            modelBuilder.Entity<CompanyLocationPoco>()
                .Property(cl => cl.Province).IsRequired();
            modelBuilder.Entity<CompanyLocationPoco>()
                .Property(cl => cl.Street).IsRequired();
            modelBuilder.Entity<CompanyLocationPoco>()
                .Property(cl => cl.City).IsRequired();
            modelBuilder.Entity<CompanyLocationPoco>()
                .Property(cl => cl.PostalCode).IsRequired();
            modelBuilder.Entity<CompanyLocationPoco>()
                .Property(cl => cl.TimeStamp).IsRowVersion();
            

            
            modelBuilder.Entity<CompanyProfilePoco>()
                .HasKey(cp => cp.Id);
            modelBuilder.Entity<CompanyProfilePoco>()
                .Property(cp => cp.RegistrationDate).IsRequired();
            modelBuilder.Entity<CompanyProfilePoco>()
                .Property(cp => cp.CompanyWebsite).IsRequired();
            modelBuilder.Entity<CompanyProfilePoco>()
                .Property(cp => cp.ContactPhone).IsRequired();
            modelBuilder.Entity<CompanyProfilePoco>()
                .Property(cp => cp.ContactName).IsRequired();
            modelBuilder.Entity<CompanyProfilePoco>()
                .Property(cp => cp.CompanyLogo).IsRequired();
            modelBuilder.Entity<CompanyProfilePoco>()
                .Property(cp => cp.TimeStamp).IsRowVersion();
            

            
            modelBuilder.Entity<SecurityLoginPoco>()
                .HasKey(sl => sl.Id);
            modelBuilder.Entity<SecurityLoginPoco>()
                .Property(sl => sl.Login).IsRequired();
            modelBuilder.Entity<SecurityLoginPoco>()
                .Property(sl => sl.Password).IsRequired();
            modelBuilder.Entity<SecurityLoginPoco>()
                .Property(sl => sl.Created).IsRequired();
            modelBuilder.Entity<SecurityLoginPoco>()
                .Property(sl => sl.PasswordUpdate).IsOptional();
            modelBuilder.Entity<SecurityLoginPoco>()
                .Property(sl => sl.AgreementAccepted).IsOptional();
            modelBuilder.Entity<SecurityLoginPoco>()
                .Property(sl => sl.IsLocked).IsRequired();
            modelBuilder.Entity<SecurityLoginPoco>()
                .Property(sl => sl.IsInactive).IsRequired();
            modelBuilder.Entity<SecurityLoginPoco>()
                .Property(sl => sl.EmailAddress).IsRequired();
            modelBuilder.Entity<SecurityLoginPoco>()
                .Property(sl => sl.PhoneNumber).IsRequired();
            modelBuilder.Entity<SecurityLoginPoco>()
                .Property(sl => sl.FullName).IsRequired();
            modelBuilder.Entity<SecurityLoginPoco>()
                .Property(sl => sl.ForceChangePassword).IsRequired();
            modelBuilder.Entity<SecurityLoginPoco>()
                .Property(sl => sl.PrefferredLanguage).IsRequired();
            modelBuilder.Entity<SecurityLoginPoco>()
                .Property(sl => sl.TimeStamp).IsRowVersion();
            

            
            modelBuilder.Entity<SecurityLoginsLogPoco>()
                .HasKey(sll => sll.Id);
            modelBuilder.Entity<SecurityLoginsLogPoco>()
                .Property(sll => sll.Login).IsRequired();
            modelBuilder.Entity<SecurityLoginsLogPoco>()
                .Property(sll => sll.SourceIP).IsRequired();
            modelBuilder.Entity<SecurityLoginsLogPoco>()
                .Property(sll => sll.LogonDate).IsRequired();
            modelBuilder.Entity<SecurityLoginsLogPoco>()
                .Property(sll => sll.IsSuccesful).IsRequired();
           

            
            modelBuilder.Entity<SecurityLoginsRolePoco>()
                .HasKey(slr => slr.Id);
            modelBuilder.Entity<SecurityLoginsRolePoco>()
                .Property(slr => slr.Login).IsRequired();
            modelBuilder.Entity<SecurityLoginsRolePoco>()
                .Property(slr => slr.Role).IsRequired();
            modelBuilder.Entity<SecurityLoginsRolePoco>()
                .Property(slr => slr.TimeStamp).IsRowVersion();
            

            
            modelBuilder.Entity<SecurityRolePoco>()
                .HasKey(sr => sr.Id);
            modelBuilder.Entity<SecurityRolePoco>()
                .Property(sr => sr.Role).IsRequired();
            modelBuilder.Entity<SecurityRolePoco>()
                .Property(sr => sr.IsInactive).IsRequired();
            

           
            modelBuilder.Entity<SystemCountryCodePoco>()
                .HasKey(scc => scc.Code);
            modelBuilder.Entity<SystemCountryCodePoco>()
                .Property(scc => scc.Name).IsRequired();
           

            
            modelBuilder.Entity<SystemLanguageCodePoco>()
                .HasKey(slc => slc.LanguageID);
            modelBuilder.Entity<SystemLanguageCodePoco>()
                .Property(slc => slc.Name).IsRequired();
            modelBuilder.Entity<SystemLanguageCodePoco>()
                .Property(slc => slc.NativeName).IsRequired();
            

           
            
            modelBuilder.Entity<ApplicantProfilePoco>()
                .HasMany(ap => ap.ApplicantEducations)
                .WithRequired(ap => ap.ApplicantProfile)
                .HasForeignKey(ap => ap.Applicant)
                .WillCascadeOnDelete(false);
            modelBuilder.Entity<ApplicantProfilePoco>()
                .HasMany(ap => ap.ApplicantJobApplications)
                .WithRequired(ap => ap.ApplicantProfile)
                .HasForeignKey(ap => ap.Applicant)
                .WillCascadeOnDelete(false);
            modelBuilder.Entity<ApplicantProfilePoco>()
                .HasMany(ap => ap.ApplicantResumes)
                .WithRequired(ap => ap.ApplicantProfile)
                .HasForeignKey(ap => ap.Applicant)
                .WillCascadeOnDelete(false);
            modelBuilder.Entity<ApplicantProfilePoco>()
                .HasMany(ap => ap.ApplicantSkills)
                .WithRequired(ap => ap.ApplicantProfile)
                .HasForeignKey(ap => ap.Applicant)
                .WillCascadeOnDelete(false);
            modelBuilder.Entity<ApplicantProfilePoco>()
                .HasMany(ap => ap.ApplicantWorkHistories)
                .WithRequired(ap => ap.ApplicantProfile)
                .HasForeignKey(ap => ap.Applicant)
                .WillCascadeOnDelete(false);
            

            
            modelBuilder.Entity<CompanyJobPoco>()
                .HasMany(cj => cj.ApplicantJobApplications)
                .WithRequired(cj => cj.CompanyJob)
                .HasForeignKey(cj => cj.Job)
                .WillCascadeOnDelete(false);
            modelBuilder.Entity<CompanyJobPoco>()
                .HasMany(cj => cj.CompanyJobDescriptions)
                .WithRequired(cj => cj.CompanyJob)
                .HasForeignKey(cj => cj.Job)
                .WillCascadeOnDelete(false);
            modelBuilder.Entity<CompanyJobPoco>()
                .HasMany(cj => cj.CompanyJobEducations)
                .WithRequired(cj => cj.CompanyJob)
                .HasForeignKey(cj => cj.Job)
                .WillCascadeOnDelete(false);
            modelBuilder.Entity<CompanyJobPoco>()
                .HasMany(cj => cj.CompanyJobSkills)
                .WithRequired(cj => cj.CompanyJob)
                .HasForeignKey(cj => cj.Job)
                .WillCascadeOnDelete(false);

           // modelBuilder.Entity<CompanyJobPoco>()
           //.HasRequired<CompanyProfilePoco>(s => s.CompanyProfile)
           //.WithMany(g => g.CompanyJobs)
          // .HasForeignKey<Guid>(s => s.Id);


            modelBuilder.Entity<CompanyProfilePoco>()
                .HasMany(cj => cj.CompanyDescriptions)
                .WithRequired(cj => cj.CompanyProfile)
                .HasForeignKey(cj => cj.Company)
                .WillCascadeOnDelete(false);
            modelBuilder.Entity<CompanyProfilePoco>()
                .HasMany(cj => cj.CompanyLocations)
                .WithRequired(cj => cj.CompanyProfile)
                .HasForeignKey(cj => cj.Company)
                .WillCascadeOnDelete(false);
            

            
            modelBuilder.Entity<SecurityLoginPoco>()
                .HasMany(cj => cj.ApplicantProfiles)
                .WithRequired(cj => cj.SecurityLogin)
                .HasForeignKey(cj => cj.Login)
                .WillCascadeOnDelete(false);
            modelBuilder.Entity<SecurityLoginPoco>()
                .HasMany(cj => cj.SecurityLoginsLogs)
                .WithRequired(cj => cj.SecurityLogin)
                .HasForeignKey(cj => cj.Login)
                .WillCascadeOnDelete(false);
            modelBuilder.Entity<SecurityLoginPoco>()
                .HasMany(cj => cj.SecurityLoginsRoles)
                .WithRequired(cj => cj.SecurityLogin)
                .HasForeignKey(cj => cj.Login)
                .WillCascadeOnDelete(false);
           

            
            modelBuilder.Entity<SecurityRolePoco>()
                .HasMany(cj => cj.SecurityLoginsRoles)
                .WithRequired(cj => cj.SecurityRole)
                .HasForeignKey(cj => cj.Role)
                .WillCascadeOnDelete(false);
            

           
            modelBuilder.Entity<SystemCountryCodePoco>()
                .HasMany(cj => cj.ApplicantProfiles)
                .WithRequired(cj => cj.SystemCountryCode)
                .HasForeignKey(cj => cj.Country)
                .WillCascadeOnDelete(false);
            modelBuilder.Entity<SystemCountryCodePoco>()
                .HasMany(cj => cj.ApplicantWorkHistories)
                .WithRequired(cj => cj.SystemCountryCode)
                .HasForeignKey(cj => cj.CountryCode)
                .WillCascadeOnDelete(false);
           

            
            modelBuilder.Entity<SystemLanguageCodePoco>()
                .HasMany(cj => cj.CompanyDescriptions)
                .WithRequired(cj => cj.SystemLanguageCode)
                .HasForeignKey(cj => cj.LanguageId)
                .WillCascadeOnDelete(false);
            

           

            base.OnModelCreating(modelBuilder);

        }


    }
} 
