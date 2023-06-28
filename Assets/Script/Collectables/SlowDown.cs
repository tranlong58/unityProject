using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowDown : SideEffect
{
    public override void activate() {
        PlayerMove playerMove = this.gameObject.GetComponent<PlayerMove>();
        playerMove.moveSpeed /= 2f;
    }

    public override void deActivate() {
        PlayerMove playerMove = this.gameObject.GetComponent<PlayerMove>();
        playerMove.moveSpeed *= 2f;
        // this.gameObject.GetComponent<SpeedUp>().enabled = false;
        Destroy(this);
    }
}
