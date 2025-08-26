using System.Net.NetworkInformation;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject Pipe;
    public float spawnRate = 2;
    private float timer = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnPipe();
            timer = 0;
        }
            
    }

    void spawnPipe()
    {
        float lowestPoint = 0x16; // bottom limit
        float highestPoint = 0x30; // top limit
        Instantiate(Pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }

}
