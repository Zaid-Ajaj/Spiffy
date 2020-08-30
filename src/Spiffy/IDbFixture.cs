﻿using System;

namespace Spiffy
{    
    /// <summary>
    /// Represents an interface to a specific database.
    /// </summary>
    /// <typeparam name="TFixture"></typeparam>
    public interface IDbFixture<TFixture> : IDbHandler where TFixture : IDbConnectionFactory
    {
        /// <summary>
        /// Create a new IDbUnit, which represents a database unit of work.
        /// </summary>
        /// <returns></returns>
        IDbUnit NewBatch();        
    }
}
