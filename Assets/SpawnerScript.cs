using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject go;
    private float randomX;
    public float spawnDelay;
    public int spawnCol;
    Vector3 whereToSpawn;    
    float nextSpawn = 0.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn) {

            nextSpawn = Time.time + spawnDelay;
            
            for (int i = 0; i < spawnCol; i++) {
                randomX = Random.Range(-5.0f, 1.0f);
                whereToSpawn = new Vector3(randomX, 2.0f, 0.0f);
                GameObject Enemy = Instantiate(go, whereToSpawn, Quaternion.identity);
            }
        }
    }
}
