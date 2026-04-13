using App_Pustok.Models;
using PustokMvcApp.Models.Common;

namespace PustokMvcApp.Models
{
    public class Author : BaseEntity
    {
        public string FullName { get; set; }
        public List<Book> Books { get; set; }
    }
}
