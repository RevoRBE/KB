using System.Collections.Generic;

namespace Gallery.Models
{
    public class Author
    {
        public int Id { get; set; }

        public string NickName { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName => FirstName + " " + LastName;

        //public virtual ICollection<AuthorWorks> Works { get; set; }
    }
}