using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    //Object which will be attached to the script for Spawning
    [Header("Spikes Object for controlling the game")]
    public GameObject spikes;
    //Height position of the spikes
    [Header("Default Height")]
    public float height;
    // Start is called before the first frame update
    void Start()
    {
        //repeat function every 4 seconds (similar to a CreateTimer)
        InvokeRepeating("InstantiateObjects", 1f, 4f);
    }

    // Update is called once per frame
    void Update()
    {
        //Position for the gameObjects (x,y,z)
        transform.position = new Vector3(5, Random.Range(-height, height), 0);
    }
    void InstantiateObjects()
    {
        //spawn object by position and rotation
        Instantiate(spikes, transform.position, transform.rotation);
    }
}
