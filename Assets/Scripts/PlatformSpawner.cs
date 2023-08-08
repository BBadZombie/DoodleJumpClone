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
        SpawnPlatforms();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //want this method to eventually precedurally generate platforms (or not)
    private void SpawnPlatforms()
    {
        //middle starter platform
        Instantiate(rPlatform, new Vector3(0, -4, 0), transform.rotation);

        //right starter platform
        Instantiate(hPlatform, new Vector3(4, -0.5f, 0), transform.rotation);

        //left starter platform
        Instantiate(vPlatform, new Vector3(-4, -0.5f, 0), transform.rotation);
    }
}
