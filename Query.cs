namespace HotChocolateNamingConvention;

public class Query {
    public Book GetBook() =>
        new() {
            Title = "C# in depth.",
            Author = new Author {
                Name = "Jon Skeet"
            }
        };
}
