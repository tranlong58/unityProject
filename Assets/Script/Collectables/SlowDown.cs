using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowDown : SideEffect
{
    public override void activate() {
        PlayerMove playerMove = this.gameObject.GetComponent<PlayerMove>();
        playerMove.moveSpeed -= 1;
        playerMove.leftRightSpeed -= 1;
        playerMove.jumpSpeed -= 1;
    }

    public override void deActivate() {
        PlayerMove playerMove = this.gameObject.GetComponent<PlayerMove>();
        playerMove.moveSpeed += 1;
        playerMove.leftRightSpeed += 1;
        playerMove.jumpSpeed += 1;
        // this.gameObject.GetComponent<SpeedUp>().enabled = false;
        Destroy(this);
    }
}
