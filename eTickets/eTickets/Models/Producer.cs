using System.ComponentModel.DataAnnotations;
namespace eTickets.Models;

public class Producer
{
    [Key] public string ProducerId { get; set; }
    public string ProfilePictureURL { get; set; }
    public string FullName { get; set; }
    public string Bio { get; set; }
}