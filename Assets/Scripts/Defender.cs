using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour
{
    [SerializeField] int _starCost = 100;

    public void AddStars(int Amount)
    {
        FindObjectOfType<StarDisplay>().AddStars(Amount);
    }

    public int GetStarCost()
    {
        return _starCost;
    }
}
