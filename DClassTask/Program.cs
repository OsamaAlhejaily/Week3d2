using Microsoft.Data.SqlClient;
using Dapper;
class Program
{
    static void Main()
    {
        string connectionString = "Server=localhost;Database=EmpDeptProject;Trusted_Connection=True;TrustServerCertificate=True;";


using (var connection = new SqlConnection(connectionString))
{
    

}
using (var context = new AddDBContext())
{   
    DateTime sixMonthsAgo = DateTime.Now.AddMonths(-6).Date;

    var employees = context.EmployeeProjects
    .Where(ep => ep.StartDate >= sixMonthsAgo) 
    .GroupBy(ep => ep.EmployeeId)
    .Where(group => group.Count() >= 3)
    .Select(group => new 
    {
        EmployeeId = group.Key,
        EmployeeName = context.Employees
            .Where(e => e.employeeId == group.Key)
            .Select(e => e.employeeName)
            .FirstOrDefault(),
        ProjectCount = group.Count()
    })
    .ToList();

    var recentProjects = context.EmployeeProjects
    .Where(ep => ep.StartDate >= sixMonthsAgo)
    .ToList();

foreach (var ep in recentProjects)
{
    Console.WriteLine($"Employee ID: {ep.EmployeeId}, Project ID: {ep.ProjectId}, Start Date: {ep.StartDate}");
}

using (var connection = new SqlConnection(connectionString))
{
    connection.Open();  
    string sqlQuery = @"
        SELECT 
            e.employeeName AS EmployeeName, 
            p.Title AS ProjectName, 
            p.EndDate AS ProjectDeadline
        FROM EmployeeProjects ep
        INNER JOIN Employees e ON ep.EmployeeId = e.employeeId
        INNER JOIN Projects p ON ep.ProjectId = p.Id;
    ";

    var employeeProjects = connection.Query<EmployeeProjectDto>(sqlQuery).ToList();


    Console.WriteLine("Employee - Project Assignments:");
    foreach (var ep in employeeProjects)
    {
        Console.WriteLine($"Employee: {ep.EmployeeName}, Project: {ep.ProjectName}, Deadline: {ep.ProjectDeadline}");
    }
}
using (var connection = new SqlConnection(connectionString))
        {
            connection.Open(); 
            
            
            string sqlQuery = "EXEC CalculateEmployeeBonuses";

            var employees = connection.Query<Employee>(sqlQuery).ToList();  // ✅ Directly map to Employee class

            
            Console.WriteLine("Employee Bonus:");
            foreach (var emp in employees)
            {
                Console.WriteLine($"Employee: {emp.employeeName}, Salary: {emp.salary:C}, Rating: {emp.performanceRating}, Bonus: {emp.bonus:C}");
            }
        }






    
}

 

    }
}