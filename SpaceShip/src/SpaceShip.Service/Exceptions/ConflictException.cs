﻿using System.Net;

namespace SpaceShip.Services.Exceptions;

/// <summary>
/// Conflict (409) exception.
/// </summary>
public class ConflictException : BaseException
{
    #region constructor

    /// <summary>
    /// Constructor.
    /// </summary>
    public ConflictException(string message)
        : base(HttpStatusCode.Conflict, message)
    {
    }

    #endregion
}
