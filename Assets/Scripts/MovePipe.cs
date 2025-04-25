using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePipe : MonoBehaviour
{
    [HideInInspector] private float speed = 3f;
    private void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
