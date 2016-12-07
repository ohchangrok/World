using UnityEngine;
using System.Collections;

public class Scene_Data_Run : MonoBehaviour {

	private static Scene_Data_Run instance = null;
	public static Scene_Data_Run GetInstance
	{
		get
		{ 
			if (instance == null) 
			{
				GameObject obj = new GameObject ();
				instance = obj.AddComponent<Scene_Data_Run>();
				DontDestroyOnLoad (obj);
			}
			return instance;
		}
	}
	public GameObject m_ObjPlayer = null;
    public GameObject m_ObjWeapon = null;
	public ArrayList m_blicks = null;
	public GameObject m_ObjBug = null;
	public SoundManager m_SoundManager = null; 
	public GameObject m_ObjCamera = null;
    public GameObject m_ObjLobby = null;
    public GameObject m_objMovePoint = null;
    public GameObject m_objHud = null;

    public GameObject GetNearPoint(Vector3 _curPos)
    {
        Base_TouchObject[] pbase = m_objMovePoint.transform.GetComponentsInChildren<Base_TouchObject>();
        GameObject obj = pbase[0].gameObject;
        for (int i = 0; i < pbase.Length; i++)
        {
            float Prevdis = Vector3.Distance(obj.transform.position, _curPos);
            float Curdis = Vector3.Distance(pbase[i].transform.position, _curPos);
            if (Curdis < Prevdis)
                obj = pbase[i].gameObject;
        }
        return obj;
    }
}
