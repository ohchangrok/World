using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Base_Scene : MonoBehaviour
{
    public bool m_bScenePause = false;

	public void LoadScene(string _scene, bool _isReturn = false)
    {
        MainSystem.m_sPrevSceneName = SceneManager.GetActiveScene().name;
        
        MainSystem.m_vPrevPos = Utillity.GetCharacterObject(eTAG_Type.Player).transform.position;
        MainSystem.ClearData();
        SceneManager.LoadScene(_scene);
    }
    
}
