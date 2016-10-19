using UnityEngine;


public struct Move
{
    public Vector3 start;
    public Vector3 end;

    public Move(Vector3 s, Vector3 e)
    {
        start = s;
        end = e;
    }
};

public enum Curbe
{
    FORWARD, LEFT,  BACK, RIGHT, FLEFT, FRIGHT, BLEFT, BRIGHT
};

