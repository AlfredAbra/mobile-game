using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelRandomization : MonoBehaviour
{
    public List<GameObject> levelParts = new List<GameObject>();

    // Update is called once per frame
    void Start()
    {
        GameObject objectSpawn = levelParts[Random.Range(0, levelParts.Count)];
        Instantiate(objectSpawn, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
