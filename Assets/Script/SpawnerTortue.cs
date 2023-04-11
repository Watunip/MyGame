using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerTortue : MonoBehaviour
{
    public GameObject TurtleRed;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 randomSpawnPosition = new Vector3(Random.Range(130, 150), 1, Random.Range(550, 570));
            Instantiate(TurtleRed, randomSpawnPosition, Quaternion.identity);
        }
    }
}
