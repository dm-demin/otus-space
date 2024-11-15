﻿using GameController.Services.Models.User;

namespace GameController.Services.Interfaces
{
    /// <summary>
    /// Interface for working with users.
    /// </summary>
    public interface IUserService
    {
        /// <summary>
        /// Create a user.
        /// </summary>
        UserDto CreateUser(CreateUserDto createUserDto);

        /// <summary>
        /// Retrieve all users.
        /// </summary>
        List<UserDto> GetUsers();

        /// <summary>
        /// Retrieve the user by <paramref name="userId"/>.
        /// </summary>
        UserDto GetUser(Guid userId);

        /// <summary>
        /// Retrieve the user by <paramref name="userName"/>.
        /// </summary>
        UserDto GetUserByName(string userName);

        /// <summary>
        /// Update the user with <paramref name="userId"/>.
        /// </summary>
        Task<UserDto> UpdateUserAsync(Guid userId, UpdateUserDto updateUserDto);

        /// <summary>
        /// Delete the user with <paramref name="userId"/>.
        /// </summary>
        bool DeleteUser(Guid userId);
    }
}
