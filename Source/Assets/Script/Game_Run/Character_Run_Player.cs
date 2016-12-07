using UnityEngine;
using System.Collections;

public class Character_Run_Player : BaseCharacter
{
    public Game_Run_AnimationController m_pPlayerAni = null;
    public Game_Run_AnimationController m_pWeaponAni = null;
    public GameObject m_pWeapon = null;
    public float m_fSpeed = 5f;

    public  override void Init()
    {
        base.m_eTag = eTAG_Type.Player;
        m_pPlayerAni = GetComponent<Game_Run_AnimationController>();
        base.m_bInit = true;
        m_eAniState = eSTATE_Animation.IDLE;
        MainSystem.m_pListCharacter.Add((BaseCharacter)this);
        m_pWeapon = Scene_Data_Run.GetInstance.m_ObjWeapon;
    }
    public override void Action(Base_TouchObject pSendObj)
    {
        TargetReset();
        m_eAniState = eSTATE_Animation.RUN;
        m_vTargetPos = pSendObj.gameObject.transform.position;
        m_fDelayTime = 0.02f;
        m_objTarget = pSendObj;
    }

    public override void Action(BaseCharacter pChar)
    {
        TargetReset();
        m_pTargetCharacter = pChar;
        m_vTargetPos = pChar.transform.position;
        m_eAniState = eSTATE_Animation.RUN;
        m_fDelayTime = 0.02f;
        
    }

    public  override void Action(Vector3 _pos)
    {
        TargetReset();
        m_eAniState = eSTATE_Animation.RUN;
        m_vTargetPos = _pos;
        m_fDelayTime = 0.02f;
    }

    void FixedUpdate()
    {
        if (m_eAniState == eSTATE_Animation.IDLE)
        {
            m_pPlayerAni.SetAnimation(eSTATE_Animation.RUN);
            m_pWeaponAni.SetAnimation(eSTATE_Animation.RUN);
        }
        else
        {
            m_pPlayerAni.SetAnimation(m_eAniState);
            m_pWeaponAni.SetAnimation(m_eAniState);

        }

        if (Utillity.ModifiFixedTime(ref m_fDelayTime))
        {
            switch (m_eAniState)
            {
                case eSTATE_Animation.RUN:
                    Move();
                    break;

                case eSTATE_Animation.IDLE:
                    IDLE();
                    break;

                case eSTATE_Animation.ATTACK:
                    ATTACK();
                    break;
            }
        }
    }

    void Move()
    {
        if (Vector3.Distance(m_vTargetPos, transform.position) < 0.2f)
        {
            transform.position = m_vTargetPos;
            m_pWeapon.transform.position = m_vTargetPos;
            m_vTargetPos = Vector3.zero;
            if (m_objTarget != null)
            {
                m_objTarget = null;
                m_eAniState = eSTATE_Animation.IDLE;
                m_fDelayTime = 0.02f;
            }
            else if (m_pTargetCharacter != null)
            {
                m_eAniState = eSTATE_Animation.ATTACK;
                m_fDelayTime = m_pPlayerAni.m_pAni.GetClip(m_eAniState.ToString()).length;
                Debug.Log("Time" + m_fDelayTime);
            }
        }
        else
        {
            Vector3 pos = m_vTargetPos - transform.position;
            transform.position += pos / 4f;
            m_pWeapon.transform.position += pos / 4f;

            m_fDelayTime = UnityEngine.Random.Range(0.001f, 0.002f);
        }
    }
    void ATTACK()
    {
        m_pTargetCharacter.Action(this);
        m_pTargetCharacter = null;
        m_eAniState = eSTATE_Animation.IDLE;
        m_fDelayTime = 0.02f;
    }
    void IDLE()
    {


    }
    void TargetReset()
    {
        m_objTarget = null;
        m_vTargetPos = Vector3.zero;
        m_pTargetCharacter = null;
    }
}
