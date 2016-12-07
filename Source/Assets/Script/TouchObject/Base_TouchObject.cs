using UnityEngine;
using System;
using System.Collections;

public abstract class Base_TouchObject : MonoBehaviour
{
    public bool m_bWarpObject = false;
    public UInt64 m_uID = 0;
    bool m_bPause = false;
    public GameObject m_pMovePoint = null;
    public eBGA_Type eType = (eBGA_Type)0;
    
    void Start()
    {
        m_pMovePoint = transform.FindChild("MovePoint").gameObject;
    }

    public virtual void Init()
    {
        m_uID = MainSystem.GetUIDPublish();
    }
    
    
    UInt64 GetTouch()
    {
        return m_uID;
    }

    /// <summary>
    /// Action
    /// - 이 오브젝트의 액션을 관리한다.
    /// </summary>
    public virtual void Action() { Debug.Log("Parent"); }
    
    
}
