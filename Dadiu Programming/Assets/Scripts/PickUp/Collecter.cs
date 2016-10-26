using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class Collecter : MonoBehaviour {

    Queue<GameObject> collectibleQueue = new Queue<GameObject>();
    List<Image> sprites = new List<Image>();
    Image powerUp1;
    Image powerUp2;
    Image powerUp3;
	PlayerControl playerControl;

    private int currentCounter = 0;

    //adding stuff
    GameObject[] AI;
    GameObject[] roads;

    bool reset;

    void Start()
    {
        powerUp1 = GameObject.Find("PowerUp 1").GetComponent<Image>();
        powerUp2 = GameObject.Find("PowerUp 2").GetComponent<Image>();
        powerUp3 = GameObject.Find("PowerUp 3").GetComponent<Image>();
        sprites.Add(powerUp1);
        sprites.Add(powerUp2);
        sprites.Add(powerUp3);

		playerControl = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerControl>();
        AI = GameObject.FindGameObjectsWithTag("AI");
        roads = GameObject.FindGameObjectsWithTag("Road");

    }
    public void Update()
    {
        //press space activate power up
        if (collectibleQueue.Count > 0 && Input.GetKeyDown("space"))
        {
            GameObject powerUp = collectibleQueue.Dequeue();

            powerUp.GetComponent<PickUpAction>().activation();

            resetUIPowerUp();
            Debug.Log("Pick up used");

        }

		if (collectibleQueue.Count == 0) {

            if(reset)
            {
                playerControl.FunkyTimeStop();

                foreach (GameObject car in AI)
                {
                    car.GetComponent<AI>().FunkyTimeStop();
                }

                foreach (GameObject road in roads)
                {
                    road.GetComponent<Road>().FunkyTimeStop();
                }

                reset = false;
            }
			
        }


    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Pick Up"))
        {
            col.gameObject.SetActive(false);

            collectibleQueue.Enqueue(col.gameObject);

            resetUIPowerUp();
            //Debug.Log(powerUp1.name);

            reset = true;

            playerControl.FunkyTime ();

            
            foreach (GameObject car in AI)
            {
                car.GetComponent<AI>().FunkyTime();
            }

            foreach (GameObject road in roads)
            {
                road.GetComponent<Road>().FunkyTime();
            }
        }
    }

    private void resetUIPowerUp()
    {
        int i = 0;
        foreach (GameObject sp in collectibleQueue)
        {
            Debug.Log(sp.GetComponent<PickupAbstract>().GetSprite());
            if (i > 2) return;
            sprites[i].sprite = sp.GetComponent<PickupAbstract>().GetSprite();
            i++;
        }

        //reset
        for (int j = 2; j >= i; j--)
        {
            sprites[i].sprite = null;
        }
    }


}
