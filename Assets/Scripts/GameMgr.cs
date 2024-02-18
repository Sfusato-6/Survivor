using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMgr : MonoBehaviour
{
    public static GameMgr Inst;
    public PoolManager pool;
    public PlayerCtrl player;

    void Awake()
    {
        Inst = this;
    }

}
