using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Game_Run_AnimationController : MonoBehaviour
{

    //public Animator m_pAni = null;
    public eSTATE_Animation m_eCurAni = eSTATE_Animation.IDLE;
    public Animation m_pAni = null;
    public bool m_bInit = false;
	void Start ()
    {
        m_pAni = GetComponent<Animation>();
        SetAnimation(eSTATE_Animation.RUN);
        m_bInit = true;


    }
    public void SetAnimation(eSTATE_Animation _eAni)
    {
        if (!m_bInit) return;

        if (m_eCurAni == _eAni) return;
        Debug.Log(gameObject.name);
        Debug.Log(_eAni);
        gameObject.SetActive(true);
        
        if (m_pAni.GetClip(_eAni.ToString()) == null)
        {
            gameObject.SetActive(false);
            return;
        }
        m_pAni.CrossFade(_eAni.ToString());
        
        //m_pAni.SetInteger("STATE",(int)_eAni);
        m_eCurAni = _eAni;

        
    }
    float GetAnimationTime(eSTATE_Animation _eAni)
    {
        AnimationClip pClip = m_pAni.GetClip(_eAni.ToString());
        if (pClip != null) return pClip.length;

        return 0f;
    }
    IEnumerator LoadingAni(eSTATE_Animation _eAni, float _time)
    {
        yield return new WaitForSeconds(_time);

        SetAnimation(_eAni);
    }
}
