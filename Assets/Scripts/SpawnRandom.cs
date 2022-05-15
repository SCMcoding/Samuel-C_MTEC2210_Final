 using UnityEngine;
 using System.Collections;
 
 public class SpawnRandom : MonoBehaviour {
 
     public GameObject[] objects;
     public float spawnTime = 3f;
     private Vector3 spawnPosition;
 
     // Use this for initialization
     void Start()
     {
        
         InvokeRepeating("Spawn", spawnTime, spawnTime);
 
     }
 
     void Spawn()
     {
         spawnPosition.x = Random.Range(-17, 17);
         spawnPosition.y = 0.5f;
         spawnPosition.z = Random.Range(-17, 17);
 
         Instantiate(objects[UnityEngine.Random.Range(0, - 1)], spawnPosition, Quaternion.identity);
     }
 
 }