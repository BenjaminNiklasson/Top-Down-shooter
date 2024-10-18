using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemygondie : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            Destroy(gameObject);
        }
    }
}
