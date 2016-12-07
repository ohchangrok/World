using UnityEngine;
using System.Collections;

public class Game_Run_GameManager : MonoBehaviour {

	Game_Run_BlockManger m_pBlockM = null;
    
	void Start () 
	{
        for (int i = 0; i < Scene_Data_Run.GetInstance.m_blicks.Count; i++)
            ((GameObject)Scene_Data_Run.GetInstance.m_blicks[i]).SetActive(true);

        m_pBlockM = gameObject.AddComponent<Game_Run_BlockManger> ();
		m_pBlockM.Init (Scene_Data_Run.GetInstance.m_blicks);

        //movePoint
        GameObject obj = Scene_Data_Run.GetInstance.m_objMovePoint;
        obj.SetActive(true);
        obj.transform.position = Vector3.zero;
        obj = obj.transform.FindChild("1").gameObject;
        Vector3 pos  = obj.transform.position;
        Quaternion q = obj.transform.rotation;

        //player
        obj = Scene_Data_Run.GetInstance.m_ObjPlayer;
        GameObject weapon = Scene_Data_Run.GetInstance.m_ObjWeapon;
        weapon.SetActive(true);
        obj.SetActive(true);
        obj.transform.position = pos;
        obj.transform.rotation = q;
        weapon.transform.position = pos;
        weapon.transform.rotation = q;
        Character_Run_Player pChar = obj.AddComponent<Character_Run_Player>();
        pChar.m_pWeaponAni = weapon.GetComponent<Game_Run_AnimationController>();
        pChar.Init();

        //camera
        obj = Scene_Data_Run.GetInstance.m_ObjCamera;
        obj.SetActive(true);
        obj.transform.position = Vector3.zero;

        obj = Scene_Data_Run.GetInstance.m_objHud;
        obj.SetActive(true);
        obj.GetComponent<Game_Run_HUD>();

        MainSystem.m_bPopup = false;

        Game_Run_EnemyManager pEM = gameObject.AddComponent<Game_Run_EnemyManager>();
        pEM.Init(Scene_Data_Run.GetInstance.m_ObjBug);




    }
	

	void Update () {
	
	}
}
