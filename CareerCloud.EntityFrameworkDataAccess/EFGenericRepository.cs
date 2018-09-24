using CareerCloud.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.EntityFrameworkDataAccess
{
    public class ApplicantProfileRepository<T> : IDataRepository<T> where T : class

    {
        private CareerCloudContext context;
        public ApplicantProfileRepository(bool createProxy = true)
        {
            context = new CareerCloudContext(createProxy);
        }
        public void Add(params T[] items)
        {
             foreach (T item in items)
            {
                context.Entry(item).State = System.Data.Entity.EntityState.Added;
            }
            context.SaveChanges() ;


        }

        public void CallStoredProc(string name, params Tuple<string, string>[] parameters)
        {
            throw new NotImplementedException();
        }

        public IList<T> GetAll(params Expression<Func<T, object>>[] navigationProperties)
        {
            IQueryable<T> dbQuery = context.Set<T>();
            foreach( Expression<Func<T, object>> navprop in navigationProperties){
                dbQuery = dbQuery.Include<T, object>(navprop);
            }
            return dbQuery.ToList();
        }

        public IList<T> GetList(Expression<Func<T, bool>> where, params Expression<Func<T, object>>[] navigationProperties)
        {
            IQueryable<T> dbQuery = context.Set<T>();
            foreach (Expression<Func<T, object>> navprop in navigationProperties)
            {
                dbQuery = dbQuery.Include<T, object>(navprop);
            }
            return dbQuery.Where(where).ToList();
        }

        public T GetSingle(Expression<Func<T, bool>> where, params Expression<Func<T, object>>[] navigationProperties)
        {
            IQueryable<T> dbQuery = context.Set<T>();
            foreach (Expression<Func<T, object>> navprop in navigationProperties)
            {
                dbQuery = dbQuery.Include<T, object>(navprop);
            }
            return dbQuery.FirstOrDefault(where);
        }

        public void Remove(params T[] items)
        {
            foreach (var item in items)
            {
                context.Entry(item).State = System.Data.Entity.EntityState.Deleted;
            }
            context.SaveChanges();
        }

        public void Update(params T[] items)
        {
            foreach (var item in items)
            {
                context.Entry(item).State = System.Data.Entity.EntityState.Modified;
            }
            context.SaveChanges();
        }
    }
}
