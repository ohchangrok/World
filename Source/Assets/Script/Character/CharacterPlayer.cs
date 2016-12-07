using UnityEngine;
using System.Collections;

public class CharacterPlayer : BaseCharacter
{
    AnimationController m_pAnimationController = null;

    public  override void Init()
    {
        base.m_pNav = gameObject.GetComponent<NavMeshAgent>();
        base.m_eTag = eTAG_Type.Player;
        m_pAnimationController = GetComponent<AnimationController>();
        MainSystem.m_pListCharacter.Add((BaseCharacter)this);

		base.m_bInit = true;
    }
    public override void Action(Base_TouchObject pSendObj)
    {
        m_pNav.Resume();
        m_pNav.SetDestination(pSendObj.m_pMovePoint.transform.position);
        m_objTarget = pSendObj;
        m_eAniState = eSTATE_Animation.RUN;
        m_fDelayTime = 0.02f;
    }

    public override void Action(BaseCharacter pChar)
    {


    }

    public  override void Action(Vector3 _pos)
    {
        m_pNav.Resume();
        m_pNav.SetDestination(_pos);
        m_eAniState = eSTATE_Animation.RUN;
        m_fDelayTime = 0.02f;
        m_vTargetPos = _pos;
    }

    void FixedUpdate()
    {
		if (!base.m_bInit) return;
			
        if(Utillity.ModifiFixedTime(ref m_fDelayTime))
        {
            //Debug.Log(m_eAniState);
            switch (m_eAniState)
            {
                case eSTATE_Animation.IDLE:
                    IDLE();
                    break;
                case eSTATE_Animation.RUN:
                    Move();
                    break;
            }
        }

        m_pAnimationController.SetAnimation(m_eAniState);

    }

    void Move()
    {
        if (m_objTarget != null) //특정대상에게 다가가기
        {
            
            float dis = Vector3.Distance(m_objTarget.m_pMovePoint.transform.position, transform.position);
            Debug.Log(dis);
            if (dis <= INI.m_fPlayerMakeDistance)
            {
                Debug.Log("1");
                m_objTarget.Action();
                m_pNav.Stop();
                m_objTarget = null;
                m_eAniState = eSTATE_Animation.IDLE;
            }
            //return;
            //m_fDelayTime = Random.Range(1f, 2f);
            m_fDelayTime = Random.Range(0.05f, 0.1f);

        }
        else if (m_vTargetPos != Vector3.zero)
        {
            
            float dis = Vector3.Distance(m_vTargetPos, transform.position);
            //Debug.Log(dis);
            if (dis <= INI.m_fPlayerMakeDistance)
            {
                Debug.Log("2");

                m_eAniState = eSTATE_Animation.IDLE;
            }
            m_fDelayTime = Random.Range(0.05f, 0.1f);
        }
        else
        {
            m_eAniState = eSTATE_Animation.IDLE;
            m_fDelayTime = Random.Range(0.25f, 0.5f);
        }
        //else
        //{
        //    m_fDelayTime = Random.Range(0.25f, 0.5f);
        //    m_eAniState = eSTATE_Animation.RUN;
        //}
    }
    void IDLE()
    {


    }
}
