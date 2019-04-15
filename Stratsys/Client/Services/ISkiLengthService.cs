using System.Threading.Tasks;
using Client.Models;

namespace Client.Services
{
    public interface ISkiLengthService
    {
        Task<string> Fetch(Skiier skiier);
    }
}