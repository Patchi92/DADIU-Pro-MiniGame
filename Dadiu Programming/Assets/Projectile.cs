using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {


    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("AI"))
        {
            // deal 100 dmg
            col.gameObject.GetComponent<AI>().health -= 100;

            
            Debug.Log(col.gameObject.name);

        }
    }
}
