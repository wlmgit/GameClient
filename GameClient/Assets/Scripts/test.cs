using UnityEngine;
using System.Collections;

public class test : MonoBehaviour {

	// Use this for initialization
	void Start () {
        ConfigManager.Instance().InitLoader();
        Debug.Log(ItemConfigManager.instance().getCfgById(11002).name);
        Debug.Log("test");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
