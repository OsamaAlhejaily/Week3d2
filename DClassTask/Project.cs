using System.ComponentModel.DataAnnotations;

public class Project{
[Key]
public int Id {get;set;}
[Required]
public string Title {get;set;}

public DateTime StartDate {get;set;}
public DateTime EndDate {get;set;}
public List<EmployeeProject> EmployeeProjects {get;set;} = new();


}