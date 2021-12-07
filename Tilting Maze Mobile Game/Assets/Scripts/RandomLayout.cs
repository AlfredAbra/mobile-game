using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomLayout : MonoBehaviour
{

    public List<GameObject> layoutSpawnList = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        GameObject chosenLayout = layoutSpawnList[Random.Range(0, layoutSpawnList.Count)];
        Instantiate(chosenLayout, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

}
