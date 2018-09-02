using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.BusinessLogicLayer
{
    
    public class SystemCountryCodeLogic 
    {
        protected IDataRepository<SystemCountryCodePoco> repository;
        public SystemCountryCodeLogic(IDataRepository <SystemCountryCodePoco> repo)
        {
            repository = repo;
        }

        public void Add(SystemCountryCodePoco[] pocos)
        {
            Verify(pocos);
            repository.Add(pocos);
            
        }

        public void Update(SystemCountryCodePoco[] pocos)
        {
            Verify(pocos);
            repository.Update(pocos);
           
        }
        public SystemCountryCodePoco Get(string Id)
        {
            IQueryable<SystemCountryCodePoco> pocos = repository.GetAll().AsQueryable();
            return pocos.FirstOrDefault(t => t.Code == Id);
        }

        public List <SystemCountryCodePoco> GetAll()
        {
            IList<SystemCountryCodePoco> pocos = repository.GetAll();
            return pocos.ToList();
        }

        public void Delete (SystemCountryCodePoco [] pocos)
        {
            repository.Remove(pocos);
        }

        protected void Verify(SystemCountryCodePoco[] pocos)
        {
            List<ValidationException> exceptions = new List<ValidationException>();
            

            foreach (SystemCountryCodePoco poco in pocos)
            {

                if (string.IsNullOrEmpty(poco.Code))
                {
                    exceptions.Add(new ValidationException(900,
                        "Cannot be empty"));
                }

                if (string.IsNullOrEmpty(poco.Name))
                {
                    exceptions.Add(new ValidationException(901,
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
