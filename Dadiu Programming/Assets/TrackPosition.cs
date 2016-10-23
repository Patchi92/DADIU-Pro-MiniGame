using UnityEngine;
using System.Collections;

public class TrackPosition : MonoBehaviour {

    bool first;
    bool second;
    bool third;
    bool fourth;
    bool fifth;
    bool sixth;
    bool seventh;
    bool eighth;
    bool ninth;
    bool tenth;


    void Awake ()
    {
        first = true;
        second = true;
        third = true;
        fourth = true;
        fifth = true;
        sixth = true;
        seventh = true;
        eighth = true;
        ninth = true;
        tenth = true;
    }

    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player" || other.tag == "AI")
        {
            if (first)
            {
                if (other.tag == "Player")
                {
                    other.GetComponent<PlayerControl>().position = "1st";
                }

                if (other.tag == "AI")
                {
                    other.GetComponent<AI>().position = "1st";
                }
                first = false;

            }
            else if (second)
            {
                if (other.tag == "Player")
                {
                    other.GetComponent<PlayerControl>().position = "2nd";
                }

                if (other.tag == "AI")
                {
                    other.GetComponent<AI>().position = "2nd";
                }
                second = false;

            }
            else if (third)
            {
                if (other.tag == "Player")
                {
                    other.GetComponent<PlayerControl>().position = "3rd";
                }

                if (other.tag == "AI")
                {
                    other.GetComponent<AI>().position = "3rd";
                }
                third = false;
            }
            else if (fourth)
            {
                if (other.tag == "Player")
                {
                    other.GetComponent<PlayerControl>().position = "4th";
                }

                if (other.tag == "AI")
                {
                    other.GetComponent<AI>().position = "4th";
                }
                fourth = false;
            }
            else if (fifth)
            {
                if (other.tag == "Player")
                {
                    other.GetComponent<PlayerControl>().position = "5th";
                }

                if (other.tag == "AI")
                {
                    other.GetComponent<AI>().position = "5th";
                }
                fifth = false;
            }
            else if (sixth)
            {
                if (other.tag == "Player")
                {
                    other.GetComponent<PlayerControl>().position = "6th";
                }

                if (other.tag == "AI")
                {
                    other.GetComponent<AI>().position = "6th";
                }
                sixth = false;
            }
            else if (seventh)
            {
                if (other.tag == "Player")
                {
                    other.GetComponent<PlayerControl>().position = "7th";
                }

                if (other.tag == "AI")
                {
                    other.GetComponent<AI>().position = "7th";
                }
                seventh = false;
            }
            else if (eighth)
            {
                if (other.tag == "Player")
                {
                    other.GetComponent<PlayerControl>().position = "8th";
                }

                if (other.tag == "AI")
                {
                    other.GetComponent<AI>().position = "8th";
                }
                eighth = false;
            }


        }
    }
}
