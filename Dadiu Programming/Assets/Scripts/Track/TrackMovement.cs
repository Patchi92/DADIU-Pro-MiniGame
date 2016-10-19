using System;
using System.Collections.Generic;
using UnityEngine;



class TrackMovement
{

    
    public static float width = 4;
    public static float step = 4;

    public static Move MoveForward(Vector3 currentPos)
    {
        Move v;
        v.end = currentPos;
        v.start = currentPos;

        //FORWARD
        v.end.x += width;
        v.end.z += step;
        return v;
    }

    public static Move MoveBack(Vector3 currentPos)
    {
        Move v;
        v.end = currentPos;
        v.start = currentPos;

        //FORWARD
        v.start.x += width;
        v.start.z -= step;
        v.end.z = v.start.z - step;
        return v;
    }

    public static Move MoveRight(Vector3 currentPos)
    {
        Move v;
        v.end = currentPos;
        v.start = currentPos;

        //RIGHT
        v.start.z -= width;
        v.start.x += step;
        //v.end.x = v.start.x + 1;
        return v;
    }

    public static Move MoveLeft(Vector3 currentPos)
    {
        Move v;
        v.end = currentPos;
        v.start = currentPos;

        //Left
        //v.start.z -= width;
        v.end.x -= step;
        v.end.z += width;
        //v.end.z += width;
        return v;
    }


}