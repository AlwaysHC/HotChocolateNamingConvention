namespace HotChocolateNamingConvention;

public class Book {
    public string Title {
        get; set;
    } = "";

    public Author Author {
        get; set;
    } = new Author();
}

public class Author {
    public string Name {
        get; set;
    } = "";
}
