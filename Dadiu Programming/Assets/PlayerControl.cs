using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour
{


    Rigidbody carRigid;
    Transform carTransfrom;
    Renderer rend;

    GameObject goal;
    GameObject ui;

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

    public string position;

    public int health;
    public GameObject smoke;
    public GameObject deathEffect;
    bool death;

    void Awake()
    {
        carRigid = GetComponent<Rigidbody>();
        carTransfrom = GetComponent<Transform>();
        rend = GetComponent<Renderer>();
        active = false;
        death = true;
        health = 100;
        gear = "N";
        position = "8th";
        goal = GameObject.FindGameObjectWithTag("Goal");
        ui = GameObject.FindGameObjectWithTag("UI");
    }


    void Start()
    {

    }


    void FixedUpdate()
    {
        //carRigid.velocity += new Vector3(0f, -2f, 0f);

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
            }
            else
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

                if ((int)moveSpeed == 0)
                {
                    gear = "N";
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

            if (Input.GetKeyDown(KeyCode.R))
            {
                health -= 10;
            }
        }


    }

    // Update is called once per frame
    void Update()
    {

        if (health < 100 && health > 50)
        {
            smoke.SetActive(false);
        }

        if (health <= 50 && health > 40)
        {
            smoke.SetActive(true);
            smoke.GetComponent<ParticleSystem>().maxParticles = 1;
        }

        if (health <= 40 && health > 30)
        {
            smoke.GetComponent<ParticleSystem>().maxParticles = 2;
        }

        if (health <= 30 && health > 20)
        {
            smoke.GetComponent<ParticleSystem>().maxParticles = 4;
        }

        if (health <= 20 && health > 10)
        {
            smoke.GetComponent<ParticleSystem>().maxParticles = 6;
        }

        if (health <= 10 && health > 0)
        {
            smoke.GetComponent<ParticleSystem>().maxParticles = 10;
        }

        if (health <= 0)
        {
            if (death)
            {
                Instantiate(deathEffect, gameObject.transform.position, Quaternion.identity);
                goal.GetComponent<Goal>().gameDone = true;
                ++goal.GetComponent<Goal>().carDestoryed;
                ui.GetComponent<LevelManager>().deadPlayer = true;
                StartCoroutine("Death");
                death = false;
            }

        }

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

    IEnumerator Death()
    {
        yield return new WaitForSeconds(0.1f);
        Destroy(gameObject);
        yield return null;
    }


    
}
