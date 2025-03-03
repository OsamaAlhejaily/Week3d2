public class Department{
    public int Id{get;set;}
    public string location{get;set;}

    public List<Employee> employees{get;set;} = new();
}