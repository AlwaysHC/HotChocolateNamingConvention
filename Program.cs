using HotChocolate.Types.Descriptors;
using HotChocolateNamingConvention;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

WebApplicationBuilder Builder = WebApplication.CreateBuilder(args);

Builder.Services
    //.AddSingleton<INamingConventions, NamingConventions>()
    .AddInMemorySubscriptions()
    .AddGraphQLServer()
    .AddQueryType<Query>()
    .AddMutationType<Mutation>()
    .AddSubscriptionType<Subscription>();

WebApplication App = Builder.Build();

App.UseRouting();

App.UseWebSockets();

App.MapGraphQL();

App.Run();
