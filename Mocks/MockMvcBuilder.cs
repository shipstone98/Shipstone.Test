using System;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.Extensions.DependencyInjection;

namespace Shipstone.Test.Mocks;

public sealed class MockMvcBuilder : IMvcBuilder
{
    public Func<ApplicationPartManager> _partManagerFunc;

    ApplicationPartManager IMvcBuilder.PartManager => this._partManagerFunc();

    IServiceCollection IMvcBuilder.Services =>
        throw new NotImplementedException();

    public MockMvcBuilder() =>
        this._partManagerFunc = () => throw new NotImplementedException();
}
