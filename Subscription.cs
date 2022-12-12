using HotChocolate;
using HotChocolate.Types;

namespace HotChocolateNamingConvention;

public class Subscription {
    [Subscribe]
    public Book BookAdded([EventMessage] Book book) => book;
}