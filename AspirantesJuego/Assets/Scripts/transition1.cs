using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transition1 : MonoBehaviour
{
    public Camera cam;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.transform.position = new Vector3(-10.01f, -24.24f,0);
            cam.orthographicSize = 8;
            cam.transform.position = cam.transform.position + new Vector3(-1f,-25f,0);
        }
    }
}
