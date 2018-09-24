using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CareerCloud.BusinessLogicLayer;
using CareerCloud.EntityFrameworkDataAccess;
using CareerCloud.Pocos;

namespace CareerCloud.WCF
{
    class Company : ICompany
    {
        public void AddCompanyDescription(CompanyDescriptionPoco[] pocos)
        {
            ApplicantProfileRepository<CompanyDescriptionPoco> repo = new ApplicantProfileRepository<CompanyDescriptionPoco>(false);
            CompanyDescriptionLogic log = new CompanyDescriptionLogic(repo);
            log.Add(pocos);
        }

        public void AddCompanyJob(CompanyJobPoco[] pocos)
        {
            ApplicantProfileRepository<CompanyJobPoco> repo = new ApplicantProfileRepository<CompanyJobPoco>(false);
            CompanyJobLogic log = new CompanyJobLogic(repo);
            log.Add(pocos);
        }

        public void AddCompanyJobDescription(CompanyJobDescriptionPoco[] pocos)
        {
            ApplicantProfileRepository<CompanyJobDescriptionPoco> repo = new ApplicantProfileRepository<CompanyJobDescriptionPoco>(false);
            CompanyJobDescriptionLogic log = new CompanyJobDescriptionLogic(repo);
            log.Add(pocos);
        }

        public void AddCompanyJobEducation(CompanyJobEducationPoco[] pocos)
        {
            ApplicantProfileRepository<CompanyJobEducationPoco> repo = new ApplicantProfileRepository<CompanyJobEducationPoco>(false);
            CompanyJobEducationLogic log = new CompanyJobEducationLogic(repo);
            log.Add(pocos);
        }

        public void AddCompanyJobSkill(CompanyJobSkillPoco[] pocos)
        {
            ApplicantProfileRepository<CompanyJobSkillPoco> repo = new ApplicantProfileRepository<CompanyJobSkillPoco>(false);
            CompanyJobSkillLogic log = new CompanyJobSkillLogic(repo);
            log.Add(pocos);
        }

        public void AddCompanyLocation(CompanyLocationPoco[] pocos)
        {
            ApplicantProfileRepository<CompanyLocationPoco> repo = new ApplicantProfileRepository<CompanyLocationPoco>(false);
            CompanyLocationLogic log = new CompanyLocationLogic(repo);
            log.Add(pocos);
        }

        public void AddCompanyProfile(CompanyProfilePoco[] pocos)
        {
            ApplicantProfileRepository<CompanyProfilePoco> repo = new ApplicantProfileRepository<CompanyProfilePoco>(false);
            CompanyProfileLogic log = new CompanyProfileLogic(repo);
            log.Add(pocos);
        }

        public List<CompanyDescriptionPoco> GetAllCompanyDescription()
        {
            ApplicantProfileRepository<CompanyDescriptionPoco> repo = new ApplicantProfileRepository<CompanyDescriptionPoco>(false);
            CompanyDescriptionLogic log = new CompanyDescriptionLogic(repo);
            return log.GetAll();
        }

        public List<CompanyJobPoco> GetAllCompanyJob()
        {
            ApplicantProfileRepository<CompanyJobPoco> repo = new ApplicantProfileRepository<CompanyJobPoco>(false);
            CompanyJobLogic log = new CompanyJobLogic(repo);
            return log.GetAll();
        }

        public List<CompanyJobDescriptionPoco> GetAllCompanyJobDescription()
        {
            ApplicantProfileRepository<CompanyJobDescriptionPoco> repo = new ApplicantProfileRepository<CompanyJobDescriptionPoco>(false);
            CompanyJobDescriptionLogic log = new CompanyJobDescriptionLogic(repo);
            return log.GetAll();
        }

        public List<CompanyJobEducationPoco> GetAllCompanyJobEducation()
        {
            ApplicantProfileRepository<CompanyJobEducationPoco> repo = new ApplicantProfileRepository<CompanyJobEducationPoco>(false);
            CompanyJobEducationLogic log = new CompanyJobEducationLogic(repo);
            return log.GetAll();
        }

