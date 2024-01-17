using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBullet : MonoBehaviour
{
    float speed = 1f;

    void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }

    void Update()
    {
        this.transform.Translate(Vector3.up * speed);
    }
}