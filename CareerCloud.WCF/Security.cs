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
            EFGenericRepository<SecurityLoginPoco> repo = new EFGenericRepository<SecurityLoginPoco>(false);
            SecurityLoginLogic log = new SecurityLoginLogic(repo);
            log.Add(pocos); 
        }

        public void AddSecurityLoginsLog(SecurityLoginsLogPoco[] pocos)
        {
            EFGenericRepository<SecurityLoginsLogPoco> repo = new EFGenericRepository<SecurityLoginsLogPoco>(false);
            SecurityLoginsLogLogic log = new SecurityLoginsLogLogic(repo);
            log.Add(pocos);
        }

        public void AddSecurityLoginsRole(SecurityLoginsRolePoco[] pocos)
        {
            EFGenericRepository<SecurityLoginsRolePoco> repo = new EFGenericRepository<SecurityLoginsRolePoco>(false);
            SecurityLoginsRoleLogic log = new SecurityLoginsRoleLogic (repo);
            log.Add(pocos);
        }

        public void AddSecurityRole(SecurityRolePoco[] pocos)
        {
            EFGenericRepository<SecurityRolePoco> repo = new EFGenericRepository<SecurityRolePoco>(false);
            SecurityRoleLogic log = new SecurityRoleLogic(repo);
            log.Add(pocos);
        }

        public List<SecurityLoginPoco> GetAllSecurityLogin()
        {
            EFGenericRepository<SecurityLoginPoco> repo = new EFGenericRepository<SecurityLoginPoco>(false);
            SecurityLoginLogic log = new SecurityLoginLogic(repo);
            return log.GetAll();
        }

        public List<SecurityLoginsLogPoco> GetAllSecurityLoginsLog()
        {
            EFGenericRepository<SecurityLoginsLogPoco> repo = new EFGenericRepository<SecurityLoginsLogPoco>(false);
            SecurityLoginsLogLogic log = new SecurityLoginsLogLogic(repo);
            return log.GetAll();
        }

        public List<SecurityLoginsRolePoco> GetAllSecurityLoginsRole()
        {
            EFGenericRepository<SecurityLoginsRolePoco> repo = new EFGenericRepository<SecurityLoginsRolePoco>(false);
            SecurityLoginsRoleLogic log = new SecurityLoginsRoleLogic(repo);
            return log.GetAll();
        }

        public List<SecurityRolePoco> GetAllSecurityRole()
        {
            EFGenericRepository<SecurityRolePoco> repo = new EFGenericRepository<SecurityRolePoco>(false);
            SecurityRoleLogic log = new SecurityRoleLogic(repo);
            return log.GetAll();
        }

        public SecurityLoginPoco GetSingleSecurityLogin(string Id)
        {
            EFGenericRepository<SecurityLoginPoco> repo = new EFGenericRepository<SecurityLoginPoco>(false);
            SecurityLoginLogic log = new SecurityLoginLogic(repo);
            return log.Get(Guid.Parse(Id));
        }

        public SecurityLoginsLogPoco GetSingleSecurityLoginsLog(string Id)
        {
            EFGenericRepository<SecurityLoginsLogPoco> repo = new EFGenericRepository<SecurityLoginsLogPoco>(false);
            SecurityLoginsLogLogic log = new SecurityLoginsLogLogic(repo);
            return log.Get(Guid.Parse(Id));
        }

        public SecurityLoginsRolePoco GetSingleSecurityLoginsRole(string Id)
        {
            EFGenericRepository<SecurityLoginsRolePoco> repo = new EFGenericRepository<SecurityLoginsRolePoco>(false);
            SecurityLoginsRoleLogic log = new SecurityLoginsRoleLogic(repo);
            return log.Get(Guid.Parse(Id));
        }

        public SecurityRolePoco GetSingleSecurityRole(string Id)
        {
            EFGenericRepository<SecurityRolePoco> repo = new EFGenericRepository<SecurityRolePoco>(false);
            SecurityRoleLogic log = new SecurityRoleLogic(repo);
            return log.Get(Guid.Parse(Id));
        }

        public void RemoveSecurityLogin(SecurityLoginPoco[] pocos)
        {
            EFGenericRepository<SecurityLoginPoco> repo = new EFGenericRepository<SecurityLoginPoco>(false);
            SecurityLoginLogic log = new SecurityLoginLogic(repo);
            log.Delete(pocos);
        }

        public void RemoveSecurityLoginsLog(SecurityLoginsLogPoco[] pocos)
        {
            EFGenericRepository<SecurityLoginsLogPoco> repo = new EFGenericRepository<SecurityLoginsLogPoco>(false);
            SecurityLoginsLogLogic log = new SecurityLoginsLogLogic(repo);
            log.Delete(pocos);
        }

        public void RemoveSecurityLoginsRole(SecurityLoginsRolePoco[] pocos)
        {
            EFGenericRepository<SecurityLoginsRolePoco> repo = new EFGenericRepository<SecurityLoginsRolePoco>(false);
            SecurityLoginsRoleLogic log = new SecurityLoginsRoleLogic(repo);
            log.Delete(pocos);
        }

        public void RemoveSecurityRole(SecurityRolePoco[] pocos)
        {
            EFGenericRepository<SecurityRolePoco> repo = new EFGenericRepository<SecurityRolePoco>(false);
            SecurityRoleLogic log = new SecurityRoleLogic(repo);
            log.Delete(pocos);
        }

        public void UpdateSecurityLogin(SecurityLoginPoco[] pocos)
        {
            EFGenericRepository<SecurityLoginPoco> repo = new EFGenericRepository<SecurityLoginPoco>(false);
            SecurityLoginLogic log = new SecurityLoginLogic(repo);
            log.Update(pocos);
        }

        public void UpdateSecurityLoginsLog(SecurityLoginsLogPoco[] pocos)
        {
            EFGenericRepository<SecurityLoginsLogPoco> repo = new EFGenericRepository<SecurityLoginsLogPoco>(false);
            SecurityLoginsLogLogic log = new SecurityLoginsLogLogic(repo);
            log.Update(pocos);
        }

        public void UpdateSecurityLoginsRole(SecurityLoginsRolePoco[] pocos)
        {
            EFGenericRepository<SecurityLoginsRolePoco> repo = new EFGenericRepository<SecurityLoginsRolePoco>(false);
            SecurityLoginsRoleLogic log = new SecurityLoginsRoleLogic(repo);
            log.Update(pocos);
        }

        public void UpdateSecurityRole(SecurityRolePoco[] pocos)
        {
            EFGenericRepository<SecurityRolePoco> repo = new EFGenericRepository<SecurityRolePoco>(false);
            SecurityRoleLogic log = new SecurityRoleLogic(repo);
            log.Update(pocos);
        }
    }
}
