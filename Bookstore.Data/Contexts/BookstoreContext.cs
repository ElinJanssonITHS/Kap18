
namespace Bookstore.Data;

public class BookstoreContext : DbContext
{
    public DbSet<Author> Author { get; set; }
    public DbSet<Book> Books { get; set;}
    public DbSet<Publisher> Publisher { get; set;}
    public BookstoreContext(DbContextOptions<BookstoreContext> options)
        : base(options) { }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        SeedData(builder);
    }
    private void SeedData(ModelBuilder builder)
    {
        var publishers = new List<Publisher>()
        {
            new Publisher {Id = 1, Name = "Publisher 1"},
            new Publisher {Id = 2, Name = "Publisher 2"},
            new Publisher {Id = 3, Name = "Publisher 3"},
        };
        builder.Entity<Publisher>().HasData(publishers);

        var authors = new List<Author>()
        {
            new Author {Id = 1, FirstName = "John", LastName = "Doe"},
            new Author {Id = 2, FirstName = "Jane", LastName = "Doe"}
        };
        builder.Entity<Author>().HasData(authors);

        var books = new List<Book>()
        {
            new Book() {Id = 1, Isbn ="ABC123", Title ="Title 1", PublisherId  = 1},
            new Book() {Id = 1, Isbn ="BCD123", Title ="Title 2", PublisherId  = 2},
            new Book() {Id = 1, Isbn ="XYZ987", Title ="Title 3", PublisherId  = 3},
        };
        builder.Entity<Book>().HasData(books);
    }
}