        public List<CompanyJobSkillPoco> GetAllCompanyJobSkill()
        {
            ApplicantProfileRepository<CompanyJobSkillPoco> repo = new ApplicantProfileRepository<CompanyJobSkillPoco>(false);
            CompanyJobSkillLogic log = new CompanyJobSkillLogic(repo);
            return log.GetAll();
        }

        public List<CompanyLocationPoco> GetAllCompanyLocation()
        {
            ApplicantProfileRepository<CompanyLocationPoco> repo = new ApplicantProfileRepository<CompanyLocationPoco>(false);
            CompanyLocationLogic log = new CompanyLocationLogic(repo);
            return log.GetAll();
        }

        public List<CompanyProfilePoco> GetAllCompanyProfile()
        {
            ApplicantProfileRepository<CompanyProfilePoco> repo = new ApplicantProfileRepository<CompanyProfilePoco>(false);
            CompanyProfileLogic log = new CompanyProfileLogic(repo);
            return log.GetAll();
        }

        public CompanyDescriptionPoco GetSingleCompanyDescription(string Id)
        {
            ApplicantProfileRepository<CompanyDescriptionPoco> repo = new ApplicantProfileRepository<CompanyDescriptionPoco>(false);
            CompanyDescriptionLogic log = new CompanyDescriptionLogic(repo);
            return log.Get(Guid.Parse(Id));
        }

        public CompanyJobPoco GetSingleCompanyJob(string Id)
        {
            ApplicantProfileRepository<CompanyJobPoco> repo = new ApplicantProfileRepository<CompanyJobPoco>(false);
            CompanyJobLogic log = new CompanyJobLogic(repo);
            return log.Get(Guid.Parse(Id));
        }

        public CompanyJobDescriptionPoco GetSingleCompanyJobDescription(string Id)
        {
            ApplicantProfileRepository<CompanyJobDescriptionPoco> repo = new ApplicantProfileRepository<CompanyJobDescriptionPoco>(false);
            CompanyJobDescriptionLogic log = new CompanyJobDescriptionLogic(repo);
            return log.Get(Guid.Parse(Id));
        }

        public CompanyJobEducationPoco GetSingleCompanyJobEducation(string Id)
        {
            ApplicantProfileRepository<CompanyJobEducationPoco> repo = new ApplicantProfileRepository<CompanyJobEducationPoco>(false);
            CompanyJobEducationLogic log = new CompanyJobEducationLogic(repo);
            return log.Get(Guid.Parse(Id));
        }

        public CompanyJobSkillPoco GetSingleCompanyJobSkill(string Id)
        {
            ApplicantProfileRepository<CompanyJobSkillPoco> repo = new ApplicantProfileRepository<CompanyJobSkillPoco>(false);
            CompanyJobSkillLogic log = new CompanyJobSkillLogic(repo);
            return log.Get(Guid.Parse(Id));
        }

        public CompanyLocationPoco GetSingleCompanyLocation(string Id)
        {
            ApplicantProfileRepository<CompanyLocationPoco> repo = new ApplicantProfileRepository<CompanyLocationPoco>(false);
            CompanyLocationLogic log = new CompanyLocationLogic(repo);
            return log.Get(Guid.Parse(Id));
        }

        public CompanyProfilePoco GetSingleCompanyProfile(string Id)
        {
            ApplicantProfileRepository<CompanyProfilePoco> repo = new ApplicantProfileRepository<CompanyProfilePoco>(false);
            CompanyProfileLogic log = new CompanyProfileLogic(repo);
            return log.Get(Guid.Parse(Id));
        }

        public void RemoveCompanyDescription(CompanyDescriptionPoco[] pocos)
        {
            ApplicantProfileRepository<CompanyDescriptionPoco> repo = new ApplicantProfileRepository<CompanyDescriptionPoco>(false);
            CompanyDescriptionLogic log = new CompanyDescriptionLogic(repo);
            log.Delete(pocos);
        }

        public void RemoveCompanyJob(CompanyJobPoco[] pocos)
        {
            ApplicantProfileRepository<CompanyJobPoco> repo = new ApplicantProfileRepository<CompanyJobPoco>(false);
            CompanyJobLogic log = new CompanyJobLogic(repo);
            log.Delete(pocos);
        }

