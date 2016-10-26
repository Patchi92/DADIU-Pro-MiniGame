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

	Vector3[] positions = {
		new Vector3(0,0, 50),
		new Vector3(0,0, 130),
		new Vector3(0,0, 250),
		new Vector3(-180,0, 330),
		new Vector3(-360,0, 200),
		new Vector3(-360,0, 0),
		new Vector3(-360,0, -150),
		new Vector3(-360,0, -300),
		new Vector3(-160,0, -350),
		new Vector3(0, 0, -350),
		new Vector3(150,0, -350),
		new Vector3(250,0, -350),
		new Vector3(270,0, -200),
		new Vector3(270,0, -100),
		new Vector3(270,0, 0),

	};


    public GameObject prefab;

    public int pickUpCount;
    public List<GameObject> list = new List<GameObject>();

	// Use this for initialization
	void Start () {
        
		this.Generate ();


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
					
					
					pickup = createBoostPickup (positions[i]);
					

                    break;
                case PickUpType.WEAPON:

					
					pickup = createWeaponPickup (positions[i]);
					
                    
                    break;
                default:
					
					pickup = createCoinPickup(positions[i]);
					

                    break;
            }

            list.Add(pickup);
        }


			
    }

	private GameObject createBoostPickup( Vector3 pos)
	{
		GameObject pickup = Instantiate(prefab, pos, prefab.transform.rotation) as GameObject;
		pickup.SetActive(true);

		pickup.AddComponent<PickUpBoost>();
		pickup.GetComponent<PickUpBoost>().sprite = SPEED_BOOST_SPRITE;

		return pickup;
	}

	private GameObject createCoinPickup(Vector3 pos)
	{
		GameObject pickup = Instantiate(prefab, pos, prefab.transform.rotation) as GameObject;
		pickup.AddComponent<PickUpCoin>();
		pickup.SetActive(true);
		pickup.GetComponent<PickUpCoin>().sprite = COIN_SPRITE;

		return pickup;
	}

	private GameObject createWeaponPickup( Vector3 pos)
	{
		GameObject pickup = Instantiate(prefab, pos, prefab.transform.rotation) as GameObject;
		pickup.AddComponent<PickUpWeapon>();
		pickup.SetActive(true);
		pickup.GetComponent<PickUpWeapon>().sprite = WEAPON_SPRITE;

		return pickup;
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
