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
            ApplicantProfileRepository<ApplicantEducationPoco> repo = new ApplicantProfileRepository<ApplicantEducationPoco>(false);
            ApplicantEducationLogic log = new ApplicantEducationLogic(repo);
            log.Add(pocos);
        }

        public void AddApplicantJobApplication(ApplicantJobApplicationPoco[] pocos)
        {
            ApplicantProfileRepository<ApplicantJobApplicationPoco> repo = new ApplicantProfileRepository<ApplicantJobApplicationPoco>(false);
            ApplicantJobApplicationLogic log = new ApplicantJobApplicationLogic(repo);
            log.Add(pocos);
        }

        public void AddApplicantProfile(ApplicantProfilePoco[] pocos)
        {
            ApplicantProfileRepository<ApplicantProfilePoco> repo = new ApplicantProfileRepository<ApplicantProfilePoco>(false);
            ApplicantProfileLogic log = new ApplicantProfileLogic(repo);
            log.Add(pocos);
        }

        public void AddApplicantResume(ApplicantResumePoco[] pocos)
        {
            ApplicantProfileRepository<ApplicantResumePoco> repo = new ApplicantProfileRepository<ApplicantResumePoco>(false);
            ApplicantResumeLogic log = new ApplicantResumeLogic(repo);
            log.Add(pocos);
        }

        public void AddApplicantSkill(ApplicantSkillPoco[] pocos)
        {
            ApplicantProfileRepository<ApplicantSkillPoco> repo = new ApplicantProfileRepository<ApplicantSkillPoco>(false);
            ApplicantSkillLogic log = new ApplicantSkillLogic(repo);
            log.Add(pocos);
        }

        public void AddApplicantWorkHistory(ApplicantWorkHistoryPoco[] pocos)
        {
            ApplicantProfileRepository<ApplicantWorkHistoryPoco> repo = new ApplicantProfileRepository<ApplicantWorkHistoryPoco>(false);
            ApplicantWorkHistoryLogic log = new ApplicantWorkHistoryLogic(repo);
            log.Add(pocos);
        }

        public List<ApplicantEducationPoco> GetAllApplicantEducation()
        {
            ApplicantProfileRepository<ApplicantEducationPoco> repo = new ApplicantProfileRepository<ApplicantEducationPoco>(false);
            ApplicantEducationLogic log = new ApplicantEducationLogic(repo);
            return log.GetAll();
        }

        public List<ApplicantJobApplicationPoco> GetAllApplicantJobApplication()
        {
            ApplicantProfileRepository<ApplicantJobApplicationPoco> repo = new ApplicantProfileRepository<ApplicantJobApplicationPoco>(false);
            ApplicantJobApplicationLogic log = new ApplicantJobApplicationLogic(repo);
            return log.GetAll();
        }

        public List<ApplicantProfilePoco> GetAllApplicantProfile()
        {
            ApplicantProfileRepository<ApplicantProfilePoco> repo = new ApplicantProfileRepository<ApplicantProfilePoco>(false);
            ApplicantProfileLogic log = new ApplicantProfileLogic(repo);
            return log.GetAll();
        }

        public List<ApplicantResumePoco> GetAllApplicantResume()
        {
            ApplicantProfileRepository<ApplicantResumePoco> repo = new ApplicantProfileRepository<ApplicantResumePoco>(false);
            ApplicantResumeLogic log = new ApplicantResumeLogic(repo);
            return log.GetAll();
        }

        public List<ApplicantSkillPoco> GetAllApplicantSkill()
        {
            ApplicantProfileRepository<ApplicantSkillPoco> repo = new ApplicantProfileRepository<ApplicantSkillPoco>(false);
            ApplicantSkillLogic log = new ApplicantSkillLogic(repo);
            return log.GetAll();
        }

        public List<ApplicantWorkHistoryPoco> GetAllApplicantWorkHistory()
        {
            ApplicantProfileRepository<ApplicantWorkHistoryPoco> repo = new ApplicantProfileRepository<ApplicantWorkHistoryPoco>(false);
            ApplicantWorkHistoryLogic log = new ApplicantWorkHistoryLogic(repo);
            return log.GetAll();
        }

        public ApplicantEducationPoco GetSingleApplicantEducation(string Id)
        {
            ApplicantProfileRepository<ApplicantEducationPoco> repo = new ApplicantProfileRepository<ApplicantEducationPoco>(false);
            ApplicantEducationLogic log = new ApplicantEducationLogic(repo);
            return log.Get(Guid.Parse(Id));
        }

        public ApplicantJobApplicationPoco GetSingleApplicantJobApplication(string Id)
        {
            ApplicantProfileRepository<ApplicantJobApplicationPoco> repo = new ApplicantProfileRepository<ApplicantJobApplicationPoco>(false);
            ApplicantJobApplicationLogic log = new ApplicantJobApplicationLogic(repo);
            return log.Get(Guid.Parse(Id));
        }

        public ApplicantProfilePoco GetSingleApplicantProfile(string Id)
        {
            ApplicantProfileRepository<ApplicantProfilePoco> repo = new ApplicantProfileRepository<ApplicantProfilePoco>(false);
            ApplicantProfileLogic log = new ApplicantProfileLogic(repo);
            return log.Get(Guid.Parse(Id));
        }

        public ApplicantResumePoco GetSingleApplicantResume(string Id)
        {
            ApplicantProfileRepository<ApplicantResumePoco> repo = new ApplicantProfileRepository<ApplicantResumePoco>(false);
            ApplicantResumeLogic log = new ApplicantResumeLogic(repo);
            return log.Get(Guid.Parse(Id));
        }

        public ApplicantSkillPoco GetSingleApplicantSkill(string Id)
        {
            ApplicantProfileRepository<ApplicantSkillPoco> repo = new ApplicantProfileRepository<ApplicantSkillPoco>(false);
            ApplicantSkillLogic log = new ApplicantSkillLogic(repo);
            return log.Get(Guid.Parse(Id));
        }

        public ApplicantWorkHistoryPoco GetSingleApplicantWorkHistory(string Id)
        {
            ApplicantProfileRepository<ApplicantWorkHistoryPoco> repo = new ApplicantProfileRepository<ApplicantWorkHistoryPoco>(false);
            ApplicantWorkHistoryLogic log = new ApplicantWorkHistoryLogic(repo);
            return log.Get(Guid.Parse(Id));
        }

        public void RemoveApplicantEducation(ApplicantEducationPoco[] pocos)
        {
            ApplicantProfileRepository<ApplicantEducationPoco> repo = new ApplicantProfileRepository<ApplicantEducationPoco>(false);
            ApplicantEducationLogic log = new ApplicantEducationLogic(repo);
            log.Delete(pocos);
        }

        public void RemoveApplicantJobApplication(ApplicantJobApplicationPoco[] pocos)
        {
            ApplicantProfileRepository<ApplicantJobApplicationPoco> repo = new ApplicantProfileRepository<ApplicantJobApplicationPoco>(false);
            ApplicantJobApplicationLogic log = new ApplicantJobApplicationLogic(repo);
            log.Delete(pocos);
        }

        public void RemoveApplicantProfile(ApplicantProfilePoco[] pocos)
        {
            ApplicantProfileRepository<ApplicantProfilePoco> repo = new ApplicantProfileRepository<ApplicantProfilePoco>(false);
            ApplicantProfileLogic log = new ApplicantProfileLogic(repo);
            log.Delete(pocos);
        }

        public void RemoveApplicantResume(ApplicantResumePoco[] pocos)
        {
            ApplicantProfileRepository<ApplicantResumePoco> repo = new ApplicantProfileRepository<ApplicantResumePoco>(false);
            ApplicantResumeLogic log = new ApplicantResumeLogic(repo);
            log.Delete(pocos);
        }

        public void RemoveApplicantSkill(ApplicantSkillPoco[] pocos)
        {
            ApplicantProfileRepository<ApplicantSkillPoco> repo = new ApplicantProfileRepository<ApplicantSkillPoco>(false);
            ApplicantSkillLogic log = new ApplicantSkillLogic(repo);
            log.Delete(pocos);
        }

        public void RemoveApplicantWorkHistory(ApplicantWorkHistoryPoco[] pocos)
        {
            ApplicantProfileRepository<ApplicantWorkHistoryPoco> repo = new ApplicantProfileRepository<ApplicantWorkHistoryPoco>(false);
            ApplicantWorkHistoryLogic log = new ApplicantWorkHistoryLogic(repo);
            log.Delete(pocos);
        }

        public void UpdateApplicantEducation(ApplicantEducationPoco[] pocos)
        {
            ApplicantProfileRepository<ApplicantEducationPoco> repo = new ApplicantProfileRepository<ApplicantEducationPoco>(false);
            ApplicantEducationLogic log = new ApplicantEducationLogic(repo);
            log.Update(pocos);
        }

        public void UpdateApplicantJobApplication(ApplicantJobApplicationPoco[] pocos)
        {
            ApplicantProfileRepository<ApplicantJobApplicationPoco> repo = new ApplicantProfileRepository<ApplicantJobApplicationPoco>(false);
            ApplicantJobApplicationLogic log = new ApplicantJobApplicationLogic(repo);
            log.Update(pocos);
        }

        public void UpdateApplicantProfile(ApplicantProfilePoco[] pocos)
        {
            ApplicantProfileRepository<ApplicantProfilePoco> repo = new ApplicantProfileRepository<ApplicantProfilePoco>(false);
            ApplicantProfileLogic log = new ApplicantProfileLogic(repo);
            log.Update(pocos);
        }

        public void UpdateApplicantResume(ApplicantResumePoco[] pocos)
        {
            ApplicantProfileRepository<ApplicantResumePoco> repo = new ApplicantProfileRepository<ApplicantResumePoco>(false);
            ApplicantResumeLogic log = new ApplicantResumeLogic(repo);
            log.Update(pocos);
        }

        public void UpdateApplicantSkill(ApplicantSkillPoco[] pocos)
        {
            ApplicantProfileRepository<ApplicantSkillPoco> repo = new ApplicantProfileRepository<ApplicantSkillPoco>(false);
            ApplicantSkillLogic log = new ApplicantSkillLogic(repo);
            log.Update(pocos);
        }

        public void UpdateApplicantWorkHistory(ApplicantWorkHistoryPoco[] pocos)
        {
            ApplicantProfileRepository<ApplicantWorkHistoryPoco> repo = new ApplicantProfileRepository<ApplicantWorkHistoryPoco>(false);
            ApplicantWorkHistoryLogic log = new ApplicantWorkHistoryLogic(repo);
            log.Update(pocos);
        }

      
    }
}
