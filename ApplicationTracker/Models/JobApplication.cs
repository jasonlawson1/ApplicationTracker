namespace ApplicationTracker.Models;

public class JobApplication
{
    public int Id { get; set; }
    public string CompanyName { get; set; }
    public String Role { get; set; }
    public ApplicationStatus Status { get; set; } = ApplicationStatus.Applied
    public DateTime DateApplied { get; set; } =  DateTime.UtcNow;
    public string? Notes { get; set; }

    public enum ApplicationStatus
    {
        Applied, 
        PhoneScreen,
        Interview,
        Offer,
        Rejected,
        Withdrawn  
    }
}