using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using LitJson;

public class ItemConfigManager
{

    private string sourceName = "item";

    public Dictionary<int,ItemConfig> cfgDic;

    public ItemConfigManager()
    {
        cfgDic = new Dictionary<int, ItemConfig>();
    }

    private static ItemConfigManager _instance;

    public static ItemConfigManager instance()
    {
        if (_instance == null)
            _instance = new ItemConfigManager();
        return _instance;
    }

    public void setup()
    {
        ItemConfig cfgInfo;
        JsonData jd = ParseJsonUtil.Instance().ParseJsonToData(sourceName);
        for (int i = 0; i < jd.Count; i++)
        {
            cfgInfo = JsonMapper.ToObject<ItemConfig>(jd[i].ToJson());
            cfgDic.Add(cfgInfo.itemId,cfgInfo);
        }
    }

    public ItemConfig getCfgById(int id)
    {
        if (cfgDic.ContainsKey(id))
            return cfgDic[id];
        return null;
    }
}
