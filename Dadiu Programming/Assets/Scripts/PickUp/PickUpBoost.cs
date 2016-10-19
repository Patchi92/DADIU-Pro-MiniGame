using UnityEngine;
using System.Collections;


public class PickUpBoost : MonoBehaviour, PickUpAction {

    public float boost = 5f;

    public PickUpBoost()
    {
        
    }

    public void activation()
    {
        print("BOOST");
        
    }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
