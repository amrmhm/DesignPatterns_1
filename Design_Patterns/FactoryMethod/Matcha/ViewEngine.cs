namespace Design_Patterns.FactoryMethod.Matcha;

public interface ViewEngine
{
    string Render(string ViewName, Dictionary<string, object> context);

}