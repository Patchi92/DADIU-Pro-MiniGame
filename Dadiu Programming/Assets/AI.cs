using UnityEngine;
using System.Collections;

public class AI : MonoBehaviour {

    // Use this for initialization

    NavMeshAgent carAI;
    public GameObject goal;

    bool passive;
    bool hostile;

    GameObject player;

    public float ignoreDistance;

    float moveSpeed;
    float accelerationSpeed;
    float maxSpeed;

    void Awake ()
    {
        carAI = gameObject.GetComponent<NavMeshAgent>();
        maxSpeed = 20;
        accelerationSpeed = 0.3f;

        player = GameObject.FindGameObjectWithTag("Player");
        goal = GameObject.FindGameObjectWithTag("Goal");

        passive = true;
        hostile = false;
    }

    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


        if(passive)
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

            carAI.speed = moveSpeed;
            carAI.SetDestination(player.transform.position);
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

    

}
