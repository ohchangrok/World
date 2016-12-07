using UnityEngine;
using System.Collections;


public class UI_Touch : MonoBehaviour
{
    

    //public delegate void OnClickEvent(GameObject g);
    public event OnPressEvent OnClick;

    void OnPress(bool _isPress)
    {
        if (OnClick != null)
            OnClick(this.gameObject, _isPress);
    }
}
