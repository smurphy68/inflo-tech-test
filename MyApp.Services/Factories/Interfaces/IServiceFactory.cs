using MyApp.Models;
using MyApp.Services.Domain.Interfaces;

namespace MyApp.Services.Factories.Interfaces
{
    public interface IServiceFactory
    {
        IUserService UserService { get; }
    }


}