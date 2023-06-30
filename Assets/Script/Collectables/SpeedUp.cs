using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUp : SideEffect
{
    public override void activate() {
        PlayerMove playerMove = this.gameObject.GetComponent<PlayerMove>();
        playerMove.moveSpeed += 2f;
        playerMove.leftRightSpeed += 1;
        playerMove.jumpSpeed += 1;
    }

    public override void deActivate() {
        PlayerMove playerMove = this.gameObject.GetComponent<PlayerMove>();
        playerMove.moveSpeed -= 2f;
        playerMove.leftRightSpeed -= 1;
        playerMove.jumpSpeed -= 1;
        // this.gameObject.GetComponent<SpeedUp>().enabled = false;
        Destroy(this);
    }
}