        public void RemoveCompanyJobDescription(CompanyJobDescriptionPoco[] pocos)
        {
            ApplicantProfileRepository<CompanyJobDescriptionPoco> repo = new ApplicantProfileRepository<CompanyJobDescriptionPoco>(false);
            CompanyJobDescriptionLogic log = new CompanyJobDescriptionLogic(repo);
            log.Delete(pocos);
        }

        public void RemoveCompanyJobEducation(CompanyJobEducationPoco[] pocos)
        {
            ApplicantProfileRepository<CompanyJobEducationPoco> repo = new ApplicantProfileRepository<CompanyJobEducationPoco>(false);
            CompanyJobEducationLogic log = new CompanyJobEducationLogic(repo);
            log.Delete(pocos);
        }

        public void RemoveCompanyJobSkill(CompanyJobSkillPoco[] pocos)
        {
            ApplicantProfileRepository<CompanyJobSkillPoco> repo = new ApplicantProfileRepository<CompanyJobSkillPoco>(false);
            CompanyJobSkillLogic log = new CompanyJobSkillLogic(repo);
            log.Delete(pocos);
        }

        public void RemoveCompanyLocation(CompanyLocationPoco[] pocos)
        {
            ApplicantProfileRepository<CompanyLocationPoco> repo = new ApplicantProfileRepository<CompanyLocationPoco>(false);
            CompanyLocationLogic log = new CompanyLocationLogic(repo);
            log.Delete(pocos);
        }

        public void RemoveCompanyProfile(CompanyProfilePoco[] pocos)
        {
            ApplicantProfileRepository<CompanyProfilePoco> repo = new ApplicantProfileRepository<CompanyProfilePoco>(false);
            CompanyProfileLogic log = new CompanyProfileLogic(repo);
            log.Delete(pocos);
        }

        public void UpdateCompanyDescription(CompanyDescriptionPoco[] pocos)
        {
            ApplicantProfileRepository<CompanyDescriptionPoco> repo = new ApplicantProfileRepository<CompanyDescriptionPoco>(false);
            CompanyDescriptionLogic log = new CompanyDescriptionLogic(repo);
            log.Update(pocos);
        }

        public void UpdateCompanyJob(CompanyJobPoco[] pocos)
        {
            ApplicantProfileRepository<CompanyJobPoco> repo = new ApplicantProfileRepository<CompanyJobPoco>(false);
            CompanyJobLogic log = new CompanyJobLogic(repo);
            log.Update(pocos);
        }

        public void UpdateCompanyJobDescription(CompanyJobDescriptionPoco[] pocos)
        {
            ApplicantProfileRepository<CompanyJobDescriptionPoco> repo = new ApplicantProfileRepository<CompanyJobDescriptionPoco>(false);
            CompanyJobDescriptionLogic log = new CompanyJobDescriptionLogic(repo);
            log.Update(pocos);
        }

        public void UpdateCompanyJobEducation(CompanyJobEducationPoco[] pocos)
        {
            ApplicantProfileRepository<CompanyJobEducationPoco> repo = new ApplicantProfileRepository<CompanyJobEducationPoco>(false);
            CompanyJobEducationLogic log = new CompanyJobEducationLogic(repo);
            log.Update(pocos);
        }

        public void UpdateCompanyJobSkill(CompanyJobSkillPoco[] pocos)
        {
            ApplicantProfileRepository<CompanyJobSkillPoco> repo = new ApplicantProfileRepository<CompanyJobSkillPoco>(false);
            CompanyJobSkillLogic log = new CompanyJobSkillLogic(repo);
            log.Update(pocos);
        }

        public void UpdateCompanyLocation(CompanyLocationPoco[] pocos)
        {
            ApplicantProfileRepository<CompanyLocationPoco> repo = new ApplicantProfileRepository<CompanyLocationPoco>(false);
            CompanyLocationLogic log = new CompanyLocationLogic(repo);
            log.Update(pocos);
        }

        public void UpdateCompanyProfile(CompanyProfilePoco[] pocos)
        {
            ApplicantProfileRepository<CompanyProfilePoco> repo = new ApplicantProfileRepository<CompanyProfilePoco>(false);
            CompanyProfileLogic log = new CompanyProfileLogic(repo);
            log.Update(pocos);
        }
    }
}
