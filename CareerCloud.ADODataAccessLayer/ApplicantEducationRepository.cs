using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.ADODataAccessLayer
{
    public class ApplicantEducationRepository : IDataRepository<ApplicantEducationPoco>
    {
        public void Add(params ApplicantEducationPoco[] items)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            int rowsAffected = 0;

            foreach (ApplicantEducationPoco poco in items)
            {
                command.CommandText = @"INSERT INTO Applicant_Educations 
                    (Id, Applicant, Major, Certificate_Diploma, Start_Date, Completion_Date
                    Completion_Percent)
                    Values
                    (@Id, @Applicant, @Major, @Certificate_Diploma, @Start_Date, @Completion_Date,
                    @Completion_Percent)";

                command.Parameters.AddWithValue("@Id", poco.Id);
                command.Parameters.AddWithValue("@Applicant", poco.Applicant);
                command.Parameters.AddWithValue("@Major", poco.Major);
                command.Parameters.AddWithValue("@Certificate_Diploma", poco.CertificateDiploma);
                command.Parameters.AddWithValue("@Start_Date", poco.StartDate);
                command.Parameters.AddWithValue("@Completion_Date", poco.CompletionDate);
                command.Parameters.AddWithValue("@Completion_Percent", poco.CompletionPercent);
              


                connection.Open();
                rowsAffected += command.ExecuteNonQuery();
                connection.Close();

            }

        }

        public void CallStoredProc(string name, params Tuple<string, string>[] parameters)
        {
            throw new NotImplementedException();
        }

        public IList<ApplicantEducationPoco> GetAll(params Expression<Func<ApplicantEducationPoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public IList<ApplicantEducationPoco> GetList(Expression<Func<ApplicantEducationPoco, bool>> where, params Expression<Func<ApplicantEducationPoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public ApplicantEducationPoco GetSingle(Expression<Func<ApplicantEducationPoco, bool>> where, params Expression<Func<ApplicantEducationPoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public void Remove(params ApplicantEducationPoco[] items)
        {
            throw new NotImplementedException();
        }

        public void Update(params ApplicantEducationPoco[] items)
        {
            throw new NotImplementedException();
        }
    }
}
