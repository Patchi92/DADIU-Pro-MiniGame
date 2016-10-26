using UnityEngine;
using System.Collections;


public class PickUpWeapon : PickupAbstract, PickUpAction
{
    public float shotForce = 3000f;
    public float moveSpeed = 10f;

    public void activation()
    {
        print("Weapon");
        //Transform clone = this.transform;
        //GameObject clone = Instantiate(playerControl, transform.position, transform.rotation) as GameObject;

        // Add force to the cloned object in the object's forward direction
        //clone.rigidbody.AddForce(clone.transform.forward * shootForce);

        GameObject projectile = Instantiate(playerControl.Projectile, playerControl.transform.position, playerControl.transform.rotation) as GameObject;
        Rigidbody shot = projectile.GetComponent<Rigidbody>();

        Debug.Log(playerControl.Projectile);
        shot.AddForce(playerControl.transform.forward * shotForce);

    }



    // Update is called once per frame
    void Update()
    {

    }

}
