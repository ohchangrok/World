using UnityEngine;
using System;
using System.Collections;
using UnityEngine.SceneManagement;

using System.Collections.Generic;

public class Scene_Load_Run : MonoBehaviour {

	public GameObject m_ObjPlayer = null;
    public GameObject m_objWeapon = null;
    public GameObject[] m_ObjBlicks = null;
	public GameObject m_SoundManger = null;
	public GameObject m_ObjBugs = null;
	public GameObject m_ObjCamera = null;
	public GameObject m_objMovePoint = null;
    public GameObject m_pPanelLoading = null; //로딩페널
    public GameObject m_objLobby = null;
    public GameObject m_objHud = null;
    UILabel m_pLabel = null;
    UISprite m_pSprite = null;
	//코루틴으로 선언후 데터를 다운로드 할잇게 하자.
	IEnumerator Start () 
	{
        //TODO LoadResource
        //데터 관련 메져로서 데터를 들있도록한다.
        GameObject obj = Instantiate(m_pPanelLoading) as GameObject;
        obj.transform.position = Vector3.zero;


        m_pLabel = obj.transform.FindChild("Pivot/LabelPercent").GetComponent<UILabel>();
        m_pSprite = obj.transform.FindChild("Pivot/SpriteFilled").GetComponent<UISprite>();
        LoadingUpdate(0f);
        yield return null;

        //Player
        obj = Instantiate(m_ObjPlayer) as GameObject;
		obj.transform.position = INI.m_vLoadPosition;
		obj.transform.localScale = Vector3.one * 25;
		DontDestroyOnLoad (obj);
        obj.SetActive(false);
        Scene_Data_Run.GetInstance.m_ObjPlayer = obj;
        LoadingUpdate(0.25f);
        yield return null;

        obj = Instantiate(m_objWeapon) as GameObject;
        obj.transform.position = INI.m_vLoadPosition;
        obj.transform.localScale = Vector3.one * 25;
        DontDestroyOnLoad(obj);
        obj.SetActive(false);
        Scene_Data_Run.GetInstance.m_ObjWeapon = obj;

        //BGA Block
        Scene_Data_Run.GetInstance.m_blicks = new ArrayList();
		for(int i = 0 ; i < m_ObjBlicks.Length; i++)
		{
			obj = Instantiate (m_ObjBlicks [i]) as GameObject;
			obj.transform.position = INI.m_vLoadPosition;
			Scene_Data_Run.GetInstance.m_blicks.Add (obj);
			DontDestroyOnLoad (obj);
            obj.SetActive(false);
            Debug.Log (i);
		}


		//Sound
		DontDestroyOnLoad (m_SoundManger);
		Scene_Data_Run.GetInstance.m_SoundManager = m_SoundManger.GetComponent<SoundManager> ();
        LoadingUpdate(0.5f);
        yield return null;

        //Bug
        obj = Instantiate(m_ObjBugs) as GameObject;
		obj.transform.position = INI.m_vLoadPosition;
		Scene_Data_Run.GetInstance.m_ObjBug = obj;
		DontDestroyOnLoad (obj);
        obj.SetActive(false);
        LoadingUpdate(0.75f);
        yield return null;

        obj = Instantiate (m_ObjCamera) as GameObject;
		obj.transform.position = Vector3.zero;
		obj.transform.localRotation = Quaternion.identity;
		obj.transform.localScale = Vector3.one;
		Scene_Data_Run.GetInstance.m_ObjCamera = obj;
        DontDestroyOnLoad (obj);
        obj.SetActive(false);

        obj = Instantiate(m_objLobby) as GameObject;
        obj.SetActive(false);
        Scene_Data_Run.GetInstance.m_ObjLobby = obj;
        DontDestroyOnLoad(obj);

        obj = Instantiate(m_objMovePoint) as GameObject;
        obj.SetActive(false);
        Scene_Data_Run.GetInstance.m_objMovePoint = obj;
        obj.transform.position = INI.m_vLoadPosition;
        obj.SetActive(false);
        DontDestroyOnLoad(obj);

        obj = Instantiate(m_objHud) as GameObject;
        obj.SetActive(false);
        Scene_Data_Run.GetInstance.m_objHud = obj;
        DontDestroyOnLoad(obj);

        LoadingUpdate(1f);
        yield return null;
        
        //TODO Scene을 로드하자.
        SceneManager.LoadSceneAsync("Scene_Play_RunLobby");

        MainSystem.m_pListCharacter.Clear();


    }
    void LoadingUpdate(float _fPercent)
    {
        m_pLabel.text = (_fPercent * 100f).ToString("N0") + "%";
        m_pSprite.fillAmount = _fPercent;
    }
	

}
