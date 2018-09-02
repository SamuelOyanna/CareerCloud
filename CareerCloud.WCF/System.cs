using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CareerCloud.ADODataAccessLayer;
using CareerCloud.BusinessLogicLayer;
using CareerCloud.DataAccessLayer;
using CareerCloud.EntityFrameworkDataAccess;
using CareerCloud.Pocos;

namespace CareerCloud.WCF
{
    class System : ISystem
    {
        public void AddSystemCountryCode(SystemCountryCodePoco[] pocos)
        {
            EFGenericRepository<SystemCountryCodePoco> repo = new EFGenericRepository<SystemCountryCodePoco>(false);
            SystemCountryCodeLogic log = new SystemCountryCodeLogic(repo);
            log.Add(pocos);
        }

        public void AddSystemLanguageCode(SystemLanguageCodePoco[] pocos)
        {
            EFGenericRepository<SystemLanguageCodePoco> repo = new EFGenericRepository<SystemLanguageCodePoco>(false);
            SystemLanguageCodeLogic log = new SystemLanguageCodeLogic(repo);
            log.Add(pocos);
        }

        public List<SystemCountryCodePoco> GetAllSystemCountryCode()
        {
            EFGenericRepository<SystemCountryCodePoco> repo = new EFGenericRepository<SystemCountryCodePoco>(false);
            SystemCountryCodeRepository l = new SystemCountryCodeRepository();
            SystemCountryCodeLogic log = new SystemCountryCodeLogic(l);
            return log.GetAll();
        }

        public List<SystemLanguageCodePoco> GetAllSystemLanguageCode()
        {
            EFGenericRepository<SystemLanguageCodePoco> repo = new EFGenericRepository<SystemLanguageCodePoco>(false);
            SystemLanguageCodeLogic log = new SystemLanguageCodeLogic(repo);
            return log.GetAll();
        }

        public SystemCountryCodePoco GetSingleSystemCountryCode(string Id)
        {
            EFGenericRepository<SystemCountryCodePoco> repo = new EFGenericRepository<SystemCountryCodePoco>(false);
            SystemCountryCodeLogic log = new SystemCountryCodeLogic(repo);
            return log.Get(Id);
        }

        public SystemLanguageCodePoco GetSingleSystemLanguageCode(string Id)
        {
            EFGenericRepository<SystemLanguageCodePoco> repo = new EFGenericRepository<SystemLanguageCodePoco>(false);
            SystemLanguageCodeLogic log = new SystemLanguageCodeLogic(repo);
            return log.Get(Id);
        }

        public void RemoveSystemCountryCode(SystemCountryCodePoco[] pocos)
        {

            EFGenericRepository<SystemCountryCodePoco> repo = new EFGenericRepository<SystemCountryCodePoco>(false);
            SystemCountryCodeLogic log = new SystemCountryCodeLogic(repo);
            log.Delete(pocos);
        
        }

        public void RemoveSystemLanguageCode(SystemLanguageCodePoco[] pocos)
        {
            EFGenericRepository<SystemLanguageCodePoco> repo = new EFGenericRepository<SystemLanguageCodePoco>(false);
            SystemLanguageCodeLogic log = new SystemLanguageCodeLogic(repo);
            log.Delete(pocos);
        }

        public void UpdateSystemCountryCode(SystemCountryCodePoco[] pocos)
        {
            EFGenericRepository<SystemCountryCodePoco> repo = new EFGenericRepository<SystemCountryCodePoco>(false);
            SystemCountryCodeLogic log = new SystemCountryCodeLogic(repo);
            log.Update(pocos);
        }

        public void UpdateSystemLanguageCode(SystemLanguageCodePoco[] pocos)
        {
            EFGenericRepository<SystemLanguageCodePoco> repo = new EFGenericRepository<SystemLanguageCodePoco>(false);
            SystemLanguageCodeLogic log = new SystemLanguageCodeLogic(repo);
            log.Update(pocos);
        }
    }
}
