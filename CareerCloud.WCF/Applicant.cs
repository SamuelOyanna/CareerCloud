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
    class Applicant : IApplicant
    {
        public void AddApplicantEducation(ApplicantEducationPoco[] pocos)
        {
            EFGenericRepository<ApplicantEducationPoco> repo = new EFGenericRepository<ApplicantEducationPoco>(false);
            ApplicantEducationLogic log = new ApplicantEducationLogic(repo);
            log.Add(pocos);
        }

        public void AddApplicantJobApplication(ApplicantJobApplicationPoco[] pocos)
        {
            EFGenericRepository<ApplicantJobApplicationPoco> repo = new EFGenericRepository<ApplicantJobApplicationPoco>(false);
            ApplicantJobApplicationLogic log = new ApplicantJobApplicationLogic(repo);
            log.Add(pocos);
        }

        public void AddApplicantProfile(ApplicantProfilePoco[] pocos)
        {
            EFGenericRepository<ApplicantProfilePoco> repo = new EFGenericRepository<ApplicantProfilePoco>(false);
            ApplicantProfileLogic log = new ApplicantProfileLogic(repo);
            log.Add(pocos);
        }

        public void AddApplicantResume(ApplicantResumePoco[] pocos)
        {
            EFGenericRepository<ApplicantResumePoco> repo = new EFGenericRepository<ApplicantResumePoco>(false);
            ApplicantResumeLogic log = new ApplicantResumeLogic(repo);
            log.Add(pocos);
        }

        public void AddApplicantSkill(ApplicantSkillPoco[] pocos)
        {
            EFGenericRepository<ApplicantSkillPoco> repo = new EFGenericRepository<ApplicantSkillPoco>(false);
            ApplicantSkillLogic log = new ApplicantSkillLogic(repo);
            log.Add(pocos);
        }

        public void AddApplicantWorkHistory(ApplicantWorkHistoryPoco[] pocos)
        {
            EFGenericRepository<ApplicantWorkHistoryPoco> repo = new EFGenericRepository<ApplicantWorkHistoryPoco>(false);
            ApplicantWorkHistoryLogic log = new ApplicantWorkHistoryLogic(repo);
            log.Add(pocos);
        }

        public List<ApplicantEducationPoco> GetAllApplicantEducation()
        {
            EFGenericRepository<ApplicantEducationPoco> repo = new EFGenericRepository<ApplicantEducationPoco>(false);
            ApplicantEducationLogic log = new ApplicantEducationLogic(repo);
            return log.GetAll();
        }

        public List<ApplicantJobApplicationPoco> GetAllApplicantJobApplication()
        {
            EFGenericRepository<ApplicantJobApplicationPoco> repo = new EFGenericRepository<ApplicantJobApplicationPoco>(false);
            ApplicantJobApplicationLogic log = new ApplicantJobApplicationLogic(repo);
            return log.GetAll();
        }

        public List<ApplicantProfilePoco> GetAllApplicantProfile()
        {
            EFGenericRepository<ApplicantProfilePoco> repo = new EFGenericRepository<ApplicantProfilePoco>(false);
            ApplicantProfileLogic log = new ApplicantProfileLogic(repo);
            return log.GetAll();
        }

        public List<ApplicantResumePoco> GetAllApplicantResume()
        {
            EFGenericRepository<ApplicantResumePoco> repo = new EFGenericRepository<ApplicantResumePoco>(false);
            ApplicantResumeLogic log = new ApplicantResumeLogic(repo);
            return log.GetAll();
        }

        public List<ApplicantSkillPoco> GetAllApplicantSkill()
        {
            EFGenericRepository<ApplicantSkillPoco> repo = new EFGenericRepository<ApplicantSkillPoco>(false);
            ApplicantSkillLogic log = new ApplicantSkillLogic(repo);
            return log.GetAll();
        }

        public List<ApplicantWorkHistoryPoco> GetAllApplicantWorkHistory()
        {
            EFGenericRepository<ApplicantWorkHistoryPoco> repo = new EFGenericRepository<ApplicantWorkHistoryPoco>(false);
            ApplicantWorkHistoryLogic log = new ApplicantWorkHistoryLogic(repo);
            return log.GetAll();
        }

        public ApplicantEducationPoco GetSingleApplicantEducation(string Id)
        {
            EFGenericRepository<ApplicantEducationPoco> repo = new EFGenericRepository<ApplicantEducationPoco>(false);
            ApplicantEducationLogic log = new ApplicantEducationLogic(repo);
            return log.Get(Guid.Parse(Id));
        }

        public ApplicantJobApplicationPoco GetSingleApplicantJobApplication(string Id)
        {
            EFGenericRepository<ApplicantJobApplicationPoco> repo = new EFGenericRepository<ApplicantJobApplicationPoco>(false);
            ApplicantJobApplicationLogic log = new ApplicantJobApplicationLogic(repo);
            return log.Get(Guid.Parse(Id));
        }

        public ApplicantProfilePoco GetSingleApplicantProfile(string Id)
        {
            EFGenericRepository<ApplicantProfilePoco> repo = new EFGenericRepository<ApplicantProfilePoco>(false);
            ApplicantProfileLogic log = new ApplicantProfileLogic(repo);
            return log.Get(Guid.Parse(Id));
        }

        public ApplicantResumePoco GetSingleApplicantResume(string Id)
        {
            EFGenericRepository<ApplicantResumePoco> repo = new EFGenericRepository<ApplicantResumePoco>(false);
            ApplicantResumeLogic log = new ApplicantResumeLogic(repo);
            return log.Get(Guid.Parse(Id));
        }

        public ApplicantSkillPoco GetSingleApplicantSkill(string Id)
        {
            EFGenericRepository<ApplicantSkillPoco> repo = new EFGenericRepository<ApplicantSkillPoco>(false);
            ApplicantSkillLogic log = new ApplicantSkillLogic(repo);
            return log.Get(Guid.Parse(Id));
        }

        public ApplicantWorkHistoryPoco GetSingleApplicantWorkHistory(string Id)
        {
            EFGenericRepository<ApplicantWorkHistoryPoco> repo = new EFGenericRepository<ApplicantWorkHistoryPoco>(false);
            ApplicantWorkHistoryLogic log = new ApplicantWorkHistoryLogic(repo);
            return log.Get(Guid.Parse(Id));
        }

        public void RemoveApplicantEducation(ApplicantEducationPoco[] pocos)
        {
            EFGenericRepository<ApplicantEducationPoco> repo = new EFGenericRepository<ApplicantEducationPoco>(false);
            ApplicantEducationLogic log = new ApplicantEducationLogic(repo);
            log.Delete(pocos);
        }

        public void RemoveApplicantJobApplication(ApplicantJobApplicationPoco[] pocos)
        {
            EFGenericRepository<ApplicantJobApplicationPoco> repo = new EFGenericRepository<ApplicantJobApplicationPoco>(false);
            ApplicantJobApplicationLogic log = new ApplicantJobApplicationLogic(repo);
            log.Delete(pocos);
        }

        public void RemoveApplicantProfile(ApplicantProfilePoco[] pocos)
        {
            EFGenericRepository<ApplicantProfilePoco> repo = new EFGenericRepository<ApplicantProfilePoco>(false);
            ApplicantProfileLogic log = new ApplicantProfileLogic(repo);
            log.Delete(pocos);
        }

        public void RemoveApplicantResume(ApplicantResumePoco[] pocos)
        {
            EFGenericRepository<ApplicantResumePoco> repo = new EFGenericRepository<ApplicantResumePoco>(false);
            ApplicantResumeLogic log = new ApplicantResumeLogic(repo);
            log.Delete(pocos);
        }

        public void RemoveApplicantSkill(ApplicantSkillPoco[] pocos)
        {
            EFGenericRepository<ApplicantSkillPoco> repo = new EFGenericRepository<ApplicantSkillPoco>(false);
            ApplicantSkillLogic log = new ApplicantSkillLogic(repo);
            log.Delete(pocos);
        }

        public void RemoveApplicantWorkHistory(ApplicantWorkHistoryPoco[] pocos)
        {
            EFGenericRepository<ApplicantWorkHistoryPoco> repo = new EFGenericRepository<ApplicantWorkHistoryPoco>(false);
            ApplicantWorkHistoryLogic log = new ApplicantWorkHistoryLogic(repo);
            log.Delete(pocos);
        }

        public void UpdateApplicantEducation(ApplicantEducationPoco[] pocos)
        {
            EFGenericRepository<ApplicantEducationPoco> repo = new EFGenericRepository<ApplicantEducationPoco>(false);
            ApplicantEducationLogic log = new ApplicantEducationLogic(repo);
            log.Update(pocos);
        }

        public void UpdateApplicantJobApplication(ApplicantJobApplicationPoco[] pocos)
        {
            EFGenericRepository<ApplicantJobApplicationPoco> repo = new EFGenericRepository<ApplicantJobApplicationPoco>(false);
            ApplicantJobApplicationLogic log = new ApplicantJobApplicationLogic(repo);
            log.Update(pocos);
        }

        public void UpdateApplicantProfile(ApplicantProfilePoco[] pocos)
        {
            EFGenericRepository<ApplicantProfilePoco> repo = new EFGenericRepository<ApplicantProfilePoco>(false);
            ApplicantProfileLogic log = new ApplicantProfileLogic(repo);
            log.Update(pocos);
        }

        public void UpdateApplicantResume(ApplicantResumePoco[] pocos)
        {
            EFGenericRepository<ApplicantResumePoco> repo = new EFGenericRepository<ApplicantResumePoco>(false);
            ApplicantResumeLogic log = new ApplicantResumeLogic(repo);
            log.Update(pocos);
        }

        public void UpdateApplicantSkill(ApplicantSkillPoco[] pocos)
        {
            EFGenericRepository<ApplicantSkillPoco> repo = new EFGenericRepository<ApplicantSkillPoco>(false);
            ApplicantSkillLogic log = new ApplicantSkillLogic(repo);
            log.Update(pocos);
        }

        public void UpdateApplicantWorkHistory(ApplicantWorkHistoryPoco[] pocos)
        {
            EFGenericRepository<ApplicantWorkHistoryPoco> repo = new EFGenericRepository<ApplicantWorkHistoryPoco>(false);
            ApplicantWorkHistoryLogic log = new ApplicantWorkHistoryLogic(repo);
            log.Update(pocos);
        }

      
    }
}
