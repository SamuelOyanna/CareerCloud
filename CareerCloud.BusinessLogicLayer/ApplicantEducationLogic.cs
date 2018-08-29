using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.BusinessLogicLayer
{
    public class ApplicantEducationLogic :BaseLogic<ApplicantEducationPoco>
    {
         public ApplicantEducationLogic(IDataRepository<ApplicantEducationPoco> repo)
            : base(repo) 

        {

        }

        public override void Add(ApplicantEducationPoco[] pocos)
        {
            Verify(pocos);
            base.Add(pocos);
        }

        public override void Update(ApplicantEducationPoco[] pocos)
        {
            Verify(pocos);
            base.Update(pocos);
        }

        protected override void Verify(ApplicantEducationPoco[] pocos)
        {
            List<ValidationException> exceptions = new List<ValidationException>();
            foreach (ApplicantEducationPoco poco in pocos)
            {
                if (string.IsNullOrEmpty(poco.Major))
                {
                    exceptions.Add(new ValidationException(107,
                       $"Cannot Be Empty or Less Than 3 Characters - {poco.Id}"));
                }
                else if (poco.Major.Length < 3)
                {
                    exceptions.Add(new ValidationException(107,
                        $"Cannot Be Empty or Less Than 3 Characters - {poco.Id}"));
                }
                if (poco.StartDate.HasValue && poco.StartDate > DateTime.Now)
                {
                    exceptions.Add(new ValidationException(108,
                        $"Cannot Be Greater Than Today - {poco.Id}"));
                }
                if((poco.StartDate.HasValue && poco.CompletionDate.HasValue) && (poco.StartDate > poco.CompletionDate)){
                    exceptions.Add(new ValidationException(109,
                       $"CompletionDate cannot be earlier than StartDate - {poco.Id}"));
                }
            }

            if (exceptions.Count > 0)
            {
                throw new AggregateException(exceptions);
            }

        }
    }
}
