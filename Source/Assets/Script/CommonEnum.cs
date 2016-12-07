using UnityEngine;
using System.Collections;

public delegate void OnPressEvent(GameObject _obj, bool _isBool);


public enum eRUN_ResTYPE 
{
	PLAYER = 0,
	BLICK = 1,
	BUG = 2,
	SOUNDMANAGER = 3,



}


public enum eTAG_Type
{
    Player  = 0, //플레이어
    NPC     = 1, //NPC
    ENEMY   = 2, //적
}
public enum eBGA_Type
{
    Zone = 0,

}
public enum eSTATE_Animation
{
    IDLE = 0,
    IDLE_RANDOM = 1,
    RUN = 2,
    TALK = 4,
    DIE =5,
    HIT = 6,
    ATTACK = 7,
    HIT_UP = 10,
}