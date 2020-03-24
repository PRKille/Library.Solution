using System.Collections.Generic;

namespace Library
{
  public class Author
  {
    public Author()
    {
      this.Books = new HashSet<BookAuthor>();
    }
    public int AuthorId {get;set;}
    public string Name {get;set;}
    public virtual ICollection<BookAuthor> Books {get;set;}
  }
}