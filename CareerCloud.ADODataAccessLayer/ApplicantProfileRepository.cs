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
    public class ApplicantProfileRepository : IDataRepository<ApplicantProfilePoco>
    {
        public void Add(params ApplicantProfilePoco[] items)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            int rowsAffected = 0;

            foreach (ApplicantProfilePoco poco in items)
            {
                command.CommandText = @"INSERT INTO Applicant_Profiles 
                    (Id, Login, Current_Salary, Current_Rate, Currency, Country_Code, State_Province_Code,
                    Street_Address, City_Town, Zip_Postal_Code)
                    Values
                    (@Id, @Login, @Current_Salary, @Current_Rate, @Currency, @Country_Code, @State_Province_Code,
                    @Street_Address, @City_Town, @Zip_Postal_Code)";

                command.Parameters.AddWithValue("@Id", poco.Id);
                command.Parameters.AddWithValue("@Login", poco.Login);
                command.Parameters.AddWithValue("@Current_Salary", poco.CurrentSalary);
                command.Parameters.AddWithValue("@Current_Rate", poco.CurrentRate);
                command.Parameters.AddWithValue("@Currency", poco.Currency);
                command.Parameters.AddWithValue("@Country_Code", poco.Country);
                command.Parameters.AddWithValue("@State_Province_Code", poco.Province);
                command.Parameters.AddWithValue("@Street_Address", poco.Street);
                command.Parameters.AddWithValue("@City_Town", poco.City);
                command.Parameters.AddWithValue("@Zip_Postal_Code", poco.PostalCode);



                connection.Open();
                rowsAffected += command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void CallStoredProc(string name, params Tuple<string, string>[] parameters)
        {
            throw new NotImplementedException();
        }

        public IList<ApplicantProfilePoco> GetAll(params Expression<Func<ApplicantProfilePoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public IList<ApplicantProfilePoco> GetList(Expression<Func<ApplicantProfilePoco, bool>> where, params Expression<Func<ApplicantProfilePoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public ApplicantProfilePoco GetSingle(Expression<Func<ApplicantProfilePoco, bool>> where, params Expression<Func<ApplicantProfilePoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public void Remove(params ApplicantProfilePoco[] items)
        {
            throw new NotImplementedException();
        }

        public void Update(params ApplicantProfilePoco[] items)
        {
            throw new NotImplementedException();
        }
    }
}
