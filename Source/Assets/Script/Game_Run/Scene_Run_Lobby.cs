using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Scene_Run_Lobby : MonoBehaviour
{
    GameObject m_objUI = null;
    void Start()
    {
        MainSystem.m_bPopup = false;
        m_objUI = Scene_Data_Run.GetInstance.m_ObjLobby;
        m_objUI.SetActive(true);
        UIEventListener pTouch = m_objUI.transform.FindChild("Pivot/BGA").GetComponent<UIEventListener>();

        pTouch.onPress += Press;
    }
    public void Press(GameObject _obj, bool _isPress)
    {
        Debug.Log("Press");

        if (MainSystem.m_bPopup) return;
        MainSystem.m_bPopup = true;

        m_objUI.SetActive(false);
        SceneManager.LoadScene("Scene_Play_Run");
    }
}
