using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Vector3 InitPosition;

    void Start()
    {
        InitPosition = transform.position;
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.Z))
        {
            transform.position = InitPosition + Vector3.up;
            return ;
        }

        if(Input.GetKey(KeyCode.S))
        {
            transform.position = InitPosition - Vector3.up;
            return ;
        }

        transform.position = InitPosition;
    }
}
