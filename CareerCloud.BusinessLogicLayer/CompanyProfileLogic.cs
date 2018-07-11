using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CareerCloud.BusinessLogicLayer
{
    public class CompanyProfileLogic : BaseLogic<CompanyProfilePoco>
    {
        public CompanyProfileLogic(IDataRepository<CompanyProfilePoco> repo)
      : base(repo)

        {

        }

        public override void Add(CompanyProfilePoco[] pocos)
        {
            Verify(pocos);
            base.Add(pocos);
        }

        public override void Update(CompanyProfilePoco[] pocos)
        {
            Verify(pocos);
            base.Update(pocos);
        }

        protected override void Verify(CompanyProfilePoco[] pocos)
        {
            List<ValidationException> exceptions = new List<ValidationException>();
            Regex regex = new Regex(@"^[2-9]\d{2}-\d{3}-\d{4}$");
            
            foreach (CompanyProfilePoco poco in pocos)
            {
                if (string.IsNullOrEmpty(poco.CompanyWebsite))
                {
                    exceptions.Add(new ValidationException(600,
                        @"Valid websites must end with the following extensions – "".ca"", "".com"", "".biz"" - " + poco.Id));

                }
                else if (!poco.CompanyWebsite.Contains(".com") || !poco.CompanyWebsite.Contains(".ca")
                   || !poco.CompanyWebsite.Contains(".biz"))
                {
                    exceptions.Add(new ValidationException(600,
                        @"Valid websites must end with the following extensions – "".ca"", "".com"", "".biz"" - " + poco.Id));
                }

                if (string.IsNullOrEmpty(poco.ContactPhone))
                {
                    exceptions.Add(new ValidationException(601,
                        $"Must correspond to a valid phone number (e.g. 416-555-1234) -  poco.Id"));

                }
                else
                {
                    Match match = regex.Match(poco.ContactPhone);
                    if (!match.Success)
                    {
                        exceptions.Add(new ValidationException(601,
                            $"Must correspond to a valid phone number (e.g. 416-555-1234) - {poco.Id}"));

                    }

                }
            }

            if (exceptions.Count > 0)
            {
                throw new AggregateException(exceptions);
            }

        }
    }
}
