using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    public float speed;
    [SerializeField] private Transform target;
    private float minDist = 3f;

    public GameObject projectile;
    public float timeBetweenShots;
    private float nextShotTime;

    // [SerializeField] private GameObject player; 
    void Update()
    {
        if (Vector2.Distance(transform.position, target.position) > minDist)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
        
        if (Time.time > nextShotTime)
        {
            Instantiate(projectile, transform.position, Quaternion.identity);
            nextShotTime= Time.time + timeBetweenShots;    
        }
    }
}
