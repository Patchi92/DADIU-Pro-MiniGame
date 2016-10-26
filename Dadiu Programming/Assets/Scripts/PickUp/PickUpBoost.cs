using UnityEngine;
using System.Collections;


public class PickUpBoost : PickupAbstract, PickUpAction
{

    //public float boost = 5f;


    public void activation()
    {
        playerControl.accelerationSpeed += base.boost;
		playerControl.moveSpeed += base.boost * 3;
	

    }


	
	// Update is called once per frame
	void Update () {
	
	}


}
