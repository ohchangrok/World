using UnityEngine;
using System.Collections;

public class Game_Run_HUD : MonoBehaviour
{
	void Start ()
    {
        UIEventListener pTouch = gameObject.transform.FindChild("LobbyTouch").GetComponent<UIEventListener>();
        pTouch.onPress += Press;
    }
	
	void Update ()
    {
       
    }

    public void Press(GameObject _obj, bool _isPress)
    {
        if (MainSystem.m_bPopup) return;
        //Debug.Log(_obj.name);

        if (_obj.name == "LobbyTouch")
        {
            if (!_isPress)
            {
                UICamera.MouseOrTouch pCurTouch = UICamera.currentTouch;
                if (_isPress) return;
                Vector3 pos = UICamera.currentTouch.pos;


                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
                int layer = (1 << (LayerMask.NameToLayer("Object")) | 1 << (LayerMask.NameToLayer("Ground")));
                if (Physics.Raycast(ray, out hit, layer))
                {
                    GameObject objHit = hit.transform.gameObject;

                    BaseCharacter pChar = Utillity.GetCharacterObject(eTAG_Type.Player);

                    if (pChar == null) return;

                    if (objHit.layer == LayerMask.NameToLayer("Ground"))
                    {
                        pChar.Action(hit.point);
                    }
                    else if (objHit.layer == LayerMask.NameToLayer("Object"))
                    {
                        Debug.Log("Object Tuch");
                        Base_TouchObject pObj = objHit.GetComponent<Base_TouchObject>();
                        BaseCharacter pEnemy = objHit.GetComponent<BaseCharacter>();
                        if (pObj != null)
                        {
                            if (pObj.m_pMovePoint != null)
                            {
                                pChar.Action(pObj);
                            }
                            else
                            {
                                pChar.Action(objHit.transform.position);
                            }
                        }
                        else if (pEnemy != null)
                        {
                            Debug.Log("1.5");
                            float dis = Vector3.Distance(pChar.transform.position, pEnemy.transform.position);
                            GameObject obj = Scene_Data_Run.GetInstance.GetNearPoint(pEnemy.transform.position);
                            pChar.Action(pEnemy);
                            ((Character_Run_Player)pChar).m_vTargetPos = obj.transform.position;
                        }
                        
                    }
                    
                }
            }
        }
    }
}
