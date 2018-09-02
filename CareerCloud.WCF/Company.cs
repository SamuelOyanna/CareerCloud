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
            EFGenericRepository<CompanyDescriptionPoco> repo = new EFGenericRepository<CompanyDescriptionPoco>(false);
            CompanyDescriptionLogic log = new CompanyDescriptionLogic(repo);
            log.Add(pocos);
        }

        public void AddCompanyJob(CompanyJobPoco[] pocos)
        {
            EFGenericRepository<CompanyJobPoco> repo = new EFGenericRepository<CompanyJobPoco>(false);
            CompanyJobLogic log = new CompanyJobLogic(repo);
            log.Add(pocos);
        }

        public void AddCompanyJobDescription(CompanyJobDescriptionPoco[] pocos)
        {
            EFGenericRepository<CompanyJobDescriptionPoco> repo = new EFGenericRepository<CompanyJobDescriptionPoco>(false);
            CompanyJobDescriptionLogic log = new CompanyJobDescriptionLogic(repo);
            log.Add(pocos);
        }

        public void AddCompanyJobEducation(CompanyJobEducationPoco[] pocos)
        {
            EFGenericRepository<CompanyJobEducationPoco> repo = new EFGenericRepository<CompanyJobEducationPoco>(false);
            CompanyJobEducationLogic log = new CompanyJobEducationLogic(repo);
            log.Add(pocos);
        }

        public void AddCompanyJobSkill(CompanyJobSkillPoco[] pocos)
        {
            EFGenericRepository<CompanyJobSkillPoco> repo = new EFGenericRepository<CompanyJobSkillPoco>(false);
            CompanyJobSkillLogic log = new CompanyJobSkillLogic(repo);
            log.Add(pocos);
        }

        public void AddCompanyLocation(CompanyLocationPoco[] pocos)
        {
            EFGenericRepository<CompanyLocationPoco> repo = new EFGenericRepository<CompanyLocationPoco>(false);
            CompanyLocationLogic log = new CompanyLocationLogic(repo);
            log.Add(pocos);
        }

        public void AddCompanyProfile(CompanyProfilePoco[] pocos)
        {
            EFGenericRepository<CompanyProfilePoco> repo = new EFGenericRepository<CompanyProfilePoco>(false);
            CompanyProfileLogic log = new CompanyProfileLogic(repo);
            log.Add(pocos);
        }

        public List<CompanyDescriptionPoco> GetAllCompanyDescription()
        {
            EFGenericRepository<CompanyDescriptionPoco> repo = new EFGenericRepository<CompanyDescriptionPoco>(false);
            CompanyDescriptionLogic log = new CompanyDescriptionLogic(repo);
            return log.GetAll();
        }

        public List<CompanyJobPoco> GetAllCompanyJob()
        {
            EFGenericRepository<CompanyJobPoco> repo = new EFGenericRepository<CompanyJobPoco>(false);
            CompanyJobLogic log = new CompanyJobLogic(repo);
            return log.GetAll();
        }

        public List<CompanyJobDescriptionPoco> GetAllCompanyJobDescription()
        {
            EFGenericRepository<CompanyJobDescriptionPoco> repo = new EFGenericRepository<CompanyJobDescriptionPoco>(false);
            CompanyJobDescriptionLogic log = new CompanyJobDescriptionLogic(repo);
            return log.GetAll();
        }

        public List<CompanyJobEducationPoco> GetAllCompanyJobEducation()
        {
            EFGenericRepository<CompanyJobEducationPoco> repo = new EFGenericRepository<CompanyJobEducationPoco>(false);
            CompanyJobEducationLogic log = new CompanyJobEducationLogic(repo);
            return log.GetAll();
        }

        public List<CompanyJobSkillPoco> GetAllCompanyJobSkill()
        {
            EFGenericRepository<CompanyJobSkillPoco> repo = new EFGenericRepository<CompanyJobSkillPoco>(false);
            CompanyJobSkillLogic log = new CompanyJobSkillLogic(repo);
            return log.GetAll();
        }

        public List<CompanyLocationPoco> GetAllCompanyLocation()
        {
            EFGenericRepository<CompanyLocationPoco> repo = new EFGenericRepository<CompanyLocationPoco>(false);
            CompanyLocationLogic log = new CompanyLocationLogic(repo);
            return log.GetAll();
        }

        public List<CompanyProfilePoco> GetAllCompanyProfile()
        {
            EFGenericRepository<CompanyProfilePoco> repo = new EFGenericRepository<CompanyProfilePoco>(false);
            CompanyProfileLogic log = new CompanyProfileLogic(repo);
            return log.GetAll();
        }

        public CompanyDescriptionPoco GetSingleCompanyDescription(string Id)
        {
            EFGenericRepository<CompanyDescriptionPoco> repo = new EFGenericRepository<CompanyDescriptionPoco>(false);
            CompanyDescriptionLogic log = new CompanyDescriptionLogic(repo);
            return log.Get(Guid.Parse(Id));
        }

        public CompanyJobPoco GetSingleCompanyJob(string Id)
        {
            EFGenericRepository<CompanyJobPoco> repo = new EFGenericRepository<CompanyJobPoco>(false);
            CompanyJobLogic log = new CompanyJobLogic(repo);
            return log.Get(Guid.Parse(Id));
        }

        public CompanyJobDescriptionPoco GetSingleCompanyJobDescription(string Id)
        {
            EFGenericRepository<CompanyJobDescriptionPoco> repo = new EFGenericRepository<CompanyJobDescriptionPoco>(false);
            CompanyJobDescriptionLogic log = new CompanyJobDescriptionLogic(repo);
            return log.Get(Guid.Parse(Id));
        }

        public CompanyJobEducationPoco GetSingleCompanyJobEducation(string Id)
        {
            EFGenericRepository<CompanyJobEducationPoco> repo = new EFGenericRepository<CompanyJobEducationPoco>(false);
            CompanyJobEducationLogic log = new CompanyJobEducationLogic(repo);
            return log.Get(Guid.Parse(Id));
        }

        public CompanyJobSkillPoco GetSingleCompanyJobSkill(string Id)
        {
            EFGenericRepository<CompanyJobSkillPoco> repo = new EFGenericRepository<CompanyJobSkillPoco>(false);
            CompanyJobSkillLogic log = new CompanyJobSkillLogic(repo);
            return log.Get(Guid.Parse(Id));
        }

        public CompanyLocationPoco GetSingleCompanyLocation(string Id)
        {
            EFGenericRepository<CompanyLocationPoco> repo = new EFGenericRepository<CompanyLocationPoco>(false);
            CompanyLocationLogic log = new CompanyLocationLogic(repo);
            return log.Get(Guid.Parse(Id));
        }

        public CompanyProfilePoco GetSingleCompanyProfile(string Id)
        {
            EFGenericRepository<CompanyProfilePoco> repo = new EFGenericRepository<CompanyProfilePoco>(false);
            CompanyProfileLogic log = new CompanyProfileLogic(repo);
            return log.Get(Guid.Parse(Id));
        }

        public void RemoveCompanyDescription(CompanyDescriptionPoco[] pocos)
        {
            EFGenericRepository<CompanyDescriptionPoco> repo = new EFGenericRepository<CompanyDescriptionPoco>(false);
            CompanyDescriptionLogic log = new CompanyDescriptionLogic(repo);
            log.Delete(pocos);
        }

        public void RemoveCompanyJob(CompanyJobPoco[] pocos)
        {
            EFGenericRepository<CompanyJobPoco> repo = new EFGenericRepository<CompanyJobPoco>(false);
            CompanyJobLogic log = new CompanyJobLogic(repo);
            log.Delete(pocos);
        }

        public void RemoveCompanyJobDescription(CompanyJobDescriptionPoco[] pocos)
        {
            EFGenericRepository<CompanyJobDescriptionPoco> repo = new EFGenericRepository<CompanyJobDescriptionPoco>(false);
            CompanyJobDescriptionLogic log = new CompanyJobDescriptionLogic(repo);
            log.Delete(pocos);
        }

        public void RemoveCompanyJobEducation(CompanyJobEducationPoco[] pocos)
        {
            EFGenericRepository<CompanyJobEducationPoco> repo = new EFGenericRepository<CompanyJobEducationPoco>(false);
            CompanyJobEducationLogic log = new CompanyJobEducationLogic(repo);
            log.Delete(pocos);
        }

        public void RemoveCompanyJobSkill(CompanyJobSkillPoco[] pocos)
        {
            EFGenericRepository<CompanyJobSkillPoco> repo = new EFGenericRepository<CompanyJobSkillPoco>(false);
            CompanyJobSkillLogic log = new CompanyJobSkillLogic(repo);
            log.Delete(pocos);
        }

        public void RemoveCompanyLocation(CompanyLocationPoco[] pocos)
        {
            EFGenericRepository<CompanyLocationPoco> repo = new EFGenericRepository<CompanyLocationPoco>(false);
            CompanyLocationLogic log = new CompanyLocationLogic(repo);
            log.Delete(pocos);
        }

        public void RemoveCompanyProfile(CompanyProfilePoco[] pocos)
        {
            EFGenericRepository<CompanyProfilePoco> repo = new EFGenericRepository<CompanyProfilePoco>(false);
            CompanyProfileLogic log = new CompanyProfileLogic(repo);
            log.Delete(pocos);
        }

        public void UpdateCompanyDescription(CompanyDescriptionPoco[] pocos)
        {
            EFGenericRepository<CompanyDescriptionPoco> repo = new EFGenericRepository<CompanyDescriptionPoco>(false);
            CompanyDescriptionLogic log = new CompanyDescriptionLogic(repo);
            log.Update(pocos);
        }

        public void UpdateCompanyJob(CompanyJobPoco[] pocos)
        {
            EFGenericRepository<CompanyJobPoco> repo = new EFGenericRepository<CompanyJobPoco>(false);
            CompanyJobLogic log = new CompanyJobLogic(repo);
            log.Update(pocos);
        }

        public void UpdateCompanyJobDescription(CompanyJobDescriptionPoco[] pocos)
        {
            EFGenericRepository<CompanyJobDescriptionPoco> repo = new EFGenericRepository<CompanyJobDescriptionPoco>(false);
            CompanyJobDescriptionLogic log = new CompanyJobDescriptionLogic(repo);
            log.Update(pocos);
        }

        public void UpdateCompanyJobEducation(CompanyJobEducationPoco[] pocos)
        {
            EFGenericRepository<CompanyJobEducationPoco> repo = new EFGenericRepository<CompanyJobEducationPoco>(false);
            CompanyJobEducationLogic log = new CompanyJobEducationLogic(repo);
            log.Update(pocos);
        }

        public void UpdateCompanyJobSkill(CompanyJobSkillPoco[] pocos)
        {
            EFGenericRepository<CompanyJobSkillPoco> repo = new EFGenericRepository<CompanyJobSkillPoco>(false);
            CompanyJobSkillLogic log = new CompanyJobSkillLogic(repo);
            log.Update(pocos);
        }

        public void UpdateCompanyLocation(CompanyLocationPoco[] pocos)
        {
            EFGenericRepository<CompanyLocationPoco> repo = new EFGenericRepository<CompanyLocationPoco>(false);
            CompanyLocationLogic log = new CompanyLocationLogic(repo);
            log.Update(pocos);
        }

        public void UpdateCompanyProfile(CompanyProfilePoco[] pocos)
        {
            EFGenericRepository<CompanyProfilePoco> repo = new EFGenericRepository<CompanyProfilePoco>(false);
            CompanyProfileLogic log = new CompanyProfileLogic(repo);
            log.Update(pocos);
        }
    }
}
