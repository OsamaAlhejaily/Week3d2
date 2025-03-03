using System.ComponentModel.DataAnnotations.Schema;

public class Employee{
    public int employeeId {get;set;}
    public string employeeName {get;set;}
    public double salary {get;set;}
    [NotMapped]
    public double bonus {get;set;}
    public double performanceRating {get;set;}
    public Department dept {get;set;}
    public int deptId;
    public List<EmployeeProject> EmployeeProjects {get;set;} = new();
    
}