using UnityEngine;
using System.Collections;

public class GameCamera : MonoBehaviour
{
    public GameObject m_objTarget = null;

    /// ============================================================================
    /// <summary>
    /// Init
    /// - 초기화
    /// </summary>
    /// ============================================================================
	public void Init(GameObject _target)
    {
        m_objTarget = _target;
    }

    /// ============================================================================
    /// <summary>
    /// LateUpdate
    /// - 업데이트
    /// </summary>
    /// ============================================================================
    void LateUpdate()
    {
        if (m_objTarget == null) return;

        Vector3 pos = m_objTarget.transform.position - this.gameObject.transform.position;
        pos /= 8f;
        transform.position += pos;
    }
}
