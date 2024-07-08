using ChatAppWithSignalR.Models;
using System.Threading.Tasks;

namespace ChatAppWithSignalR.Services
{
    public interface IChatService
    {
        Task AddMessageAsync(Message message);
    }
}
