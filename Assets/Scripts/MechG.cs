
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MechG : MonoBehaviour

{
    public float speed = 5;
    public float spawnTime = 5f;

    private void Start()
    {
    //InvokeRepeating("Spawn", spawnTime, spawnTime);

  
}
   
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, new Vector2(-15f, transform.position.y),
        speed * Time.deltaTime);

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            Destroy(gameObject);
        }
        else if (collision.gameObject.tag == "Wall")
        {
            Destroy(gameObject);
        }


    }


}
