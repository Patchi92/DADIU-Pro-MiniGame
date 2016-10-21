using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {


    Rigidbody carRigid;
    Transform carTransfrom;
    Renderer rend;

    public GameObject cam;
    public Shader vertexAni;

    public float moveSpeed;
    public float reverseSpeed;
    public float accelerationSpeed;
    public float accelerationReduce;
    public float breakSpeed;
    public float maxSpeed;
    public float maxReverse;

    public bool active;
    
    void Awake ()
    {
        carRigid = GetComponent<Rigidbody>();
        carTransfrom = GetComponent<Transform>();
        rend = GetComponent<Renderer>();
        active = false;
    }
    

    void Start () {
	
	}


    void FixedUpdate()
    {
        carRigid.velocity += new Vector3(0f, -2f, 0f);

        if (active)
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



            }
            else
            {
                if (moveSpeed > 0f)
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
                FunkyTime();
            }
        }


    }
	
	// Update is called once per frame
	void Update () {
	
        

    }

    public void FunkyTime()
    {
        cam.GetComponent<ShaderCam>().funky = true;

        rend.material.shader = vertexAni;
        rend.material.SetFloat("_AnimSpeed", 100f);
        rend.material.SetFloat("_AnimPowerX", 0.1f);
        rend.material.SetFloat("_AnimPowerY", 0f);
        rend.material.SetFloat("_AnimPowerZ", 0.1f);
        rend.material.SetFloat("_AnimOffsetX", 10f);
        rend.material.SetFloat("_AnimOffsetY", 10f);
        rend.material.SetFloat("_AnimOffsetZ", 10f);
    }
}
