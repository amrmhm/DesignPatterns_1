using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Singleton;

public class ConfigManger
{
    private Dictionary<string , object> mangers = new Dictionary<string, object>();
    private static ConfigManger instance = new ConfigManger();
    private ConfigManger() { }

    public void set(string key, object value)
    {
        mangers[key] = value;
    }

    public object get(string key)
    {
        return mangers[key];
    }
    public static ConfigManger getInstance()
    {
        return instance;
    }
}
