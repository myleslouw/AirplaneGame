using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudSpawner : MonoBehaviour
{
    public GameObject[] clouds;

    private float counter;

    private float randomPosition;
    private float interval;

    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        counter = counter + 1 * Time.deltaTime;
       

        if(counter >= interval)
        {
            SpawnCloud();
        }

    }

    private void SpawnCloud()
    {
        //random position
        randomPosition = Random.Range(-20f, 5f);

        //get random cloud
        GameObject cloud = RandomiseCloud();

        Instantiate(cloud, new Vector3(randomPosition, CONSTANTS.HEIGHT, 20), Quaternion.identity);
        counter = 0;
        interval = Random.Range(1f, 3f);
    }

    private GameObject RandomiseCloud()
    {
        int index = Random.Range(0, 2);

        return clouds[index];
    }

}
