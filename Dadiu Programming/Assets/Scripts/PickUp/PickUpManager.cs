using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;





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
    public Sprite SPEED_BOOST_SPRITE;
    public Sprite COIN_SPRITE;
    public Sprite WEAPON_SPRITE;



    public GameObject prefab;

    public int pickUpCount;
    public List<GameObject> list = new List<GameObject>();

	// Use this for initialization
	void Start () {
        


    }

    public void Generate()
    {
        if (pickUpCount < 1)
        {
            return;
        }
        
        for (int i = 0; i< pickUpCount; i++)
        {
            float val = Random.Range(0, 3);
            PickUpType type = (PickUpType) val;

            GameObject pickup;

            switch (type)
            {
                case PickUpType.BOOST:
                    pickup = Instantiate(prefab, new Vector3(1,0,0), prefab.transform.rotation) as GameObject;
                    pickup.SetActive(true);
                    
                    pickup.AddComponent<PickUpBoost>();
                    pickup.GetComponent<PickUpBoost>().sprite = SPEED_BOOST_SPRITE;

                    break;
                case PickUpType.WEAPON:
                    pickup = Instantiate(prefab, new Vector3(1, 0, 0), prefab.transform.rotation) as GameObject;

                    pickup.AddComponent<PickUpWeapon>();
                    pickup.SetActive(true);
                    pickup.GetComponent<PickUpWeapon>().sprite = WEAPON_SPRITE;
                    break;
                default:
                    pickup = Instantiate(prefab, new Vector3(1, 0, 0), prefab.transform.rotation) as GameObject;

                    pickup.AddComponent<PickUpCoin>();
                    pickup.SetActive(true);
                    pickup.GetComponent<PickUpCoin>().sprite = COIN_SPRITE;
                    break;
            }

            list.Add(pickup);
        }

        foreach(GameObject pickUp in list) {
            
            Debug.Log(pickUp);
        }

    }
	public GameObject getPowerUp()
    {
        Debug.Log("PICKUP COUNT: " + pickUpCount);
        pickUpCount--;
        if (pickUpCount < 0)
        {
            return null;
        }
        return list[pickUpCount];
    }
	// Update is called once per frame
	void Update () {
	
	}
}
