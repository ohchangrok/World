using UnityEngine;
using System.Collections;

public class Game_Run_EnemyManager : MonoBehaviour {

    int m_iEnemyMaxCount = 10;
    public float m_fCreatTime = 0f;
    int m_iMaxCreatePos = 0;
	public void Init (GameObject _res)
    {
        GameObject obj = null;
        for (int i = 0; i < m_iEnemyMaxCount; i++)
        {
            obj = Instantiate(_res) as GameObject;
            obj.SetActive(true);
            obj.transform.position = INI.m_vLoadPosition;
            obj.transform.rotation = Quaternion.identity;
            
            Character_Run_Enemy pEnemy = obj.GetComponent<Character_Run_Enemy>();
            pEnemy.Init();
            MainSystem.m_pListCharacter.Add(pEnemy);
            obj.SetActive(false);
        }
        m_fCreatTime = UnityEngine.Random.Range(INI.m_vEnemyCrateTime.x, INI.m_vEnemyCrateTime.y);

        m_iMaxCreatePos = Scene_Data_Run.GetInstance.m_objMovePoint.GetComponentsInChildren<Base_TouchObject>().Length;
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (MainSystem.m_bPopup) return;
        if (Utillity.ModifiFixedTime(ref m_fCreatTime))
        {
            m_fCreatTime = UnityEngine.Random.Range(INI.m_vEnemyCrateTime.x, INI.m_vEnemyCrateTime.y);
            Create();
        }
	}
    void Create()
    {
        int index = UnityEngine.Random.Range(0, m_iMaxCreatePos);
        Vector3 pos = Scene_Data_Run.GetInstance.m_objMovePoint.transform.FindChild(index.ToString()).transform.position;

        BaseCharacter pEnemy = null;
        for (int i = 0; i < MainSystem.m_pListCharacter.Count; i++)
        {
            BaseCharacter pChar = (BaseCharacter)MainSystem.m_pListCharacter[i];
            if (!pChar.gameObject.activeSelf && pChar.m_eTag == eTAG_Type.ENEMY)
                pEnemy = pChar;
        }
        if (pEnemy == null) return;

        pEnemy.gameObject.SetActive(true);
        pEnemy.transform.position = pos + new Vector3(0f, 0f, 80f);



    }
}
