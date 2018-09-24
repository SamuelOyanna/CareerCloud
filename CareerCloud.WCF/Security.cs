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
    class Security : ISecurity 
    {
        public void AddSecurityLogin(SecurityLoginPoco[] pocos)
        {
            ApplicantProfileRepository<SecurityLoginPoco> repo = new ApplicantProfileRepository<SecurityLoginPoco>(false);
            SecurityLoginLogic log = new SecurityLoginLogic(repo);
            log.Add(pocos); 
        }

        public void AddSecurityLoginsLog(SecurityLoginsLogPoco[] pocos)
        {
            ApplicantProfileRepository<SecurityLoginsLogPoco> repo = new ApplicantProfileRepository<SecurityLoginsLogPoco>(false);
            SecurityLoginsLogLogic log = new SecurityLoginsLogLogic(repo);
            log.Add(pocos);
        }

        public void AddSecurityLoginsRole(SecurityLoginsRolePoco[] pocos)
        {
            ApplicantProfileRepository<SecurityLoginsRolePoco> repo = new ApplicantProfileRepository<SecurityLoginsRolePoco>(false);
            SecurityLoginsRoleLogic log = new SecurityLoginsRoleLogic (repo);
            log.Add(pocos);
        }

        public void AddSecurityRole(SecurityRolePoco[] pocos)
        {
            ApplicantProfileRepository<SecurityRolePoco> repo = new ApplicantProfileRepository<SecurityRolePoco>(false);
            SecurityRoleLogic log = new SecurityRoleLogic(repo);
            log.Add(pocos);
        }

        public List<SecurityLoginPoco> GetAllSecurityLogin()
        {
            ApplicantProfileRepository<SecurityLoginPoco> repo = new ApplicantProfileRepository<SecurityLoginPoco>(false);
            SecurityLoginLogic log = new SecurityLoginLogic(repo);
            return log.GetAll();
        }

        public List<SecurityLoginsLogPoco> GetAllSecurityLoginsLog()
        {
            ApplicantProfileRepository<SecurityLoginsLogPoco> repo = new ApplicantProfileRepository<SecurityLoginsLogPoco>(false);
            SecurityLoginsLogLogic log = new SecurityLoginsLogLogic(repo);
            return log.GetAll();
        }

        public List<SecurityLoginsRolePoco> GetAllSecurityLoginsRole()
        {
            ApplicantProfileRepository<SecurityLoginsRolePoco> repo = new ApplicantProfileRepository<SecurityLoginsRolePoco>(false);
            SecurityLoginsRoleLogic log = new SecurityLoginsRoleLogic(repo);
            return log.GetAll();
        }

        public List<SecurityRolePoco> GetAllSecurityRole()
        {
            ApplicantProfileRepository<SecurityRolePoco> repo = new ApplicantProfileRepository<SecurityRolePoco>(false);
            SecurityRoleLogic log = new SecurityRoleLogic(repo);
            return log.GetAll();
        }

        public SecurityLoginPoco GetSingleSecurityLogin(string Id)
        {
            ApplicantProfileRepository<SecurityLoginPoco> repo = new ApplicantProfileRepository<SecurityLoginPoco>(false);
            SecurityLoginLogic log = new SecurityLoginLogic(repo);
            return log.Get(Guid.Parse(Id));
        }

        public SecurityLoginsLogPoco GetSingleSecurityLoginsLog(string Id)
        {
            ApplicantProfileRepository<SecurityLoginsLogPoco> repo = new ApplicantProfileRepository<SecurityLoginsLogPoco>(false);
            SecurityLoginsLogLogic log = new SecurityLoginsLogLogic(repo);
            return log.Get(Guid.Parse(Id));
        }

        public SecurityLoginsRolePoco GetSingleSecurityLoginsRole(string Id)
        {
            ApplicantProfileRepository<SecurityLoginsRolePoco> repo = new ApplicantProfileRepository<SecurityLoginsRolePoco>(false);
            SecurityLoginsRoleLogic log = new SecurityLoginsRoleLogic(repo);
            return log.Get(Guid.Parse(Id));
        }

        public SecurityRolePoco GetSingleSecurityRole(string Id)
        {
            ApplicantProfileRepository<SecurityRolePoco> repo = new ApplicantProfileRepository<SecurityRolePoco>(false);
            SecurityRoleLogic log = new SecurityRoleLogic(repo);
            return log.Get(Guid.Parse(Id));
        }

        public void RemoveSecurityLogin(SecurityLoginPoco[] pocos)
        {
            ApplicantProfileRepository<SecurityLoginPoco> repo = new ApplicantProfileRepository<SecurityLoginPoco>(false);
            SecurityLoginLogic log = new SecurityLoginLogic(repo);
            log.Delete(pocos);
        }

        public void RemoveSecurityLoginsLog(SecurityLoginsLogPoco[] pocos)
        {
            ApplicantProfileRepository<SecurityLoginsLogPoco> repo = new ApplicantProfileRepository<SecurityLoginsLogPoco>(false);
            SecurityLoginsLogLogic log = new SecurityLoginsLogLogic(repo);
            log.Delete(pocos);
        }

        public void RemoveSecurityLoginsRole(SecurityLoginsRolePoco[] pocos)
        {
            ApplicantProfileRepository<SecurityLoginsRolePoco> repo = new ApplicantProfileRepository<SecurityLoginsRolePoco>(false);
            SecurityLoginsRoleLogic log = new SecurityLoginsRoleLogic(repo);
            log.Delete(pocos);
        }

        public void RemoveSecurityRole(SecurityRolePoco[] pocos)
        {
            ApplicantProfileRepository<SecurityRolePoco> repo = new ApplicantProfileRepository<SecurityRolePoco>(false);
            SecurityRoleLogic log = new SecurityRoleLogic(repo);
            log.Delete(pocos);
        }

        public void UpdateSecurityLogin(SecurityLoginPoco[] pocos)
        {
            ApplicantProfileRepository<SecurityLoginPoco> repo = new ApplicantProfileRepository<SecurityLoginPoco>(false);
            SecurityLoginLogic log = new SecurityLoginLogic(repo);
            log.Update(pocos);
        }

        public void UpdateSecurityLoginsLog(SecurityLoginsLogPoco[] pocos)
        {
            ApplicantProfileRepository<SecurityLoginsLogPoco> repo = new ApplicantProfileRepository<SecurityLoginsLogPoco>(false);
            SecurityLoginsLogLogic log = new SecurityLoginsLogLogic(repo);
            log.Update(pocos);
        }

        public void UpdateSecurityLoginsRole(SecurityLoginsRolePoco[] pocos)
        {
            ApplicantProfileRepository<SecurityLoginsRolePoco> repo = new ApplicantProfileRepository<SecurityLoginsRolePoco>(false);
            SecurityLoginsRoleLogic log = new SecurityLoginsRoleLogic(repo);
            log.Update(pocos);
        }

        public void UpdateSecurityRole(SecurityRolePoco[] pocos)
        {
            ApplicantProfileRepository<SecurityRolePoco> repo = new ApplicantProfileRepository<SecurityRolePoco>(false);
            SecurityRoleLogic log = new SecurityRoleLogic(repo);
            log.Update(pocos);
        }
    }
}
