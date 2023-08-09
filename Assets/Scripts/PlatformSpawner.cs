using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    public GameObject rPlatform;
    public GameObject hPlatform;
    public GameObject vPlatform;

    // Start is called before the first frame update
    void Start()
    {
        //spawnPlatforms();
        spawnRandomPlatform();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //want this method to eventually precedurally generate platforms (or not)
    private void spawnPlatforms()
    {
        //middle starter platform
        Instantiate(rPlatform, new Vector3(0, -4, 0), transform.rotation);

        //right starter platform
        Instantiate(hPlatform, new Vector3(4, -0.5f, 0), transform.rotation);

        //left starter platform
        Instantiate(vPlatform, new Vector3(-4, -0.5f, 0), transform.rotation);
    }

    private void spawnRandomPlatform()
    {
        //array of platform prefabs
        GameObject[] platformPrefabs = { rPlatform, hPlatform, vPlatform };

        //choose a random platform prefab from the array
        GameObject randomPrefab = platformPrefabs[Random.Range(0, platformPrefabs.Length)];

        //define a random position within a range
        Vector3 randomPosition = new Vector3(Random.Range(-4f, 4f), -0.5f, 0);

        //instantiate chosen platform prefab at the random position
        Instantiate(randomPrefab, randomPosition, transform.rotation);
    }
}
