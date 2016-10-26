using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LevelManager : MonoBehaviour {

    // Spawn
    GameObject spawn;
    GameObject player;
    GameObject[] AI;
    GameObject track;

    int AIcarNumber;

    // UI
    public GameObject countdown;
    public GameObject position;
    public GameObject gameTimer;
    public GameObject health;
    public GameObject speed;
    public GameObject gear;

    public GameObject death;
    

    float showSpeed;

    bool startTimer;
    float startTime;
    float reduceTime;
    float timer;
    string textTimer;

    public bool deadPlayer;

    GameObject goal;
    
    void Awake ()
    {
        spawn = GameObject.FindGameObjectWithTag("Spawn");
        track = GameObject.FindGameObjectWithTag("Track");
        goal = GameObject.FindGameObjectWithTag("Goal");
        startTimer = false;
        deadPlayer = false;
        AIcarNumber = 0;
        
    }

	// Use this for initialization
	void Start () {
        StartCoroutine("StartRace");
	}
	
	// Update is called once per frame
	void Update () {

        if(player != null)
        {
            if (startTimer)
            {
                CalculateTime();
            }

            position.GetComponent<Text>().text = player.GetComponent<PlayerControl>().position;
            health.GetComponent<Text>().text = player.GetComponent<PlayerControl>().health.ToString();
            showSpeed = player.GetComponent<PlayerControl>().moveSpeed;
            showSpeed = (int)showSpeed;
            speed.GetComponent<Text>().text = showSpeed.ToString();
            gear.GetComponent<Text>().text = player.GetComponent<PlayerControl>().gear;
        }
        
        if(deadPlayer)
        {
            death.SetActive(true);
        }

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
        reduceTime = Time.time;
        SetTimer();
        player.GetComponent<PlayerControl>().active = true;
        foreach(GameObject car in AI)
        {
            ++AIcarNumber;
            car.GetComponent<AI>().Passive();
            car.GetComponent<AI>().AINumber = AIcarNumber;
        }
        yield return new WaitForSeconds(1f);
        countdown.SetActive(false);


        yield return null;
    }

    void SetTimer()
    {
        if(startTimer)
        {
            startTimer = false;
        } else
        {
            startTimer = true;
        }
    }

    void CalculateTime()
    {

        timer = startTime + Time.time - reduceTime;

        float minuntes = Mathf.Floor(timer / 60);
        float seconds = Mathf.Floor(timer - minuntes * 60);
        float milliseconds = timer - Mathf.Floor(timer);
        milliseconds = Mathf.Floor(milliseconds * 1000);

        string textMinutes = "00" + minuntes.ToString();
        textMinutes = textMinutes.Substring(textMinutes.Length - 2);

        string textSeconds = "00" + seconds.ToString();
        textSeconds = textSeconds.Substring(textSeconds.Length - 2);

        string textMilliseconds = "000" + milliseconds.ToString();
        textMilliseconds = textMilliseconds.Substring(textMilliseconds.Length - 3);

        if(!goal.GetComponent<Goal>().gameDone)
        {
            gameTimer.GetComponent<Text>().text = textMinutes + ":" + textSeconds + ":" + textMilliseconds;
        }
        

    }

    
}
