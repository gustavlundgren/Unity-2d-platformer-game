using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
    private float health = 2f;

    [SerializeField] private SpriteRenderer sr;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            health--;
        }
    }

    private void Update()
    {
        if (health == 0)
        {
            sr.color= Color.black;
        }
    }
}
