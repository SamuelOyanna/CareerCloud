using CareerCloud.ADODataAccessLayer;
using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.BusinessLogicLayer
{
    public class SystemLanguageCodeLogic
    {
        protected IDataRepository<SystemLanguageCodePoco> repository;
        public SystemLanguageCodeLogic(IDataRepository<SystemLanguageCodePoco> repo)
        {
            repository = repo;
        }

        public void Add(SystemLanguageCodePoco[] pocos)
        {
            Verify(pocos);
            repository.Add(pocos);

        }

        public void Update(SystemLanguageCodePoco[] pocos)
        {
            Verify(pocos);
            repository.Update(pocos);

        }
        public SystemLanguageCodePoco Get(string Id)
        {
            IQueryable<SystemLanguageCodePoco> pocos = repository.GetAll().AsQueryable();
            return pocos.FirstOrDefault(t => t.LanguageID == Id);
        }

        public List<SystemLanguageCodePoco> GetAll()
        {
            IList<SystemLanguageCodePoco> pocos = repository.GetAll();
            return pocos.ToList();
        }

        public void Delete(SystemLanguageCodePoco[] pocos)
        {
            repository.Remove(pocos);
        }

        protected void Verify(SystemLanguageCodePoco[] pocos)
        {
            List<ValidationException> exceptions = new List<ValidationException>();


            foreach (SystemLanguageCodePoco poco in pocos)
            {

                if (string.IsNullOrEmpty(poco.LanguageID))
                {
                    exceptions.Add(new ValidationException(1000,
                        "Cannot be empty"));
                }

                if (string.IsNullOrEmpty(poco.Name))
                {
                    exceptions.Add(new ValidationException(1001,
                        "Cannot be empty"));
                }

                if (string.IsNullOrEmpty(poco.NativeName))
                {
                    exceptions.Add(new ValidationException(1002,
                        "Cannot be empty"));
                }
            }

            if (exceptions.Count > 0)
            {
                throw new AggregateException(exceptions);
            }

        }
    }
}
