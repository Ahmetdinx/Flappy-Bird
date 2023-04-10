using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] GameObject pipesPrefab;
    [SerializeField] float pipeSpawnTime = 1.5f;
    [SerializeField] float height = 0.5f;


    private void Start()
    {
        StartCoroutine(SpawnPipe());  
    }


    IEnumerator SpawnPipe()
    {
        while (true)
        {
            Instantiate(pipesPrefab, new Vector3(3f, Random.Range(-height, height), 0), Quaternion.identity);

            yield return new WaitForSeconds(pipeSpawnTime);
        }
    }
}
