using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AnimationController : MonoBehaviour {

    public Animator m_pAni = null;
    public eSTATE_Animation m_eCurAni = eSTATE_Animation.IDLE;
    

	void Start ()
    {
        m_pAni = GetComponent<Animator>();
        
    }
    public void SetAnimation(eSTATE_Animation _eAni)
    {
        if (m_eCurAni == _eAni) return;

        m_pAni.CrossFade(_eAni.ToString(), 0.02f);
        //m_pAni.Play(_eAni.ToString());
        m_pAni.SetInteger("STATE",(int)_eAni);
        m_eCurAni = _eAni;

        //for (int i = 0; i < m_pSubAni.Count; i++)
        //{
        //    m_pSubAni[i].CrossFade

        //}
    }
    void GetAnimationTime(eSTATE_Animation _eAni)
    {
        

    }	
	
	
}
