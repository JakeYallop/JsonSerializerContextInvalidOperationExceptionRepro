using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

public class MyClass
{
    //[Compare("Password", ErrorMessageResourceType = "")]
    //[Required(ErrorMessage = "")]
    [Derived(ErrorMessage = "")]
    public string Property { get; set; } = null!;
}

public abstract class BaseAttribute : Attribute
{
    public string ErrorMessage { get; set; } = null!;
}

[AttributeUsage(AttributeTargets.All)]
public class DerivedAttribute : BaseAttribute
{
}


[JsonSourceGenerationOptions]
[JsonSerializable(typeof(MyClass))]
public partial class JsonContext : JsonSerializerContext
{

}