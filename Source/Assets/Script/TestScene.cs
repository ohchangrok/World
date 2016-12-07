using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class TestScene : Base_Scene {

    public GameObject m_objPlayer = null;
    public GameObject m_ObjStartPosion = null;
	void Start ()
    {
        //GameObject Player = Instantiate(m_objPlayer);
        m_objPlayer.GetComponent<CharacterPlayer>().Init();
        MainSystem.m_pSceneMain = this;
        //Player.GetComponent<NavMeshAgent>().Warp(m_ObjStartPosion.transform.position);
        //MainSystem.m_SceneChangeTemp.Add(Player);
        // m_objPlayer.transform.position = m_ObjStartPosion.transform.position;
        //m_objPlayer.transform.rotation = m_ObjStartPosion.transform.rotation;
    }
	
	// Update is called once per frame
	void Update ()
    {
        
    }
}
