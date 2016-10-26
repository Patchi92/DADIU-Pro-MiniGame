using System;
using System.Collections.Generic;
using UnityEngine;
using System.Text;

public abstract class PickupAbstract: MonoBehaviour
{

    protected PlayerControl playerControl;
    //abstract Sprite GetSprite();
    public float boost = 0.5f;
    public int healthRepair = 10;

    public Sprite sprite;


    //public abstract Sprite GetSprite();
    public Sprite GetSprite()
    {
        return sprite;
    }

    public void Start()
    {
        playerControl = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerControl>();
    }


}
