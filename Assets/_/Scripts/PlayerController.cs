using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
