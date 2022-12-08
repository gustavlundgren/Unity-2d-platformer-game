using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] private GameObject projectile;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Instantiate(projectile, transform.position, Quaternion.identity);
        }
    }
}