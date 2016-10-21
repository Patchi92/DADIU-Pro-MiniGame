using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LevelManager : MonoBehaviour {

    GameObject spawn;
    GameObject player;
    GameObject[] AI;

    public GameObject countdown;


    
    void Awake ()
    {
        spawn = GameObject.FindGameObjectWithTag("Spawn");
        
    }

	// Use this for initialization
	void Start () {
        StartCoroutine("StartRace");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    IEnumerator StartRace()
    {
        spawn.GetComponent<Spawn>().SpawnCars();
        player = GameObject.FindGameObjectWithTag("Player");
        AI = GameObject.FindGameObjectsWithTag("AI");
        countdown.SetActive(true);
        countdown.GetComponent<Text>().text = "GET READY!";
        yield return new WaitForSeconds(3f);
        countdown.GetComponent<Text>().text = "3";
        yield return new WaitForSeconds(1f);
        countdown.GetComponent<Text>().text = "2";
        yield return new WaitForSeconds(1f);
        countdown.GetComponent<Text>().text = "1";
        yield return new WaitForSeconds(1f);
        countdown.GetComponent<Text>().text = "GO!";
        player.GetComponent<PlayerControl>().active = true;
        foreach(GameObject car in AI)
        {
            car.GetComponent<AI>().Passive();
        }
        yield return new WaitForSeconds(1f);
        countdown.SetActive(false);


        yield return null;
    }
}
