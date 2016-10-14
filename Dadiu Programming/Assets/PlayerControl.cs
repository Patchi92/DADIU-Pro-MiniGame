using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {


    Rigidbody carRigid;
    Transform carTransfrom;

    public float moveSpeed;
    public float reverseSpeed;
    public float accelerationSpeed;
    public float accelerationReduce;
    public float breakSpeed;
    public float maxSpeed;
    public float maxReverse;
    
    void Awake ()
    {
        carRigid = GetComponent<Rigidbody>();
        carTransfrom = GetComponent<Transform>();
    }
    

    void Start () {
	
	}


    void FixedUpdate()
    {

        carRigid.velocity = carTransfrom.forward * moveSpeed;

        if (Input.GetKey(KeyCode.W))
        {

            if (moveSpeed < maxSpeed && moveSpeed >= -6 && moveSpeed < 10)
            {
                moveSpeed = moveSpeed + accelerationSpeed;
            }

            if (moveSpeed < maxSpeed && moveSpeed >= 10 && moveSpeed < 15)
            {
                moveSpeed = moveSpeed + accelerationSpeed - 0.15f;
            }

            if (moveSpeed < maxSpeed && moveSpeed >= 15 && moveSpeed < 20)
            {
                moveSpeed = moveSpeed + accelerationSpeed - 0.25f;
            }



        } else
        {
            if(moveSpeed > 0f)
            {
                moveSpeed = moveSpeed - accelerationReduce;
            }
                 
        }

        if (Input.GetKey(KeyCode.S))
        {
            if (moveSpeed > maxReverse)
            {
                moveSpeed = moveSpeed - breakSpeed;
            }
        }

        if (Input.GetKey(KeyCode.A))
        {
            carTransfrom.Rotate(0, -1f, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            carTransfrom.Rotate(0, 1f, 0);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //carRigid.velocity += new Vector3(0f, 10f, 0f);
        }


    }
	
	// Update is called once per frame
	void Update () {
	
        

    }
}
