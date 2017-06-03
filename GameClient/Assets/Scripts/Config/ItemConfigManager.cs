using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ItemConfigManager{

    public List<ItemConfig> cfgList;

    public ItemConfigManager()
    {
        cfgList = new List<ItemConfig>();
    }

    private static ItemConfigManager _instance;

    public static ItemConfigManager instance()
    {
        if (_instance == null)
            _instance = new ItemConfigManager();
        return _instance;
    }

    public void setup(Object obj)
    {
        ItemConfig cfhInfo;
        foreach (object cfg in obj)
        {

        }
    }
}
