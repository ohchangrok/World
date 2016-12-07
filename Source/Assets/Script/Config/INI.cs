using UnityEngine;
using System.Collections;

public static class INI
{
    public static string m_sMainSceneName = "Scene_Main";
    public static float m_fPlayerMakeDistance = 0.5f;
	
    //RunGame;
    public static float m_fRunBlockSpeed = 5f;//블럭이 내려오는 속도 및 벌래가 내려오는 속도
    public static Vector3 m_vLoadPosition = new Vector3(1000f, 1000f, 1000f); //리소스를 구석에 모아놓은 위치
    public static Vector2 m_vEnemyCrateTime = new Vector2(3f, 5f); //몬스터가 생성되는 시간 최소 / 최대
}
