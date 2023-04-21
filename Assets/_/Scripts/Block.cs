using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    public float Speed = 5.0f;

    void Start()
    {
        transform.position =  Vector3.right * 7 - Vector3.forward * 5;
    }

    void Update()
    {
        transform.position += - Time.deltaTime * Vector3.right * Speed;
    }
}
