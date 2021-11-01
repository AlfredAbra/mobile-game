using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitPlatform : MonoBehaviour
{
    bool ballIsTouching = false;

    public Text winText;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            Destroy(other.gameObject);
            ballIsTouching = true;
        }
    }

    void Update()
    {
        if(ballIsTouching == false)
        {
            winText.text = "";
        }

        else if(ballIsTouching == true)
        {
            winText.text = "You Win!";
        }
    }
}
