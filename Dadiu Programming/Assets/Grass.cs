using UnityEngine;
using System.Collections;

public class Grass : MonoBehaviour {

    GameObject player;
    GameObject[] AI;
    GameObject AItoDamage;


    void Awake ()
    {

    }

    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionStay(Collision other)
    {
        

        if (other.gameObject.tag == "Player")
        {
            --other.gameObject.GetComponent<PlayerControl>().health;
        }

        if (other.gameObject.tag == "AI")
        {
            --other.gameObject.GetComponent<AI>().health;
        }

    }

    

}
