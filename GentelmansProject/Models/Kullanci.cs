using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GentelmansProject.Models
{
    public class Kullanci
    {
        public int Id { get; set; }

        public string Name { get; internal set; } = string.Empty;

        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;

        //public DateTime CreateData { get; set; } = DateTime.Now;

    }


}
