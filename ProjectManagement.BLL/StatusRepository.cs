using ProjectManagement.MODEL;
using ProjectManagement.DAL.DBContext;
using Microsoft.EntityFrameworkCore;

namespace ProjectManagement.BLL
{
    public static class StatusRepository
    {
        public static void Add(Status _status)
        {
            using(var dbContext = new ApplicationDbContext())
            {
                dbContext.Add(_status);
                dbContext.SaveChanges();
            }
        }

        public static Status GetById(int Id) 
        {
            using(var dbContext = new ApplicationDbContext())
            {
                var status = dbContext.Status.Single(p => p.Id == Id);
                return status;
            }
        }

        public static List<Status> GetAll()
        {
            using(var dbContext = new ApplicationDbContext())
            {
                var status = dbContext.Status.ToList();
                return status;
            }
        }

        public static void Update(Status _status)
        {
            using(var dbContext = new ApplicationDbContext())
            {
                var status = dbContext.Status.Single(p => p.Id == _status.Id);
                status.Id = _status.Id;
                status.Status1 = _status.Status1;
                dbContext.SaveChanges();
            }
        }

        public static void Delete(Status _status)
        {
            using(var dbContext = new ApplicationDbContext())
            {
                var status = dbContext.Status.Single(p => p.Id == _status.Id);
                dbContext.Remove(status);
                dbContext.SaveChanges();
            }
        }
    }
}