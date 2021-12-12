using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levels : MonoBehaviour
{

    public GameObject ball;

    Vector3 ballStartPos = new Vector3(0.418107271f, 1f, 0.0181865692f);

    // Start is called before the first frame update
    void Start()
    {
        // This will spawn the ball in the desired starting position within the level when the level is started.
        Instantiate(ball, ballStartPos, Quaternion.identity);
    }

}
