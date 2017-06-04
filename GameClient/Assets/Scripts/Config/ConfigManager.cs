using UnityEngine;
using System.Collections;

public class ConfigManager
{

    private static ConfigManager _instance;

    public static ConfigManager Instance()
    {
        if (_instance == null)
        {
            _instance = new ConfigManager();
        }
        return _instance;
    }

    //声明一个解析配置的委托
    public delegate void loader(Object obj);
    private loader configLoader;
    //初始化所有需要解析的配置
    public void InitLoader()
    {
        ItemConfigManager.instance().setup();
    }
    //解析所有配置
    public void ParseLoader()
    {

    }
}
