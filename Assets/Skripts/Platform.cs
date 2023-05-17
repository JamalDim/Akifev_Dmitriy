using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public GameObject platformPrefab;
    public float width = 3f;
    public float maxY;
    public float minY;
    public int quantityPlatfotm;
    void Start()
    {

        Vector3 spawnpos = new Vector3(0,0,0);
        for (int i = 0; i < quantityPlatfotm; i++)
        {
            spawnpos.y = Random.Range(minY, maxY);
            spawnpos.x = Random.Range(-width, width);
            
            {
                Instantiate(platformPrefab, spawnpos, Quaternion.identity);
            }
           
        }
        
    }


    void Update()
    {
       
    }

   
}
