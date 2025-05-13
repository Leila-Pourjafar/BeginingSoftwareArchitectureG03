using HouseRent.Core.ApplicationServices.Contracts;
using HouseRent.Core.Domain.Users.ValueObjects;

namespace HouseRent.Infra.SimpleEmail;

internal sealed class FakeEmailService : IEmailService
{
    public Task SendAsync(Email recipient, string subject, string body)
    {
        Console.WriteLine(recipient);
        Console.WriteLine(subject);
        Console.WriteLine(body);
        return Task.CompletedTask;
    }
}