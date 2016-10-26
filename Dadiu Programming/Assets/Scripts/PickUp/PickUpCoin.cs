using UnityEngine;
using System.Collections;


public class PickUpCoin : PickupAbstract, PickUpAction
{
    public void activation()
    {
        playerControl.health += base.healthRepair;
    }


    // Update is called once per frame
    void Update()
    {

    }


}
