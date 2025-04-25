using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [HideInInspector] private float maxTime = 2f;
    [HideInInspector] private float heightRange = 1f;
    [SerializeField] private GameObject _pipe;
    private float timer;
    private void Start()
    {
        SpawnPipe();
    }
    private void Update()
    {
        if (timer > maxTime) 
        {
            SpawnPipe();
            timer = 0;
        }
        timer += Time.deltaTime;
    }
    private void SpawnPipe() 
    {
        Vector3 spawnPos = transform.position + new Vector3(0, Random.Range(-heightRange, heightRange));
        GameObject pipe = Instantiate(_pipe, spawnPos, Quaternion.identity);
        Destroy(pipe, 10f);
    }
}
