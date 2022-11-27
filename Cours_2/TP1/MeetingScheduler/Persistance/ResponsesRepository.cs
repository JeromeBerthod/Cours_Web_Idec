using Microsoft.AspNetCore.Mvc;

using MeetingScheduler.Models;

namespace MeetingScheduler.Persistance
{
    public static class Repository
    {
        private static readonly List<GuestResponse> responses = new();
        public static IEnumerable<GuestResponse> Responses => responses;
        public static void AddResponse(GuestResponse response)
        {
            Console.WriteLine(response);
            responses.Add(response);
        }
    }
}
