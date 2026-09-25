using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopDemo.Data
{
    public class Author
    {
        public Author()
        {
            this.AuthorBooks = new HashSet<AuthorBook>();
        }
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        [MinLength(3)]
        public string Name { get; set; }

        [Required]
        [MaxLength(30)]
        [MinLength(3)]
        public string LastName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Phone { get; set; }

        public ICollection<AuthorBook> AuthorBooks { get; set; }
    }
}
