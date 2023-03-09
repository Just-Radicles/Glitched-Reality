using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //variables
    public GameObject chestPrefab;
    public GameObject player;
    private bool spawnChest = false;
    private float maxPatchPosX = 10;
    private float minPatchPosX = -13;
    private float maxPatchPosZ = 26.5f;
    private float minPatchPosZ = 1.5f;
    private float chestSpawnPosX = -20;
    private float chestSpawnPosY = 2f;
    private float chestSpawnPosZ = 52f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 spawnPos = new Vector3(chestSpawnPosX, chestSpawnPosY, chestSpawnPosZ);
        if (player.transform.position.z < maxPatchPosZ && player.transform.position.z > minPatchPosZ && player.transform.position.x > minPatchPosX && player.transform.position.x < maxPatchPosX && !spawnChest){
            Instantiate(chestPrefab, spawnPos, chestPrefab.transform.rotation);
            spawnChest = true;
        }
    }
}
