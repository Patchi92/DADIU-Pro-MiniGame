using UnityEngine;
using System.Collections;

public class AI : MonoBehaviour {

    // Use this for initialization

    NavMeshAgent carAI;
    Rigidbody carRigid;

    public GameObject goal;

    bool passive;
    bool hostile;

    GameObject player;

    public float ignoreDistance;

    float moveSpeed;
    float accelerationSpeed;
    public float maxSpeed;

    Renderer rend;
    public Shader vertexAni;
    public Shader standardShader;

    void Awake ()
    {
        carAI = gameObject.GetComponent<NavMeshAgent>();
        carRigid = gameObject.GetComponent<Rigidbody>();
        rend = GetComponent<Renderer>();

        //maxSpeed = 20;
        accelerationSpeed = 0.8f;

        player = GameObject.FindGameObjectWithTag("Player");
        goal = GameObject.FindGameObjectWithTag("Goal");

        
        passive = false;
        hostile = false;
    }

    void Start () {

        rend.material.color = new Color(Random.value, Random.value, Random.value, 1.0f);
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        carRigid.velocity += new Vector3(0f, -2f, 0f);

        if (passive)
        {
            if (moveSpeed < maxSpeed && moveSpeed >= -6 && moveSpeed < 5)
            {
                moveSpeed = moveSpeed + accelerationSpeed;
            }

            if (moveSpeed < maxSpeed && moveSpeed >= 5 && moveSpeed < 10)
            {
                moveSpeed = moveSpeed + accelerationSpeed - 0.35f;
            }

            if (moveSpeed < maxSpeed && moveSpeed >= 10 && moveSpeed < 15)
            {
                moveSpeed = moveSpeed + accelerationSpeed - 0.45f;
            }

            if (moveSpeed < maxSpeed && moveSpeed >= 15 && moveSpeed < 20)
            {
                moveSpeed = moveSpeed + accelerationSpeed - 0.50f;
            }

            if (moveSpeed < maxSpeed && moveSpeed >= 20 && moveSpeed < 25)
            {
                moveSpeed = moveSpeed + accelerationSpeed - 0.55f;
            }

            if (moveSpeed < maxSpeed && moveSpeed >= 25 && moveSpeed < 30)
            {
                moveSpeed = moveSpeed + accelerationSpeed - 0.58f;
            }

            carAI.speed = moveSpeed;
            carAI.SetDestination(goal.transform.position);
        }

        if(hostile)
        {
            if (Vector3.Distance(gameObject.transform.position, player.transform.position) > ignoreDistance)
            {
                passive = true;
                hostile = false;
            }

            if (moveSpeed < maxSpeed && moveSpeed >= -6 && moveSpeed < 5)
            {
                moveSpeed = moveSpeed + accelerationSpeed;
            }

            if (moveSpeed < maxSpeed && moveSpeed >= 5 && moveSpeed < 10)
            {
                moveSpeed = moveSpeed + accelerationSpeed - 0.35f;
            }

            if (moveSpeed < maxSpeed && moveSpeed >= 10 && moveSpeed < 15)
            {
                moveSpeed = moveSpeed + accelerationSpeed - 0.45f;
            }

            if (moveSpeed < maxSpeed && moveSpeed >= 15 && moveSpeed < 20)
            {
                moveSpeed = moveSpeed + accelerationSpeed - 0.50f;
            }

            if (moveSpeed < maxSpeed && moveSpeed >= 20 && moveSpeed < 25)
            {
                moveSpeed = moveSpeed + accelerationSpeed - 0.55f;
            }

            if (moveSpeed < maxSpeed && moveSpeed >= 25 && moveSpeed < 30)
            {
                moveSpeed = moveSpeed + accelerationSpeed - 0.58f;
            }

            carAI.speed = moveSpeed;
            carAI.SetDestination(player.transform.position);
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


    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            //hostile = true;
            //passive = false;
        }
        
    }

    
    public void Passive()
    {
        hostile = false;
        passive = true;
    }

    public void Hostile()
    {
        passive = false;
        hostile = true;
    }

    public void FunkyTime()
    {
        rend.material.shader = vertexAni;
        rend.material.SetFloat("_AnimSpeed", 100f);
        rend.material.SetFloat("_AnimPowerX", 0.2f);
        rend.material.SetFloat("_AnimPowerY", 0f);
        rend.material.SetFloat("_AnimPowerZ", 0.2f);
        rend.material.SetFloat("_AnimOffsetX", 10f);
        rend.material.SetFloat("_AnimOffsetY", 10f);
        rend.material.SetFloat("_AnimOffsetZ", 10f);
    }

    public void FunkyTimeStop()
    {
        rend.material.shader = standardShader;

    }
}
