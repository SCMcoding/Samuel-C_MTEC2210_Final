
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MechG : MonoBehaviour
{
    public float speed = 5;

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, new Vector2(15f, transform.position.y),
        1f * Time.deltaTime);

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            Destroy(gameObject);
        }


    }


}
