using ChatAppWithSignalR.Models;
using ChatAppWithSignalR.Data;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace ChatAppWithSignalR.Services
{
    public class ChatService : IChatService
    {
        private readonly ApplicationDbContext _context;

        public ChatService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddMessageAsync(Message message)
        {
            _context.Messages.Add(message);
            await _context.SaveChangesAsync();
        }

        public async Task<Chat> GetChatByIdAsync(int chatId)
        {
            return await _context.Chats
                .Include(c => c.Messages)
                .FirstOrDefaultAsync(c => c.Id == chatId);
        }
    }
}

