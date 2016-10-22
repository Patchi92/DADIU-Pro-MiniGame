﻿using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {


    Rigidbody carRigid;
    Transform carTransfrom;
    Renderer rend;

    public GameObject cam;
    public GameObject camBack;
    public Shader vertexAni;
    public Shader standardShader;

    public float moveSpeed;
    public string gear;
    public float reverseSpeed;
    public float accelerationSpeed;
    public float accelerationReduce;
    public float breakSpeed;
    public float turnSpeed;
    public float maxSpeed;
    public float maxReverse;

    public bool active;
    
    void Awake ()
    {
        carRigid = GetComponent<Rigidbody>();
        carTransfrom = GetComponent<Transform>();
        rend = GetComponent<Renderer>();
        active = false;

        gear = "N";
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

                if (moveSpeed < maxSpeed && moveSpeed >= -6 && moveSpeed < 5)
                {
                    moveSpeed = moveSpeed + accelerationSpeed;
                    gear = "1";
                }

                if (moveSpeed < maxSpeed && moveSpeed >= 5 && moveSpeed < 10)
                {
                    moveSpeed = moveSpeed + accelerationSpeed - 0.35f;
                    gear = "2";
                }

                if (moveSpeed < maxSpeed && moveSpeed >= 10 && moveSpeed < 15)
                {
                    moveSpeed = moveSpeed + accelerationSpeed - 0.45f;
                    gear = "3";
                }

                if (moveSpeed < maxSpeed && moveSpeed >= 15 && moveSpeed < 20)
                {
                    moveSpeed = moveSpeed + accelerationSpeed - 0.50f;
                    gear = "4";
                }

                if (moveSpeed < maxSpeed && moveSpeed >= 20 && moveSpeed < 25)
                {
                    moveSpeed = moveSpeed + accelerationSpeed - 0.55f;
                    gear = "5";
                }

                if (moveSpeed < maxSpeed && moveSpeed >= 25 && moveSpeed < 30)
                {
                    moveSpeed = moveSpeed + accelerationSpeed - 0.58f;
                    gear = "6";
                }



            }
            else if (Input.GetKey(KeyCode.S))
            {
                if (moveSpeed > maxReverse)
                {
                    moveSpeed = moveSpeed - breakSpeed;
                    gear = "R";
                }
            } else
            {
                if (moveSpeed > 0f)
                {
                    moveSpeed = moveSpeed - accelerationReduce;


                    if (moveSpeed < maxSpeed && moveSpeed >= -6 && moveSpeed < 5)
                    {
                        gear = "1";
                    }

                    if (moveSpeed < maxSpeed && moveSpeed >= 5 && moveSpeed < 10)
                    {
                        gear = "2";
                    }

                    if (moveSpeed < maxSpeed && moveSpeed >= 10 && moveSpeed < 15)
                    {
                        gear = "3";
                    }

                    if (moveSpeed < maxSpeed && moveSpeed >= 15 && moveSpeed < 20)
                    {
                        gear = "4";
                    }

                    if (moveSpeed < maxSpeed && moveSpeed >= 20 && moveSpeed < 25)
                    {
                        gear = "5";
                    }

                    if (moveSpeed < maxSpeed && moveSpeed >= 25 && moveSpeed < 30)
                    {
                        gear = "6";
                    }

                }

            }

          

            if (Input.GetKey(KeyCode.A))
            {
                carTransfrom.Rotate(0, -1f, 0);

                if (moveSpeed > maxReverse)
                {
                    moveSpeed = moveSpeed - turnSpeed;
                }
                
            }

            if (Input.GetKey(KeyCode.D))
            {
                carTransfrom.Rotate(0, 1f, 0);

                if (moveSpeed > maxReverse)
                {
                    moveSpeed = moveSpeed - turnSpeed;
                }
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                FunkyTime();
            }

            if (Input.GetKeyDown(KeyCode.E))
            {
                FunkyTimeStop();
            }
        }


    }
	
	// Update is called once per frame
	void Update () {
	
        

    }

    public void FunkyTime()
    {
        cam.GetComponent<ShaderCam>().funky = true;
        camBack.GetComponent<ShaderCam>().funky = true;

        rend.material.shader = vertexAni;
        rend.material.SetFloat("_AnimSpeed", 100f);
        rend.material.SetFloat("_AnimPowerX", 0.1f);
        rend.material.SetFloat("_AnimPowerY", 0f);
        rend.material.SetFloat("_AnimPowerZ", 0.1f);
        rend.material.SetFloat("_AnimOffsetX", 10f);
        rend.material.SetFloat("_AnimOffsetY", 10f);
        rend.material.SetFloat("_AnimOffsetZ", 10f);
    }

    public void FunkyTimeStop()
    {
        cam.GetComponent<ShaderCam>().funky = false;
        camBack.GetComponent<ShaderCam>().funky = false;

        rend.material.shader = standardShader;

    }

}
