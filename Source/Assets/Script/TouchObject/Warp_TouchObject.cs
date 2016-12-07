using UnityEngine;
using System.Collections;

public class Warp_TouchObject : Base_TouchObject
{
    public string m_sChangeScene = "Scene_House";

    public override void Init()
    {
        base.Init();
    }
    public override void Action()
    {
        base.Action();
        Debug.Log("Warp_TouchObject");
        for (int i = 0; i < MainSystem.m_SceneChangeTemp.Count; i++)
        {
            Destroy(MainSystem.m_SceneChangeTemp[i]);
        }
        ((Base_Scene)MainSystem.m_pSceneMain).LoadScene(m_sChangeScene);
    }

    void Update ()
    {
	
	}
}
