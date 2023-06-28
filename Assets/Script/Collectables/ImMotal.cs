using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImMotal : SideEffect
{
    public GameObject boss;
    public Color previousColor;
    public override void activate() {
        boss = this.gameObject.transform.Find("The Boss@Run").gameObject;
        boss.GetComponent<ChangeColor>().ChangeClothColor(new Color(1f, 0f, 0f, 0.5f));
    }

    public override void deActivate() {
        boss.GetComponent<ChangeColor>().RecoverClothColor();
        Destroy(this);
    }
}
