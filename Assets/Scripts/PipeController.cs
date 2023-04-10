using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeController : MonoBehaviour
{
    [SerializeField] float pipesSpeed = 3f;

    void Start()
    {
        Destroy(gameObject, 10f);
    }

    void Update()
    {
        transform.position += Vector3.left * pipesSpeed * Time.deltaTime;
    }
}
