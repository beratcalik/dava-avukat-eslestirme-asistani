public class Lawyer
{
    public int Id { get; set; }
    public string FirstName { get; set; }      
    public string LastName { get; set; }       
    public DateTime DateOfBirth { get; set; }
    public string MobileNumber { get; set; }
    public DateTime EmploymentDate { get; set; }      
    public int WorkGroupId { get; set; }             
    public virtual WorkGroup WorkGroup { get; set; }  
}
