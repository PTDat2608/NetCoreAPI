using System.ComponentModel.DataAnnotations;
namespace DemoMvc.Models.Entities
{

    public class Person
    {
    [Key]
    public string PersonID { get; set; }
    public string HoTen { get; set; }
    public string QueQuan { get; set; }
    }
}