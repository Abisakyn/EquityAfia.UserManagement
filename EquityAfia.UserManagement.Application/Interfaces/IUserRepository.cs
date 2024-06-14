﻿

using EquityAfia.UserManagement.Domain.RolesAggregate.RolesEntity;
using EquityAfia.UserManagement.Domain.UserAggregate.UsersEntities;

namespace EquityAfia.UserManagement.Application.Interfaces
{
    public interface IUserRepository
    {
        Task<User> GetUserByIdAsync(string idNumber);
        Task<User> GetUserByEmailAsync(string email);
        Task AddUserAsync(User user);
        Task UpdateUserAsync(User user);
        Task DeleteUserAsync(Guid userId);
    }
}
