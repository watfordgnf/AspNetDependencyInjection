﻿using System;

namespace AspNetDependencyInjection
{
	/// <summary>Informs <see cref="AspNetDependencyInjection.Internal.DependencyInjectionWebObjectActivator"/> which service-types should not be created using the configured <see cref="IServiceProvider"/> and should instead always be constructed using ASP.NET's default activator (as though no <see cref="System.Web.HttpRuntime.WebObjectActivator"/> were set).</summary>
	public interface IDependencyInjectionFallbackService
	{
		/// <summary>Returns the <see cref="IServiceProvider"/> for the specified service <paramref name="type"/>. Returns <c>false</c> if the specified service <paramref name="type"/> should be provided by the configured AspNetDependencyInjection.</summary>
		Boolean TryGetServiceProvider( Type type, out IServiceProvider serviceProvider );
	}
}
