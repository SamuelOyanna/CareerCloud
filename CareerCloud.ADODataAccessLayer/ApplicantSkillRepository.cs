﻿using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.ADODataAccessLayer
{
    public class ApplicantSkillRepository : BaseADO, IDataRepository<ApplicantSkillPoco>
    {
        public void Add(params ApplicantSkillPoco[] items)
        {
            using (SqlConnection _connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand()
                {
                    Connection = _connection
                };
                int rowsAffected = 0;

                foreach (ApplicantSkillPoco poco in items)
                {
                    command.CommandText = @"INSERT INTO Applicant_Skills 
                    (Id, Applicant, Skill, Skill_Level, Start_Month, Start_Year, End_Month,
                    End_Year)
                    Values
                    (@Id, @Applicant, @Skill, @Skill_Level, @Start_Month, @Start_Year, @End_Month,
                    @End_Year)";

                    command.Parameters.AddWithValue("@Id", poco.Id);
                    command.Parameters.AddWithValue("@Applicant", poco.Applicant);
                    command.Parameters.AddWithValue("@Skill", poco.Skill);
                    command.Parameters.AddWithValue("@Skill_Level", poco.SkillLevel);
                    command.Parameters.AddWithValue("@Start_Month", poco.StartMonth);
                    command.Parameters.AddWithValue("@Start_Year", poco.StartYear);
                    command.Parameters.AddWithValue("@End_Month", poco.EndMonth);
                    command.Parameters.AddWithValue("@End_Year", poco.EndYear);



                    _connection.Open();
                    rowsAffected += command.ExecuteNonQuery();
                    _connection.Close();
                }
            }
        }

        public void CallStoredProc(string name, params Tuple<string, string>[] parameters)
        {
            throw new NotImplementedException();
        }

        public IList<ApplicantSkillPoco> GetAll(params System.Linq.Expressions.Expression<Func<ApplicantSkillPoco, object>>[] navigationProperties)
        {
            ApplicantSkillPoco[] pocos = new ApplicantSkillPoco[1000];
            using (SqlConnection _connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand
                {
                    Connection = _connection,
                    CommandText = "SELECT * FROM Applicant_Skills"
                };

                _connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                int position = 0;
                while (reader.Read())
                {
                    ApplicantSkillPoco poco = new ApplicantSkillPoco
                    {
                        Id = reader.GetGuid(0),
                        Applicant = reader.GetGuid(1),
                        Skill = reader.GetString(2),
                        SkillLevel = reader.GetString(3),
                        StartMonth = reader.GetByte(4),
                        StartYear = reader.GetInt32(5),
                        EndMonth = reader.GetByte(6),
                        EndYear = reader.GetInt32(7),
                        TimeStamp = (byte[])reader[8]
                    };

                    pocos[position] = poco;
                    position++;
                }
                _connection.Close();
                return pocos.Where(p => p != null).ToList();
            }

        }

        public IList<ApplicantSkillPoco> GetList(System.Linq.Expressions.Expression<Func<ApplicantSkillPoco, bool>> where, params System.Linq.Expressions.Expression<Func<ApplicantSkillPoco, object>>[] navigationProperties)
        {
           
            throw new NotImplementedException();
        }

        public ApplicantSkillPoco GetSingle(System.Linq.Expressions.Expression<Func<ApplicantSkillPoco, bool>> where, params System.Linq.Expressions.Expression<Func<ApplicantSkillPoco, object>>[] navigationProperties)
        {
            IQueryable<ApplicantSkillPoco> pocos = GetAll().AsQueryable();
            return pocos.Where(where).FirstOrDefault();

        }

        public void Remove(params ApplicantSkillPoco[] items)
        {
            using (SqlConnection _connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand()
                {
                    Connection = _connection
                };
                int rowsEffected = 0;
                foreach (ApplicantSkillPoco poco in items)
                {
                    cmd.CommandText = @"DELETE FROM Applicant_Skills WHERE Id = @Id";
                    cmd.Parameters.AddWithValue("@Id", poco.Id);

                    _connection.Open();
                    rowsEffected = cmd.ExecuteNonQuery();
                    _connection.Close();
                }
            }
        }

        public void Update(params ApplicantSkillPoco[] items)
        {
            using (SqlConnection _connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand()
                {
                    Connection = _connection
                };
                int rowsEffected = 0;
                foreach (ApplicantSkillPoco poco in items)
                {
                    cmd.CommandText = @"UPDATE Applicant_Skills 
                                    SET Applicant = @Applicant, 
	                                    Skill = @Skill, 
	                                    Skill_Level = @SkillLevel, 
	                                    Start_Month = @StartMonth, 
	                                    Start_Year = @StartYear, 
                                        End_Month = @EndMonth, 
	                                    End_Year = @EndYear 
	                                    
                                    WHERE Id = @Id";
                    cmd.Parameters.AddWithValue("@Id", poco.Id);
                    cmd.Parameters.AddWithValue("@Applicant", poco.Applicant);
                    cmd.Parameters.AddWithValue("@Skill", poco.Skill);
                    cmd.Parameters.AddWithValue("@SkillLevel", poco.SkillLevel);
                    cmd.Parameters.AddWithValue("@StartMonth", poco.StartMonth);
                    cmd.Parameters.AddWithValue("@StartYear", poco.StartYear);
                    cmd.Parameters.AddWithValue("@EndMonth", poco.EndMonth);
                    cmd.Parameters.AddWithValue("@EndYear", poco.EndYear);

                    _connection.Open();
                    rowsEffected = cmd.ExecuteNonQuery();
                    _connection.Close();
                }
            }
        }
    }
}
