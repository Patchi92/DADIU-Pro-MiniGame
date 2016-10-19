using System.Collections.Generic;
using UnityEngine;



class TrackQueue
{

    public int trackLength = 100;
    public int trackDificulty = 1;
    public int currentTrackLength = 0;

    private Queue<Curbe> turnQueue;

    private int curveDivisor = 0;

    public TrackQueue()
    {

        trackDificulty += 3;
        this.turnQueue = new Queue<Curbe>();
        this.curveDivisor = (trackLength / trackDificulty);



        //generateCurves();

        generatePolygon();

 
        
    }

    private void generateCurves()
    {
        //hold a list of generated curbes
        List<Curbe> tempCurbes = new List<Curbe>();

        //start with forward
        turnQueue.Enqueue(Curbe.FORWARD);

        Curbe randCurbe;
        int difficulty = 0;
        while (difficulty++ < trackDificulty)
        {
            //gets random curve also checks if curve not valid e.g. forward - back
            randCurbe = getRandomCurve(turnQueue.Peek());

            tempCurbes.Add(randCurbe);

            Debug.Log(randCurbe);
        }

        


        
    }
    
    private Curbe getRandomCurve(Curbe peek)
    {

        //generate curbe
        float randomGeneratedCurve = Random.Range(0, 8);

        Curbe genCurve = (Curbe) randomGeneratedCurve;

        while(!handlePeek(genCurve, peek))
        {
            randomGeneratedCurve = Random.Range(0, 8);

            genCurve = (Curbe)randomGeneratedCurve;
        }

        return genCurve;
    }

    private bool handlePeek(Curbe gen, Curbe peek)
    {
        //handle redundant curves
        switch(gen)
        {
            case Curbe.FORWARD:
                if (peek == Curbe.BACK) return false;
                return true;
            case Curbe.BACK:
                if (peek == Curbe.FORWARD) return false;
                return true;
            case Curbe.LEFT:
                if (peek == Curbe.RIGHT) return false;
                return true;
            case Curbe.RIGHT:
                if (peek == Curbe.LEFT) return false;
                return true;
            case Curbe.FLEFT:
                if (peek == Curbe.BRIGHT) return false;
                return true;
            case Curbe.FRIGHT:
                if (peek == Curbe.BLEFT) return false;
                return true;
            case Curbe.BLEFT:
                if (peek == Curbe.FRIGHT) return false;
                return true;
            case Curbe.BRIGHT:
                if (peek == Curbe.FLEFT) return false;
                return true;
        }
        return true;
    }



    private void generatePolygon()
    {
        Curbe currentMove = Curbe.FORWARD;

        //start


        this.turnQueue.Enqueue(currentMove);
        for (int i = 1; i <= trackLength; i++)
        {
            if (i % curveDivisor == 0) currentMove++;

            this.turnQueue.Enqueue(currentMove);

        }
    }
    public Curbe GenerateNextMove()
    {
        
        currentTrackLength++;
        
        return turnQueue.Dequeue();
    }



}