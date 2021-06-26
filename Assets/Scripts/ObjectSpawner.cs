using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject[] ItemPrefabs;
    public float Radius = 1;

    // Update is called once per frame
    void Start()
    {
            StartCoroutine(Wait());
    }

    // A small wait before objects start spawning
    IEnumerator Wait()
    {
        for (int spawnCount = 0; spawnCount <= 19; spawnCount++)
        {
            yield return new WaitForSeconds(1);
            SpawnObjectAtRandom();
            Debug.Log("Object Spawned");
        }
    }

    // Will spawn objects at random areas of the spawner's radius
    void SpawnObjectAtRandom()
    {
        int randItem = Random.Range(0, ItemPrefabs.Length);

        Vector3 randomPos = Random.insideUnitCircle * Radius;
        Instantiate(ItemPrefabs[randItem], randomPos, transform.rotation);
    }

    // The wireframe of the radius in the scene editor
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(this.transform.position, Radius);
    }
}
