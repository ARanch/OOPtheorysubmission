using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private int maxoffset = 15;
    [SerializeField] private GameObject ball;
    [SerializeField] private GameObject cube;
    [SerializeField] private int amount = 10; // amount of objects to spawn
    Vector3 offset = new Vector3();

    // Start is called before the first frame update
    void Start()
    {
        if (GameManager.itemType == "Ball")
        {
            SpawnObjects(ball, amount);

        }
        else if (GameManager.itemType == "Cube")
        {
             SpawnObjects(cube, amount);

        }
    }

    // Update is called once per frame
    void SpawnObjects(GameObject item, int amount)
    {
        for (int i = 0; i<amount; i++)
        {
            //create offset vector for random spawn position
            offset.x = Random.Range(-maxoffset, maxoffset);
            offset.z = Random.Range(-maxoffset, maxoffset);
            GameObject blob = Instantiate(item, transform.position + offset, transform.rotation);
        }
    }
}
