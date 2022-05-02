using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject[] prefabs;
    private void Start()
    {
        Instantiate(prefabs[Random.Range(0, 3)], transform.position, Quaternion.identity);
        StartCoroutine(SpawnEnemy());
    }
    IEnumerator SpawnEnemy()

    {
        yield return new WaitForSeconds(10f);
        Instantiate(prefabs[Random.Range(0, 3)], transform.position, Quaternion.identity);
        Repeat();
    }
    private void Repeat()
    {
        StartCoroutine(SpawnEnemy());
    }
}
