using System.Reflection;


var result = ClassFactory(2, "123");
var propertyInfo = result.GetType().GetProperty("Property");
Console.WriteLine("result is " + result.GetType().Name
                               + " and Property = " +
                               propertyInfo.GetValue(result));


object ClassFactory(int classType, object arg)
{
    object? obj; 
    Type? type = null;
    PropertyInfo? propertyInfo = null;
    switch (classType)
    {
        case 1:
            obj = new Class1();
            type = typeof(Class1);
            propertyInfo = type.GetProperty("Property");
            propertyInfo.SetValue(obj, arg);
            break;
        case 2:
            obj = new Class2();
            type = typeof(Class2);
            propertyInfo = type.GetProperty("Property");
            propertyInfo.SetValue(obj, arg);
            break;
        default:
            throw new ArgumentException();
    }
    return obj;
}

class Class1
{
    public int Property { get; set; }
}

class Class2
{
    public string Property { get; set; }
}