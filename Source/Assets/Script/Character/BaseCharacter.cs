using UnityEngine;
using System.Collections;

public abstract class BaseCharacter : MonoBehaviour
{
    public float            m_fDelayTime = 0f;
    public Vector3          m_vTargetPos = Vector3.zero;
    public eTAG_Type        m_eTag       = (eTAG_Type)0;
    public NavMeshAgent     m_pNav       = null; //네비메쉬
    public Base_TouchObject m_objTarget  = null;
    public BaseCharacter m_pTargetCharacter = null;
    public eSTATE_Animation m_eAniState  = eSTATE_Animation.IDLE;
	public bool m_bInit = false;

    public abstract void Init();
    public abstract void Action(BaseCharacter pChar);
    public abstract void Action(Base_TouchObject pSendObj);
    public abstract void Action(Vector3 _pos);
}
