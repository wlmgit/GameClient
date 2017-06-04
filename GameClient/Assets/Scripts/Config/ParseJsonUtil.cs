using System;
using UnityEngine;
using System.Collections;
using LitJson;

public class ParseJsonUtil
{
    private string sourcePath = "Configs/";

	private static ParseJsonUtil _instance;

    public static ParseJsonUtil Instance()
    {
        if (_instance == null)
        {
            _instance = new ParseJsonUtil();
        }
        return _instance;
    }

    public JsonData ParseJsonToData(string sourceName)
    {
        sourcePath += sourceName;
        TextAsset txtAsset = Resources.Load(sourcePath) as TextAsset;
        JsonData jsoData = JsonMapper.ToObject(txtAsset.text);
        return jsoData;
    }
}
