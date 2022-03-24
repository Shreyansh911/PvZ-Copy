using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderButton : MonoBehaviour
{
    [SerializeField] Defender _defender;

    private void OnMouseDown()
    {
        var Buttons = FindObjectsOfType<DefenderButton>();

        foreach(DefenderButton Button in Buttons)
        {
            Button.GetComponent<SpriteRenderer>().color = new Color32(41, 41, 41, 255);
        }

        GetComponent<SpriteRenderer>().color = Color.white;

        FindObjectOfType<DefenderSpawnManager>().SetSelectedDefender(_defender);
    }
}
