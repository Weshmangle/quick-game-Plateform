using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "Quick Game/Block")]
public class SOBlocksList : ScriptableObject
{
    public List<Block> blocks = new List<Block>();
    public float SpeedMoving = 5.0f;
    public float SpeedSpawn = 1.0f;

    public Block GetRandomBlockPrefabs()
    {
        int count = Random.Range(0, blocks.Count);
        return  blocks[count];
    }
}
