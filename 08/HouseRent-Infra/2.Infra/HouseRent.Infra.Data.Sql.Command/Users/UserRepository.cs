using HouseRent.Core.Domain.Users;
using HouseRent.Core.Domain.Users.Entities;
using HouseRent.Core.Domain.Users.Repositories;
using HouseRent.Infra.Data.Sql.Command.Framework;
using HouseRent.Infra.Data.Sql.Command.Shared;

namespace HouseRent.Infra.Data.Sql.Command.Users;

internal sealed class UserRepository(HouseRentDbContext dbContext) :
    BaseCommandRepository<User, long>(dbContext), IUserRepository
{
}