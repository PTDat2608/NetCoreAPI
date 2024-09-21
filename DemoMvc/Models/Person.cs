using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DemoMvc.Models.Entities
{
    public class Person
    {
        public string PersonID { get; set;}
        public string FullName { get; set;}

        public string Diachi { get; set;}

    }
}