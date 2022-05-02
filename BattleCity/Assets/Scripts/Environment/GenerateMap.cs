using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateMap : MonoBehaviour
{
    public GameObject[] prefabBlock;

    private void Start()
    {
        int rand = Random.Range(0, prefabBlock.Length);
        Instantiate(prefabBlock[rand], transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}

