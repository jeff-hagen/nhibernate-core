﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by AsyncGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


using System;
using System.Collections.Generic;
using System.Data.Common;
using NHibernate.Driver;

namespace NHibernate.Connection
{
	using System.Threading.Tasks;
	using System.Threading;
	public partial interface IConnectionProvider : IDisposable
	{

		/// <summary>
		/// Get an open <see cref="DbConnection"/>.
		/// </summary>
		/// <param name="cancellationToken">A cancellation token that can be used to cancel the work</param>
		/// <returns>An open <see cref="DbConnection"/>.</returns>
		Task<DbConnection> GetConnectionAsync(CancellationToken cancellationToken);
	}
}