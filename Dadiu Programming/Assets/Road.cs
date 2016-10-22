using UnityEngine;
using System.Collections;

public class Road : MonoBehaviour {


    public GameObject Edge;
    public GameObject Lane;
    public GameObject FastLane;
    public GameObject LineOne;
    public GameObject LineTwo;
    public GameObject LineThree;

    public Shader vertexAni;
    public Shader standardShader;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            FunkyTime();

        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            FunkyTimeStop();
        }

    }

    public void FunkyTime()
    {
        Edge.GetComponent<Renderer>().material.shader = vertexAni;
        Lane.GetComponent<Renderer>().material.shader = vertexAni;
        FastLane.GetComponent<Renderer>().material.shader = vertexAni;
        LineOne.GetComponent<Renderer>().material.shader = vertexAni;
        LineTwo.GetComponent<Renderer>().material.shader = vertexAni;
        LineThree.GetComponent<Renderer>().material.shader = vertexAni;

    }

    public void FunkyTimeStop()
    {
        Edge.GetComponent<Renderer>().material.shader = standardShader;
        Lane.GetComponent<Renderer>().material.shader = standardShader;
        FastLane.GetComponent<Renderer>().material.shader = standardShader;
        LineOne.GetComponent<Renderer>().material.shader = standardShader;
        LineTwo.GetComponent<Renderer>().material.shader = standardShader;
        LineThree.GetComponent<Renderer>().material.shader = standardShader;
    }

}
