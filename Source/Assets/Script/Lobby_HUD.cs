using UnityEngine;
using System.Collections;

public class Lobby_HUD : MonoBehaviour
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
                        pChar.Action(hit.point);

                    else if (objHit.layer == LayerMask.NameToLayer("Object"))
                    {
                        Debug.Log("Object Tuch");
                        Base_TouchObject pObj = objHit.GetComponent<Base_TouchObject>();
                        if (pObj.m_pMovePoint != null)
                        {
                            Debug.Log("1");
                            pChar.Action(pObj);
                        }
                        else
                        {
                            Debug.Log("2");
                            pChar.Action(objHit.transform.position);
                            
                        }
                    }
                }
            }
        }
    }
}
