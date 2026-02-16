using System;
using Microsoft.Extensions.Options;

namespace Shipstone.Test.Mocks;

public sealed class MockOptionsSnapshot<TOptions>
    : MockOptions<TOptions>, IOptionsSnapshot<TOptions>
    where TOptions : class
{
    TOptions IOptionsSnapshot<TOptions>.Get(String? name) =>
        throw new NotImplementedException();
}
