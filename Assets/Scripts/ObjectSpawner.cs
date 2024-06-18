using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    [SerializeField]
    private Transform[] arraySpawnPosition;

    public GameObject CarPrefabs;

    private void Awake()
    {
        List<Transform> availablePositions = new List<Transform>(arraySpawnPosition);
            

        int randomPrefabsSpawn = Random.Range(1, availablePositions.Count + 1);

        for (int i = 0; i < randomPrefabsSpawn; i++)
        {
            int spawnIndex = Random.Range(0, availablePositions.Count);
            Instantiate(CarPrefabs, availablePositions[spawnIndex].position, Quaternion.identity);

            availablePositions.RemoveAt(spawnIndex);
        }
       


    }

}
