using ProjectManagement.MODEL;
using ProjectManagement.DAL.DBContext;
using Microsoft.EntityFrameworkCore;

namespace ProjectManagement.BLL
{
    public class StatusRepository
    {
        public void Add(Status _status)
        {
            using(var dbContext = new ApplicationDbContext())
            {
                dbContext.Add(_status);
                dbContext.SaveChanges();
            }
        }

        public Status GetById(int Id) 
        {
            using(var dbContext = new ApplicationDbContext())
            {
                var status = dbContext.Statuses.Single(p => p.Id == Id);
                return status;
            }
        }

        public List<Status> GetAll()
        {
            using(var dbContext = new ApplicationDbContext())
            {
                var status = dbContext.Statuses.ToList();
                return status;
            }
        }

        public void Update(Status _status)
        {
            using(var dbContext = new ApplicationDbContext())
            {
                var status = dbContext.Statuses.Single(p => p.Id == _status.Id);
                status.Id = _status.Id;
                status.Status1 = _status.Status1;
                dbContext.SaveChanges();
            }
        }

        public void Delete(Status _status)
        {
            using(var dbContext = new ApplicationDbContext())
            {
                var status = dbContext.Statuses.Single(p => p.Id == _status.Id);
                dbContext.Remove(status);
                dbContext.SaveChanges();
            }
        }
    }
}