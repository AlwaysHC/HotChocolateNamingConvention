using HotChocolate;

namespace HotChocolateNamingConvention;

public class Book {
    public string Title {
        get; set;
    } = "";

    [GraphQLName("GRAPHQLNAME_NOT_Respected_WITH_Subscriptions")]
    public Author Author {
        get; set;
    } = new Author();
}

public class Author {
    public string Name {
        get; set;
    } = "";
}
