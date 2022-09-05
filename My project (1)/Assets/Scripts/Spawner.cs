using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [Tooltip("How much time to wait before destroying " +
             "the tile after reaching the end")]
    public float destroyTime = 1.5f;
    public float obstacleGenerator;
    public GameObject spawnPointCenter;
    public GameObject spawnPointLeft;
    public GameObject spawnPointRight;
    public GameObject obstacle;
    private int spawner = default;
    private void OnTriggerEnter(Collider col)
    {
        // First check if we collided with the player
        if (col.gameObject.GetComponent<PlayerController>())
        {
            // If we did, spawn a new tile
            GameObject.FindObjectOfType<GameManager>
                ().SpawnNextTile();
            // And destroy this entire tile after a short delay
            Destroy(transform.parent.gameObject, destroyTime);
        }
        spawner = Random.Range(0, 4);
        Debug.Log(spawner);
        if (spawner == 1)
        {
            Instantiate(obstacle, spawnPointLeft.transform.position, Quaternion.identity);
            //Destroy(obstacle, destroyTime);
        }
        if (spawner == 2)
        {
            Instantiate(obstacle, spawnPointCenter.transform.position, Quaternion.identity);
            //Destroy(obstacle, destroyTime);
        }
        if (spawner == 3)
        {
            Instantiate(obstacle, spawnPointRight.transform.position, Quaternion.identity);
            //Destroy(obstacle, destroyTime);
        }
    }
}