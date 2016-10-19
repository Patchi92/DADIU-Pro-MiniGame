using UnityEngine;
using System.Collections.Generic;


public enum PickUpType
{
    BOOST, WEAPON, COIN 
}

interface PickUpAction
{
    //wat happends when activate dis 
    void activation();
}

public class PickUpManager: MonoBehaviour
{

    public GameObject prefab;

    public int pickUpCount;
    List<GameObject> list = new List<GameObject>();

	// Use this for initialization
	void Start () {
        


    }

    public void Generate()
    {
        if (pickUpCount < 1)
        {
            return;
        }
        
        for (int i = 0; i< 1; i++)
        {
            float val = Random.Range(0, 3);
            PickUpType type = (PickUpType) val;

            GameObject pickup;

            switch (type)
            {
                case PickUpType.BOOST:
                    pickup = Instantiate(prefab, Vector3.one, Quaternion.identity) as GameObject;
                    pickup.SetActive(true);

                    pickup.AddComponent<PickUpBoost>();

                    break;
                case PickUpType.WEAPON:
                    pickup = Instantiate(prefab, Vector3.one, Quaternion.identity) as GameObject;

                    pickup.AddComponent<PickUpWeapon>();
                    pickup.SetActive(true);
                    break;
                default:
                    pickup = Instantiate(prefab, Vector3.one, Quaternion.identity) as GameObject;

                    pickup.AddComponent<PickUpCoin>();
                    pickup.SetActive(true);
                    break;
            }

            list.Add(pickup);
        }

        foreach(GameObject pickUp in list) {
            
            //Debug.Log();
        }

    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
