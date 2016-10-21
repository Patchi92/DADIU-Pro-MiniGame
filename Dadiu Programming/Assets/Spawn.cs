using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour {

    public GameObject player;
    public GameObject carAI;

    public int cars;

    public Transform[] startPos;
    public int players;

	// Use this for initialization
	void Start () {
        SpawnCars();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void SpawnCars ()
    {
        Instantiate(player, startPos[0].position, Quaternion.identity);
        players = players - 1;

        for (int i = 0; i < players; i++)
        {
            Instantiate(carAI, startPos[i + 1].position, Quaternion.identity);
        }
    }
}
