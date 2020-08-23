﻿using System.Data;

namespace Spiffy
{
    /// <summary>
    /// Represents a connection interface to a specific database.
    /// </summary>
    public interface IDbFixture
    {
        /// <summary>
        /// Create a new instance of an IDbConnection implementation.
        /// </summary>
        /// <returns></returns>
        IDbConnection NewConnection();
    }
}