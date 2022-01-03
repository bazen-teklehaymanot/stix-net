using System.IO;

using StixNet.Base;

using Xunit;

namespace StixNet.Tests;

public class STIXObjectParserTests
{

    [Fact]
    public void Should_ParseSTIXObject()
    {
        var path = Path.Combine("TestFiles", "attack-pattern.stix2");
        var text = File.ReadAllText(path);
        var isParsed = STIXObjectParser.TryParseSTIXObject(text, out STIXObject obj);
        Assert.True(isParsed);
        Assert.NotNull(obj);
    }

    [Fact]
    public void Should_ParseBundleObject()
    {
        var path = Path.Combine("TestFiles", "bundle-object.stix2");
        var text = File.ReadAllText(path);
        var isParsed = STIXObjectParser.TryParseBundleObject(text, out BundleObject obj);
        Assert.True(isParsed);
        Assert.NotNull(obj);
    }
}
