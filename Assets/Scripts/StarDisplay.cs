using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarDisplay : MonoBehaviour
{
    [SerializeField] int _starPoints = 100;
    Text _starText;

    // Start is called before the first frame update
    void Start()
    {
        _starText = GetComponent<Text>();
        UpdateDisplay();
    }

    // Update is called once per frame
    void UpdateDisplay()
    {
        _starText.text = _starPoints.ToString();
    }

    public void AddStars(int Amount)
    {
        _starPoints += Amount;
        UpdateDisplay();
    }

    public bool HaveEnoughStars(int Amount)
    {
        return _starPoints >= Amount;
    }

    public void SpendingStars(int Amount)
    {
        if(_starPoints >= Amount)
        {
            _starPoints -= Amount;
            UpdateDisplay();
        } 
    }
}
