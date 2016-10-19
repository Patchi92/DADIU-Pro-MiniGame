using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CreateMesh : MonoBehaviour {

	private List<Vector3> vertices = new List<Vector3>();
	private List<Vector3> normals = new List<Vector3>();
	private List<int> indices = new List<int>();

    public int trackLength = 100;
    public int trackDificulty = 1;


    private TrackQueue trackQueue;


    private void addTriangle(Vector3 p1, Vector3 p2, Vector3 p3){
			vertices.Add(p1);
			vertices.Add(p2);
			vertices.Add(p3);
			indices.Add(indices.Count);
			indices.Add(indices.Count);
			indices.Add(indices.Count);
		}
		
		private void addQuad(Vector3 p3, Vector3 p2, Vector3 p1, Vector3 p4){
			// add first triangle
			int p1Index = vertices.Count;
			indices.Add(vertices.Count);
			vertices.Add(p1);
			
			indices.Add(vertices.Count);
			vertices.Add(p2);
			int p3Index = vertices.Count;
			indices.Add(vertices.Count);
			vertices.Add(p3);
			
			// Add second triangle
			indices.Add(p1Index); // reuse vertex from triangle above
			indices.Add(p3Index); // reuse vertex from triangle above
			indices.Add(vertices.Count);
			vertices.Add(p4);

			Vector3 normal = Vector3.Cross(p3-p1, p1-p2).normalized;
			normals.Add(normal);
			normals.Add(normal);
			normals.Add(normal);
			normals.Add(normal);
		}
		
		private void addCube(Vector3 pStart, Vector3 pEnd){
			float length = pEnd.x-pStart.x;
			Vector3 p1 = pStart;
			Vector3 p2 = pStart+Vector3.right*length;
			Vector3 p3 = pStart+Vector3.forward*length+Vector3.right*length;
			Vector3 p4 = pStart+Vector3.forward*length;
			
			//Vector3 p5 = pEnd-Vector3.forward*length-Vector3.right*length;
			//Vector3 p6 = pEnd-Vector3.forward*length;
			//Vector3 p7 = pEnd;
			//Vector3 p8 = pEnd-Vector3.right*length;
			
			addQuad(p1,p4,p3,p2);
        //addQuad(p1, p2, p3, p4);
        addQuad(p2, p3, p4, p1);

        //addQuad(p7,p6,p2,p3);
        //addQuad(p7,p3,p4,p8);
        //addQuad(p1,p5,p8,p4);
        //addQuad(p1,p2,p6,p5);
        //addQuad(p7,p8,p5,p6);
        return;
		}

    
    private Vector3 moveForward(Vector3 currentPos)
    {
        Move v = TrackMovement.MoveForward(currentPos);
        addCube(v.start, v.end);
        Debug.Log("Strat: " + v.start + " -  End: " + v.end);
        currentPos.z += TrackMovement.step;
        return currentPos;
    }

    private Vector3 moveBack(Vector3 currentPos)
    {
        Move v = TrackMovement.MoveBack(currentPos);
        addCube(v.start, v.end);
        currentPos.z -= TrackMovement.step;
        return currentPos;
    }

    private Vector3 moveRight(Vector3 currentPos)
    {

        Move v = TrackMovement.MoveRight(currentPos);
        addCube(v.start, v.end);
        currentPos.x += TrackMovement.step;
        return currentPos;
    }


    private Vector3 moveLeft(Vector3 currentPos)
    {

        Move v = TrackMovement.MoveLeft(currentPos);
        addCube(v.start, v.end);
        Debug.Log("Strat: " + v.start + " -  End: " + v.end);
        currentPos.x -= TrackMovement.step;
        return currentPos;
    }

    private void generateMengerSponge(Vector3 pStart, Vector3 pEnd)
    {

        int i = 0;
        Vector3 currentPos = new Vector3(1, 1, 1);


        //move forward
        for (i=0; i < 5; i ++)
        {
            currentPos = this.moveForward(currentPos);
        }
        


        for (i = 0; i < trackLength; i++)
        {
            Curbe curbe = trackQueue.GenerateNextMove();
            Debug.Log(curbe);
            switch (curbe)
            {
                case Curbe.FORWARD:
                    currentPos = this.moveForward(currentPos);
                    break;
                case Curbe.BACK:
                    currentPos = this.moveBack(currentPos);
                    break;
                case Curbe.RIGHT:
                    currentPos = this.moveRight(currentPos);
                    break;
                case Curbe.LEFT:
                    currentPos = this.moveLeft(currentPos);
                    break;
            }
        }

        Debug.Log(currentPos);


        return;
     
    }



    Mesh CreateMengerSponge()
    {

		vertices.Clear();
		indices.Clear();
		generateMengerSponge(Vector3.zero, Vector3.one);
		Mesh mesh = new Mesh();
		mesh.vertices = vertices.ToArray();
		mesh.normals = normals.ToArray();
		mesh.RecalculateBounds();
		mesh.uv = new Vector2[vertices.Count];

        Debug.Log(vertices.Count);
		mesh.SetIndices(indices.ToArray(), MeshTopology.Triangles, 0);

        


        return mesh;

    }

    void Start()
    {
        //set variables
        trackQueue = new TrackQueue();
        trackQueue.trackLength = trackLength;
        trackQueue.trackDificulty = trackDificulty;

        trackQueue.StartGenerating();

        //no other way to access the method in pickupmanager ?????
        GameObject pickUpManager = GameObject.Find("PickUpManager");
        PickUpManager managerReference = (PickUpManager)pickUpManager.GetComponent(typeof(PickUpManager));
        managerReference.Generate();

        
        Mesh mesh = CreateMengerSponge();
        GetComponent<MeshFilter>().mesh = mesh;
        MeshCollider meshc = gameObject.AddComponent(typeof(MeshCollider)) as MeshCollider;
        meshc.sharedMesh = mesh;
        
    }
}
