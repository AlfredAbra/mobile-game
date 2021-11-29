using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WinText : MonoBehaviour
{
    public Text winText;

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            winText.text = "YOU WIN!";
            Time.timeScale = 0;
        }
    }
}
