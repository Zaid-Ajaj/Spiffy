﻿using System;
using System.Data;

namespace Spiffy
{
    /// <summary>
    /// Database unit of work.
    /// </summary>
    public interface IDbUnit : IDbHandler, IDisposable
    {
        /// <summary>
        /// Commit transaction & cleanup.
        /// </summary>
        void Commit();

        /// <summary>
        /// Rollback transaction & cleanup.
        /// <summary>
        void Rollback();

        /// <summary>
        /// Execute paramterized query and manually cursor IDataReader.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql"></param>		
        /// <param name="param"></param>
        /// <returns></returns>
        IDataReader Read(string sql, DbCommandParams param = null);
    }
}