using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player_Projectile_Script : MonoBehaviour
{
    private Vector3 targetPos;
    public float speed;
    

    private void Start()
    {
        Camera cam = Camera.main;

        Vector3 mousePos = Input.mousePosition;
        Vector3 targetPos = cam.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, cam.nearClipPlane));
    }

    private void Update()
    {       

        transform.position = Vector3.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

        if (transform.position == targetPos)
        {
            Destroy(gameObject);
        }
    }
}