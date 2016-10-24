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

    bool player;
    bool AIone;
    bool AItwo;
    bool AIthree;
    bool AIfour;
    bool AIfive;
    bool AIsix;
    bool AIseven;



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


        player = true;
        AIone = true;
        AItwo = true;
        AIthree = true;
        AIfour = true;
        AIfive = true;
        AIsix = true;
        AIseven = true;
    }

    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player")
        {
            if(player)
            {
                if (first)
                {
                    other.GetComponent<PlayerControl>().position = "1st";
                    first = false;

                }
                else if (second)
                {
                    other.GetComponent<PlayerControl>().position = "2nd";
                    second = false;

                }
                else if (third)
                {
                    other.GetComponent<PlayerControl>().position = "3rd";
                    third = false;
                }
                else if (fourth)
                {
                    other.GetComponent<PlayerControl>().position = "4th";
                    fourth = false;
                }
                else if (fifth)
                {
                    other.GetComponent<PlayerControl>().position = "5th";
                    fifth = false;
                }
                else if (sixth)
                {
                    other.GetComponent<PlayerControl>().position = "6th";
                    sixth = false;
                }
                else if (seventh)
                {
                    other.GetComponent<PlayerControl>().position = "7th";
                    seventh = false;
                }
                else if (eighth)
                {
                    other.GetComponent<PlayerControl>().position = "8th";
                    eighth = false;
                }

                player = false;
            }
        }


        if (other.tag == "AI")
        {
            if(other.GetComponent<AI>().AINumber == 1)
            {
                if (AIone)
                {
                    if (first)
                    {
                        other.GetComponent<AI>().position = "1st";
                        first = false;

                    }
                    else if (second)
                    {
                        other.GetComponent<AI>().position = "2nd";
                        second = false;

                    }
                    else if (third)
                    {
                        other.GetComponent<AI>().position = "3rd";
                        third = false;
                    }
                    else if (fourth)
                    {
                        other.GetComponent<AI>().position = "4th";
                        fourth = false;
                    }
                    else if (fifth)
                    {
                        other.GetComponent<AI>().position = "5th";
                        fifth = false;
                    }
                    else if (sixth)
                    {
                        other.GetComponent<AI>().position = "6th";
                        sixth = false;
                    }
                    else if (seventh)
                    {
                        other.GetComponent<AI>().position = "7th";
                        seventh = false;
                    }
                    else if (eighth)
                    {
                        other.GetComponent<AI>().position = "8th";
                        eighth = false;
                    }

                    AIone = false;
                }
            }

            if (other.GetComponent<AI>().AINumber == 2)
            {
                if (AItwo)
                {
                    if (first)
                    {
                        other.GetComponent<AI>().position = "1st";
                        first = false;

                    }
                    else if (second)
                    {
                        other.GetComponent<AI>().position = "2nd";
                        second = false;

                    }
                    else if (third)
                    {
                        other.GetComponent<AI>().position = "3rd";
                        third = false;
                    }
                    else if (fourth)
                    {
                        other.GetComponent<AI>().position = "4th";
                        fourth = false;
                    }
                    else if (fifth)
                    {
                        other.GetComponent<AI>().position = "5th";
                        fifth = false;
                    }
                    else if (sixth)
                    {
                        other.GetComponent<AI>().position = "6th";
                        sixth = false;
                    }
                    else if (seventh)
                    {
                        other.GetComponent<AI>().position = "7th";
                        seventh = false;
                    }
                    else if (eighth)
                    {
                        other.GetComponent<AI>().position = "8th";
                        eighth = false;
                    }

                    AItwo = false;
                }
            }

            if (other.GetComponent<AI>().AINumber == 3)
            {
                if (AIthree)
                {
                    if (first)
                    {
                        other.GetComponent<AI>().position = "1st";
                        first = false;

                    }
                    else if (second)
                    {
                        other.GetComponent<AI>().position = "2nd";
                        second = false;

                    }
                    else if (third)
                    {
                        other.GetComponent<AI>().position = "3rd";
                        third = false;
                    }
                    else if (fourth)
                    {
                        other.GetComponent<AI>().position = "4th";
                        fourth = false;
                    }
                    else if (fifth)
                    {
                        other.GetComponent<AI>().position = "5th";
                        fifth = false;
                    }
                    else if (sixth)
                    {
                        other.GetComponent<AI>().position = "6th";
                        sixth = false;
                    }
                    else if (seventh)
                    {
                        other.GetComponent<AI>().position = "7th";
                        seventh = false;
                    }
                    else if (eighth)
                    {
                        other.GetComponent<AI>().position = "8th";
                        eighth = false;
                    }

                    AIthree = false;
                }
            }

            if (other.GetComponent<AI>().AINumber == 4)
            {
                if (AIfour)
                {
                    if (first)
                    {
                        other.GetComponent<AI>().position = "1st";
                        first = false;

                    }
                    else if (second)
                    {
                        other.GetComponent<AI>().position = "2nd";
                        second = false;

                    }
                    else if (third)
                    {
                        other.GetComponent<AI>().position = "3rd";
                        third = false;
                    }
                    else if (fourth)
                    {
                        other.GetComponent<AI>().position = "4th";
                        fourth = false;
                    }
                    else if (fifth)
                    {
                        other.GetComponent<AI>().position = "5th";
                        fifth = false;
                    }
                    else if (sixth)
                    {
                        other.GetComponent<AI>().position = "6th";
                        sixth = false;
                    }
                    else if (seventh)
                    {
                        other.GetComponent<AI>().position = "7th";
                        seventh = false;
                    }
                    else if (eighth)
                    {
                        other.GetComponent<AI>().position = "8th";
                        eighth = false;
                    }

                    AIfour = false;
                }
            }

            if (other.GetComponent<AI>().AINumber == 5)
            {
                if (AIfive)
                {
                    if (first)
                    {
                        other.GetComponent<AI>().position = "1st";
                        first = false;

                    }
                    else if (second)
                    {
                        other.GetComponent<AI>().position = "2nd";
                        second = false;

                    }
                    else if (third)
                    {
                        other.GetComponent<AI>().position = "3rd";
                        third = false;
                    }
                    else if (fourth)
                    {
                        other.GetComponent<AI>().position = "4th";
                        fourth = false;
                    }
                    else if (fifth)
                    {
                        other.GetComponent<AI>().position = "5th";
                        fifth = false;
                    }
                    else if (sixth)
                    {
                        other.GetComponent<AI>().position = "6th";
                        sixth = false;
                    }
                    else if (seventh)
                    {
                        other.GetComponent<AI>().position = "7th";
                        seventh = false;
                    }
                    else if (eighth)
                    {
                        other.GetComponent<AI>().position = "8th";
                        eighth = false;
                    }

                    AIfive = false;
                }
            }

            if (other.GetComponent<AI>().AINumber == 6)
            {
                if (AIsix)
                {
                    if (first)
                    {
                        other.GetComponent<AI>().position = "1st";
                        first = false;

                    }
                    else if (second)
                    {
                        other.GetComponent<AI>().position = "2nd";
                        second = false;

                    }
                    else if (third)
                    {
                        other.GetComponent<AI>().position = "3rd";
                        third = false;
                    }
                    else if (fourth)
                    {
                        other.GetComponent<AI>().position = "4th";
                        fourth = false;
                    }
                    else if (fifth)
                    {
                        other.GetComponent<AI>().position = "5th";
                        fifth = false;
                    }
                    else if (sixth)
                    {
                        other.GetComponent<AI>().position = "6th";
                        sixth = false;
                    }
                    else if (seventh)
                    {
                        other.GetComponent<AI>().position = "7th";
                        seventh = false;
                    }
                    else if (eighth)
                    {
                        other.GetComponent<AI>().position = "8th";
                        eighth = false;
                    }

                    AIsix = false;
                }
            }

            if (other.GetComponent<AI>().AINumber == 7)
            {
                if (AIseven)
                {
                    if (first)
                    {
                        other.GetComponent<AI>().position = "1st";
                        first = false;

                    }
                    else if (second)
                    {
                        other.GetComponent<AI>().position = "2nd";
                        second = false;

                    }
                    else if (third)
                    {
                        other.GetComponent<AI>().position = "3rd";
                        third = false;
                    }
                    else if (fourth)
                    {
                        other.GetComponent<AI>().position = "4th";
                        fourth = false;
                    }
                    else if (fifth)
                    {
                        other.GetComponent<AI>().position = "5th";
                        fifth = false;
                    }
                    else if (sixth)
                    {
                        other.GetComponent<AI>().position = "6th";
                        sixth = false;
                    }
                    else if (seventh)
                    {
                        other.GetComponent<AI>().position = "7th";
                        seventh = false;
                    }
                    else if (eighth)
                    {
                        other.GetComponent<AI>().position = "8th";
                        eighth = false;
                    }

                    AIseven = false;
                }
            }

        }
    }
}
