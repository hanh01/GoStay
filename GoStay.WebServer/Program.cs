
using GoStay.Peter;
using HotelApiV56.Api;


var builder = WebApplication.CreateBuilder(args);
// builder.Services.AddSingleton<IHomePageApi>(new HomePageApi(Environment.GetEnvironmentVariable("API_HOST")));
// builder.Services.AddSingleton<IListingDetailPageApi>(new ListingDetailPageApi(Environment.GetEnvironmentVariable("API_HOST")));
// builder.Services.AddSingleton<IProfilePageApi>(new ProfilePageApi(Environment.GetEnvironmentVariable("API_HOST")));
// builder.Services.AddSingleton<ICollectionPageApi>(new CollectionPageApi(Environment.GetEnvironmentVariable("API_HOST")));
var app=ServiceCollectionExtensions.MakeApp(args, builder);

app.Run();

