using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Scene_Main : Base_Scene
{
    public GameObject m_objPlayer = null;
    public GameObject m_objMainUI = null;
    public GameObject m_objMainCamera = null;
    void Awake()
    {
        MainSystem.m_pSceneMain = this;
        MainSystem.m_objMainUi = m_objMainUI;
        MainSystem.m_ObjMainCamera = m_objMainCamera;
        
    }

    void Start()
    {
        m_objPlayer.GetComponent<BaseCharacter>().Init();
        
        MainSystem.m_ObjMainCamera.GetComponent<GameCamera>().Init(m_objPlayer);//Camera
    }

    void Update()
    {
        //if (MainSystem.m_sCurSceneName != INI.m_sMainSceneName) return; //현제 메이씬이 선택된 상태가 아니라면은

        //if (Input.GetKeyUp(KeyCode.Mouse0))
        //    base.LoadScene("Scene_House");
    }

}
