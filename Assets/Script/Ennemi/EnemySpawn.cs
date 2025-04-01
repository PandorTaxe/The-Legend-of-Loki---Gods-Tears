using System;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] private List<GameObject> _enemies;
    [SerializeField] private List<GameObject> _spawnPoints;
    [SerializeField] private int _enemyNumber;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
            Spawn();
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        Despawn();
    }

    private void Spawn()
    {
        // for (int i = 0; i <= _enemyNumber; i++)
        // {
        //     Instantiate(_enemies[0], _spawnPoints[i].transform.position, Quaternion.identity ,gameObject.transform);
        // }
        
        foreach (var spawnPoint in _spawnPoints)
        {
            foreach (var enemy in _enemies)
            {
                Instantiate(enemy, spawnPoint.transform.position, Quaternion.identity ,gameObject.transform);
            }
        }
    }

    private void Despawn()
    {
        int i = 0;

        GameObject[] allChildren = new GameObject[transform.childCount];

        foreach (Transform child in transform)
        {
            allChildren[i] = child.gameObject;
            i += 1;
        }

        foreach (GameObject child in allChildren)
        {
            Destroy(child.gameObject);
        }
    }

}