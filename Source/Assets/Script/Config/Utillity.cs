using UnityEngine;
using System.Collections;

public static class Utillity
{
    public static bool ModifiFixedTime(ref float _fixdedTime)
    {
        if (_fixdedTime <= 0f) return false;
        _fixdedTime -= Time.fixedDeltaTime;
        if (_fixdedTime <= 0f) return true;
        else return false;
    }

    //public static ArrayList GetCharacterList(string _tag)
    //{
    //    ArrayList pList = new ArrayList();
    //    for (int i = 0; i < CoreSyetem.m_pListCharacter.Count; i++)
    //    {
    //        GameObject obj = ((BaseCharacter)CoreSyetem.m_pListCharacter[i]).gameObject;
    //        if (obj.tag == "Player")
    //        {
    //            pList.Add(obj);
    //            break;
    //        }
    //    }
    //    return pList;
    //}
    
    public static BaseCharacter GetCharacterObject(eTAG_Type type)
    {
        for (int i = 0; i < MainSystem.m_pListCharacter.Count; i++)
        {
            BaseCharacter pChar = (BaseCharacter)MainSystem.m_pListCharacter[i];
            if (pChar.m_eTag == type)
            {
                return pChar;
            }
        }
        return null;
    }
    
}
