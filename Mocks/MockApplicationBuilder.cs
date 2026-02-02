using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;

namespace Shipstone.Test.Mocks;

public sealed class MockApplicationBuilder : IApplicationBuilder
{
    public Func<Func<RequestDelegate, RequestDelegate>, IApplicationBuilder> _useFunc;

    IServiceProvider IApplicationBuilder.ApplicationServices
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    IDictionary<String, Object?> IApplicationBuilder.Properties =>
        throw new NotImplementedException();

    IFeatureCollection IApplicationBuilder.ServerFeatures =>
        throw new NotImplementedException();

    public MockApplicationBuilder() =>
        this._useFunc = _ => throw new NotImplementedException();

    RequestDelegate IApplicationBuilder.Build() =>
        throw new NotImplementedException();

    IApplicationBuilder IApplicationBuilder.New() =>
        throw new NotImplementedException();

    IApplicationBuilder IApplicationBuilder.Use(Func<RequestDelegate, RequestDelegate> middleware) =>
        this._useFunc(middleware);
}
