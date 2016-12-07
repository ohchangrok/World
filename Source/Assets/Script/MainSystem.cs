using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public static class MainSystem
{
    public static Base_Scene m_pSceneMain    = null;
    public static GameObject m_objMainUi     = null; //현제의 메인씬UI
    public static GameObject m_ObjMainCamera = null; //메인카메라
    public static string m_sPrevSceneName     = INI.m_sMainSceneName; //현제로드된씬
    public static Dictionary<UInt64, Base_TouchObject> m_pDicTouch = new Dictionary<ulong, Base_TouchObject>();
    public static ArrayList m_pListCharacter = new ArrayList();
    public static UInt64 m_iConut = 0;
    public static List<GameObject> m_SceneChangeTemp = new List<GameObject>();
    public static Vector3 m_vPrevPos = Vector3.zero;



    public static bool m_bPopup = false;
	public static Dictionary<String, object> m_ObjTemps = new Dictionary<string, object> (); //각게임상에서 사용될 오젝트의 토탈


    public static UInt64 GetUIDPublish()
    {
        return ++m_iConut;
    }
    public static void ClearData()
    {
        m_pListCharacter.Clear();
        //m_pSceneMain = null;


    }
}
