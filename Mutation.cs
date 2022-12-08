using System.Threading.Tasks;
using HotChocolate;
using HotChocolate.Subscriptions;

namespace HotChocolateNamingConvention;

public class Mutation {
    public Book SetBook(string Title) =>
        new() {
            Title = Title,
            Author = new Author {
                Name = "Jon Skeet"
            }
        };

    public async Task<Book> AddBook(Book Book, [Service] ITopicEventSender sender) {
        await sender.SendAsync(nameof(Subscription.BookAdded), Book);
        return Book;
    }
}
