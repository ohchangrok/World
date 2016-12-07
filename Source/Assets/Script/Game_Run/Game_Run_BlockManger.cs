using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class Game_Run_BlockManger : MonoBehaviour
{

    ArrayList m_objTrackList = null;
    GameObject[] m_pArrayActive = null;
    float m_fSpeed = INI.m_fRunBlockSpeed;
    Vector3 m_vPos = Vector3.zero;
    int i = 0;
    float m_fAddZ = 0f;
    
    public void Init(ArrayList _blickRes)
    {
        int i = 0;
        
        m_objTrackList = _blickRes;
        m_pArrayActive = new GameObject[2];
        for (i = 0; i < m_pArrayActive.Length; i++)
        {
            m_pArrayActive[i] = (GameObject)m_objTrackList[i];
            m_vPos.z += 80 * i;
            m_pArrayActive[i].transform.position = m_vPos;
        }
    }

    void Update()
    {
        BlockMoved();
    }
    void BlockMoved()
    {
        m_fAddZ = Time.deltaTime * m_fSpeed;
        GameObject m_Temp = null;
        for (i = 0; i < m_pArrayActive.Length; i++)
        {
            m_vPos = m_pArrayActive[i].transform.position;
            m_vPos.z -= m_fAddZ;
            m_pArrayActive[i].transform.position = m_vPos;
            if (m_vPos.z <= -80f)
            {
                m_Temp = m_pArrayActive[i];
                m_Temp.transform.position = new Vector3(-80f, 0f, 0f);
            }
        }


        if (m_Temp != null)
        {
            GameObject[] Change = new GameObject[2];
            for (i = 0; i < m_pArrayActive.Length; i++)
            {
                if (m_pArrayActive[i] != m_Temp)
                {
                    Change[0] = m_pArrayActive[i];
                    Change[0].transform.position = Vector3.zero;
                    break;
                }
            }

            int randomIndex = 0;
            for (i = 0; i < m_objTrackList.Count; i++)
            {
                if (Change[0] == (GameObject)m_objTrackList[i])
                {
                    //randomIndex = GetRandomIndex(i);
                    randomIndex = i;
                    while (i == randomIndex)
                    {
                        randomIndex = Random.Range(0, 3);
                    }
                    Debug.Log(randomIndex);
                    Change[1] = (GameObject)m_objTrackList[randomIndex];
                    Change[1].transform.position = new Vector3(0f, 0f, 80f);
                    break;
                }
            }
            m_pArrayActive[0] = Change[0];
            m_pArrayActive[1] = Change[1];
        }
    }


}


