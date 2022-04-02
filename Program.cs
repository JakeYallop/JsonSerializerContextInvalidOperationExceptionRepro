using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

Console.WriteLine("Hello world!");

public class MyClass
{
    [Derived(BaseProperty = "")] //source generator does not compile
    //[Derived(DerivedProperty = "", BaseProperty = "")] //does not compile
    //[Derived] //compiles fine
    //[Derived(DerivedProperty = "")] //compiles fine
    public string Property { get; set; } = null!;
}

public abstract class BaseAttribute : Attribute
{
    public string BaseProperty { get; set; } = null!;
}

[AttributeUsage(AttributeTargets.All)]
public class DerivedAttribute : BaseAttribute
{
    public string DerivedProperty { get; set; } = null!;
}

[JsonSourceGenerationOptions]
[JsonSerializable(typeof(MyClass))]
public partial class JsonContext : JsonSerializerContext
{

}