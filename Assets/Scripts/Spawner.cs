using Goldmetal.UndeadSurvivor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    void Update()
    {
        if(Input.GetButtonDown("Jump"))
        {
            GameMgr.Inst.pool.Get(0);
        }
    }
}
