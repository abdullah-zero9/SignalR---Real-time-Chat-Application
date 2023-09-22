using Microsoft.AspNetCore.SignalR;
using System.Security.Claims;

namespace ChatServiceWithSignalR.Models
{
    public class CustomerUserIdProvider : IUserIdProvider
    {
        public string? GetUserId(HubConnectionContext connection)
        {
            return connection.User?.FindFirst(ClaimTypes.Email)?.Value;
        }
    }
}
