using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawnManager : MonoBehaviour
{
    Defender _defender;

    private void OnMouseDown()
    {
        AttemptToPlaceDefenderAt(GetSquareClicked());
    }

    public void SetSelectedDefender(Defender DefenderToSelect)
    {
        _defender = DefenderToSelect;
    }

    private Vector2 GetSquareClicked()
    {
        Vector2 clickPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(clickPos);
        Vector2 gridPos = SnapToGrid(worldPos);
        return gridPos;
    }

    void AttemptToPlaceDefenderAt(Vector2 Gridpos)
    {
        var StarDisplay = FindObjectOfType<StarDisplay>();
        int DefenderCost = _defender.GetStarCost();

        if (StarDisplay.HaveEnoughStars(DefenderCost))
        {
            DefenderSpawner(Gridpos);
            StarDisplay.SpendingStars(DefenderCost);
        }
    }

    private Vector2 SnapToGrid(Vector2 rawWorldPos)
    {
        float newX = Mathf.RoundToInt(rawWorldPos.x);
        float newY = Mathf.RoundToInt(rawWorldPos.y);
        return new Vector2(newX, newY);
    }

    private void DefenderSpawner(Vector2 RoundedPosition)
    {
        Defender newDefender = Instantiate(_defender, RoundedPosition, Quaternion.identity) as Defender;
    }
}
