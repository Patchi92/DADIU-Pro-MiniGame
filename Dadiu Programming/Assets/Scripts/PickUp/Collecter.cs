using UnityEngine;
using System.Collections.Generic;

public class Collecter : MonoBehaviour {

    Queue<GameObject> collectibleQueue = new Queue<GameObject>();


    public void Update()
    {
        //press space activate power up
        if (collectibleQueue.Count > 0 && Input.GetKeyDown("space"))
        {
            GameObject powerUp = collectibleQueue.Dequeue();

            powerUp.GetComponent<PickUpAction>().activation();

            Debug.Log("Pick up used");
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Pick Up"))
        {
            col.gameObject.SetActive(false);

            collectibleQueue.Enqueue(col.gameObject);
        }
    }
}
