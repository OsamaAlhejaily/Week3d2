using Microsoft.EntityFrameworkCore;

public class AddDBContext : DbContext{
    public DbSet<Department> Departments {get;set;}
    public DbSet<Employee> Employees {get;set;}
    public DbSet<Project> Projects {get;set;}
    public DbSet<EmployeeProject> EmployeeProjects {get;set;}

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlServer("Server=.;Database=EmpDeptProject;Trusted_Connection=True;TrustServerCertificate=True");

     
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Project>()
    .HasKey(p => p.Id); 

        
        modelBuilder.Entity<Employee>()
        .HasOne(e => e.dept)
        .WithMany(d => d.employees)
        .HasForeignKey(e => e.deptId);
        modelBuilder.Entity<Department>().HasData(
            new Department { Id = 1, location = "Riyadh" },
            new Department { Id = 2, location = "Jeddah" },
            new Department { Id = 3, location = "Dammam" }
        );

         modelBuilder.Entity<EmployeeProject>()
        .HasKey(ep => new { ep.EmployeeId, ep.ProjectId }); 

    modelBuilder.Entity<EmployeeProject>()
        .HasOne(ep => ep.Employee)
        .WithMany(e => e.EmployeeProjects)
        .HasForeignKey(ep => ep.EmployeeId);

    modelBuilder.Entity<EmployeeProject>()
        .HasOne(ep => ep.Project)
        .WithMany(p => p.EmployeeProjects)
        .HasForeignKey(ep => ep.ProjectId);

        modelBuilder.Entity<Employee>().HasData(
            new Employee { employeeId = 1, employeeName = "Ahmed Al-Qahtani", salary = 12000, performanceRating = 92.0,deptId = 1 },
            new Employee { employeeId = 2, employeeName = "Khalid Al-Mutairi", salary = 15000,performanceRating = 65.0, deptId = 2 },
            new Employee { employeeId = 3, employeeName = "Faisal Al-Dosari", salary = 10000, performanceRating = 22.0,deptId = 3 },
            new Employee { employeeId = 4, employeeName = "Mansour Al-Harbi", salary = 14000,performanceRating = 66.0, deptId = 1 },
            new Employee { employeeId = 5, employeeName = "Saud Al-Otaibi", salary = 13000, performanceRating = 77.0,deptId = 2 }
        );

        
            modelBuilder.Entity<Project>().HasData(
    new Project { Id = 1, Title = "Vision 2030 project", StartDate = new DateTime(2024, 06, 17) ,EndDate = new DateTime(2024, 09, 17)},
    new Project { Id = 2, Title = "E-Commerce", StartDate = new DateTime(2024, 04, 07) ,EndDate = new DateTime(2024, 07, 07)},
    new Project { Id = 3, Title = "Cloud computing", StartDate = new DateTime(2024, 05, 19),EndDate = new DateTime(2024, 08, 19) },
    new Project { Id = 4, Title = "Cybersecurity", StartDate = new DateTime(2024, 08, 05),EndDate = new DateTime(2024, 11, 05) },
    new Project { Id = 5, Title = "Digital Banking", StartDate = new DateTime(2024, 04, 18),EndDate = new DateTime(2024, 07, 18) }
);
    modelBuilder.Entity<EmployeeProject>().HasData(
    new EmployeeProject { EmployeeId = 1, ProjectId = 1, StartDate = new DateTime(2024, 03, 01) },
    new EmployeeProject { EmployeeId = 1, ProjectId = 2, StartDate = new DateTime(2024, 02, 15) },
    new EmployeeProject { EmployeeId = 1, ProjectId = 3, StartDate = new DateTime(2024, 01, 10) },
    new EmployeeProject { EmployeeId = 2, ProjectId = 1, StartDate = new DateTime(2024, 04, 20) },
    new EmployeeProject { EmployeeId = 2, ProjectId = 4, StartDate = new DateTime(2024, 05, 05) }
);



    }
}