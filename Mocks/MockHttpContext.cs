using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;

namespace Shipstone.Test.Mocks;

public sealed class MockHttpContext : HttpContext
{
    public Func<IServiceProvider> _requestServicesFunc;
    public Func<ClaimsPrincipal> _userFunc;

    public sealed override ConnectionInfo Connection =>
        throw new NotImplementedException();

    public sealed override IFeatureCollection Features =>
        throw new NotImplementedException();

    public sealed override IDictionary<Object, Object?> Items
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public sealed override HttpRequest Request =>
        throw new NotImplementedException();

    public sealed override CancellationToken RequestAborted
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public sealed override IServiceProvider RequestServices
    {
        get => this._requestServicesFunc();
        set => throw new NotImplementedException();
    }

    public sealed override HttpResponse Response =>
        throw new NotImplementedException();

    public sealed override ISession Session
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public sealed override String TraceIdentifier
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public sealed override ClaimsPrincipal User
    {
        get => this._userFunc();
        set => throw new NotImplementedException();
    }

    public sealed override WebSocketManager WebSockets =>
        throw new NotImplementedException();

    public MockHttpContext()
    {
        this._requestServicesFunc = () => throw new NotImplementedException();
        this._userFunc = () => throw new NotImplementedException();
    }

    public sealed override void Abort() =>
        throw new NotImplementedException();

    public sealed override bool Equals(Object? obj) =>
        throw new NotImplementedException();

    public sealed override int GetHashCode() =>
        throw new NotImplementedException();

    public sealed override String? ToString() =>
        throw new NotImplementedException();
}
