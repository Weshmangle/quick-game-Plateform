using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public SOBlocksList blocks;
    
    void Start()
    {
        StartCoroutine(Spawn());
    }

    void Update()
    {
    }


    public IEnumerator Spawn()
    {
        Block prefab = blocks.GetRandomBlockPrefabs();

        Instantiate<Block>(prefab).Speed = blocks.SpeedMoving;

        yield return new WaitForSeconds(blocks.SpeedSpawn);
        
        StartCoroutine(Spawn());
    }
}
