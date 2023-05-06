using ProjectManagement.DAL.DBContext;
using ProjectManagement.MODEL;

namespace ProjectManagement.BLL
{
    public class ProjectRepository
    {
        public static void Add(Project _project)
        {
            using (var dbContext = new ApplicationDbContext())
            {
                dbContext.Add(_project);
                dbContext.SaveChanges();    
            }
        }

        public static Project GetById(int Id)
        {
            using (var dbContext = new ApplicationDbContext())
            {
                var project = dbContext.Projects.Single(p => p.Id == Id);
                return project;
            }
        }

        public static List<Project> GetAll()
        {
            using (var dbContext = new ApplicationDbContext())
            {
                var project = dbContext.Projects.ToList();
                return project;
            }
        }

        public static void Update(Project _project)
        {
            using (var dbContext = new ApplicationDbContext())
            {
                var project = dbContext.Projects.Single(p => p.Id == _project.Id);
                project.Id = _project.Id;
                project.ProjectName = _project.ProjectName;
                project.ManagerName = _project.ManagerName;
                project.StartDate = _project.StartDate;
                project.FinishDate = _project.FinishDate;
                project.Summary = _project.Summary;
                project.IdStatus = _project.IdStatus;
                dbContext.SaveChanges();
            }
        }

        public static void Delete(Project _project)
        {
            using (var dbContext = new ApplicationDbContext())
            {
                var project = dbContext.Status.Single(p => p.Id == _project.Id);
                dbContext.Remove(project);
                dbContext.SaveChanges();
            }
        }
    }
}