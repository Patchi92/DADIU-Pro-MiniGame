using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour {

    public GameObject player;
    public GameObject carAI;

    public int cars;

    public Transform[] startPos;

	// Use this for initialization
	void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void SpawnCars ()
    {
        Instantiate(player, startPos[0].position, Quaternion.identity);
        cars = cars - 1;

        for (int i = 0; i < cars; i++)
        {
            Instantiate(carAI, startPos[i + 1].position, Quaternion.identity);
        }
    }
}
