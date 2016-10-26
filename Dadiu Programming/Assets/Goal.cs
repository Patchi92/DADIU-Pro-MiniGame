using UnityEngine;
using System.Collections;

public class Goal : MonoBehaviour
{

    public int carInGoal;
    public int carDestoryed;
    public bool gameDone;

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


    void Awake()
    {
        carInGoal = 0;
        carDestoryed = 0;
        gameDone = false;

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

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.Space))
        {
            if (gameDone == true)
            {
                Application.LoadLevel(1);
            }
        }

        if (carInGoal == 8 && gameDone == true)
        {
            Application.LoadLevel(0);
        }

        if (carDestoryed == 7)
        {
            Application.LoadLevel(0);
        }
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (player)
            {
                other.GetComponent<PlayerControl>().active = false;
                gameDone = true;
                
                if (first)
                {
                    other.GetComponent<PlayerControl>().position = "1st";
                    ++carInGoal;
                    first = false;

                }
                else if (second)
                {
                    other.GetComponent<PlayerControl>().position = "2nd";
                    ++carInGoal;
                    second = false;
                }
                else if (third)
                {
                    other.GetComponent<PlayerControl>().position = "3rd";
                    ++carInGoal;
                    third = false;
                }
                else if (fourth)
                {
                    other.GetComponent<PlayerControl>().position = "4th";
                    ++carInGoal;
                    fourth = false;
                }
                else if (fifth)
                {
                    other.GetComponent<PlayerControl>().position = "5th";
                    ++carInGoal;
                    fifth = false;
                }
                else if (sixth)
                {
                    other.GetComponent<PlayerControl>().position = "6th";
                    ++carInGoal;
                    sixth = false;
                }
                else if (seventh)
                {
                    other.GetComponent<PlayerControl>().position = "7th";
                    ++carInGoal;
                    seventh = false;
                }
                else if (eighth)
                {
                    other.GetComponent<PlayerControl>().position = "8th";
                    ++carInGoal;
                    eighth = false;
                }

                player = false;
            }
        }


        if (other.tag == "AI")
        {
            other.GetComponent<AI>().Standby();
            if (other.GetComponent<AI>().AINumber == 1)
            {
                if (AIone)
                {
                    if (first)
                    {
                        other.GetComponent<AI>().position = "1st";
                        ++carInGoal;
                        first = false;

                    }
                    else if (second)
                    {
                        other.GetComponent<AI>().position = "2nd";
                        ++carInGoal;
                        second = false;

                    }
                    else if (third)
                    {
                        other.GetComponent<AI>().position = "3rd";
                        ++carInGoal;
                        third = false;
                    }
                    else if (fourth)
                    {
                        other.GetComponent<AI>().position = "4th";
                        ++carInGoal;
                        fourth = false;
                    }
                    else if (fifth)
                    {
                        other.GetComponent<AI>().position = "5th";
                        ++carInGoal;
                        fifth = false;
                    }
                    else if (sixth)
                    {
                        other.GetComponent<AI>().position = "6th";
                        ++carInGoal;
                        sixth = false;
                    }
                    else if (seventh)
                    {
                        other.GetComponent<AI>().position = "7th";
                        ++carInGoal;
                        seventh = false;
                    }
                    else if (eighth)
                    {
                        other.GetComponent<AI>().position = "8th";
                        ++carInGoal;
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
                        ++carInGoal;
                        first = false;

                    }
                    else if (second)
                    {
                        other.GetComponent<AI>().position = "2nd";
                        ++carInGoal;
                        second = false;

                    }
                    else if (third)
                    {
                        other.GetComponent<AI>().position = "3rd";
                        ++carInGoal;
                        third = false;
                    }
                    else if (fourth)
                    {
                        other.GetComponent<AI>().position = "4th";
                        ++carInGoal;
                        fourth = false;
                    }
                    else if (fifth)
                    {
                        other.GetComponent<AI>().position = "5th";
                        ++carInGoal;
                        fifth = false;
                    }
                    else if (sixth)
                    {
                        other.GetComponent<AI>().position = "6th";
                        ++carInGoal;
                        sixth = false;
                    }
                    else if (seventh)
                    {
                        other.GetComponent<AI>().position = "7th";
                        ++carInGoal;
                        seventh = false;
                    }
                    else if (eighth)
                    {
                        other.GetComponent<AI>().position = "8th";
                        ++carInGoal;
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
                        ++carInGoal;
                        first = false;

                    }
                    else if (second)
                    {
                        other.GetComponent<AI>().position = "2nd";
                        ++carInGoal;
                        second = false;

                    }
                    else if (third)
                    {
                        other.GetComponent<AI>().position = "3rd";
                        ++carInGoal;
                        third = false;
                    }
                    else if (fourth)
                    {
                        other.GetComponent<AI>().position = "4th";
                        ++carInGoal;
                        fourth = false;
                    }
                    else if (fifth)
                    {
                        other.GetComponent<AI>().position = "5th";
                        ++carInGoal;
                        fifth = false;
                    }
                    else if (sixth)
                    {
                        other.GetComponent<AI>().position = "6th";
                        ++carInGoal;
                        sixth = false;
                    }
                    else if (seventh)
                    {
                        other.GetComponent<AI>().position = "7th";
                        ++carInGoal;
                        seventh = false;
                    }
                    else if (eighth)
                    {
                        other.GetComponent<AI>().position = "8th";
                        ++carInGoal;
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
                        ++carInGoal;
                        first = false;

                    }
                    else if (second)
                    {
                        other.GetComponent<AI>().position = "2nd";
                        ++carInGoal;
                        second = false;

                    }
                    else if (third)
                    {
                        other.GetComponent<AI>().position = "3rd";
                        ++carInGoal;
                        third = false;
                    }
                    else if (fourth)
                    {
                        other.GetComponent<AI>().position = "4th";
                        ++carInGoal;
                        fourth = false;
                    }
                    else if (fifth)
                    {
                        other.GetComponent<AI>().position = "5th";
                        ++carInGoal;
                        fifth = false;
                    }
                    else if (sixth)
                    {
                        other.GetComponent<AI>().position = "6th";
                        ++carInGoal;
                        sixth = false;
                    }
                    else if (seventh)
                    {
                        other.GetComponent<AI>().position = "7th";
                        ++carInGoal;
                        seventh = false;
                    }
                    else if (eighth)
                    {
                        other.GetComponent<AI>().position = "8th";
                        ++carInGoal;
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
                        ++carInGoal;
                        first = false;

                    }
                    else if (second)
                    {
                        other.GetComponent<AI>().position = "2nd";
                        ++carInGoal;
                        second = false;

                    }
                    else if (third)
                    {
                        other.GetComponent<AI>().position = "3rd";
                        ++carInGoal;
                        third = false;
                    }
                    else if (fourth)
                    {
                        other.GetComponent<AI>().position = "4th";
                        ++carInGoal;
                        fourth = false;
                    }
                    else if (fifth)
                    {
                        other.GetComponent<AI>().position = "5th";
                        ++carInGoal;
                        fifth = false;
                    }
                    else if (sixth)
                    {
                        other.GetComponent<AI>().position = "6th";
                        ++carInGoal;
                        sixth = false;
                    }
                    else if (seventh)
                    {
                        other.GetComponent<AI>().position = "7th";
                        ++carInGoal;
                        seventh = false;
                    }
                    else if (eighth)
                    {
                        other.GetComponent<AI>().position = "8th";
                        ++carInGoal;
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
                        ++carInGoal;
                        first = false;

                    }
                    else if (second)
                    {
                        other.GetComponent<AI>().position = "2nd";
                        ++carInGoal;
                        second = false;

                    }
                    else if (third)
                    {
                        other.GetComponent<AI>().position = "3rd";
                        ++carInGoal;
                        third = false;
                    }
                    else if (fourth)
                    {
                        other.GetComponent<AI>().position = "4th";
                        ++carInGoal;
                        fourth = false;
                    }
                    else if (fifth)
                    {
                        other.GetComponent<AI>().position = "5th";
                        ++carInGoal;
                        fifth = false;
                    }
                    else if (sixth)
                    {
                        other.GetComponent<AI>().position = "6th";
                        ++carInGoal;
                        sixth = false;
                    }
                    else if (seventh)
                    {
                        other.GetComponent<AI>().position = "7th";
                        ++carInGoal;
                        seventh = false;
                    }
                    else if (eighth)
                    {
                        other.GetComponent<AI>().position = "8th";
                        ++carInGoal;
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
                        ++carInGoal;
                        first = false;

                    }
                    else if (second)
                    {
                        other.GetComponent<AI>().position = "2nd";
                        ++carInGoal;
                        second = false;

                    }
                    else if (third)
                    {
                        other.GetComponent<AI>().position = "3rd";
                        ++carInGoal;
                        third = false;
                    }
                    else if (fourth)
                    {
                        other.GetComponent<AI>().position = "4th";
                        ++carInGoal;
                        fourth = false;
                    }
                    else if (fifth)
                    {
                        other.GetComponent<AI>().position = "5th";
                        ++carInGoal;
                        fifth = false;
                    }
                    else if (sixth)
                    {
                        other.GetComponent<AI>().position = "6th";
                        ++carInGoal;
                        sixth = false;
                    }
                    else if (seventh)
                    {
                        other.GetComponent<AI>().position = "7th";
                        ++carInGoal;
                        seventh = false;
                    }
                    else if (eighth)
                    {
                        other.GetComponent<AI>().position = "8th";
                        ++carInGoal;
                        eighth = false;
                    }

                    AIseven = false;
                }
            }

        }
    }
}
