using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reposition : MonoBehaviour
{
    void OnTriggerExit2D(Collider2D coll)
    {
        if (!coll.CompareTag("Area"))
            return;

        Vector3 playerPos = GameMgr.Inst.player.transform.position;
        Vector3 myPos = transform.position;
        float diffX = Mathf.Abs(playerPos.x - myPos.x);
        float diffY = Mathf.Abs(playerPos.y - myPos.y);

        Vector3 playerDir = GameMgr.Inst.player.inputVec;
        float dirX = playerDir.x < 0 ? -1 : 1;
        float dirY = playerDir.y < 0 ? -1 : 1;

        switch(transform.tag)
        {
            case "Ground":
                if (diffX > diffY)
                    transform.Translate(Vector3.right * dirX * 60);
                else if (diffX < diffY)
                    transform.Translate(Vector3.right * dirY * 60);
                break;
            case "Enemy":
                break;
        }

    }
}
