using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    [SerializeField] int _timeToWait = 4;
    int CurrentScreenIndex;

    // Start is called before the first frame update
    void Start()
    {
        CurrentScreenIndex = SceneManager.GetActiveScene().buildIndex;
        if (CurrentScreenIndex == 0)
        {
            StartCoroutine(LoadStartMenu());
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator LoadStartMenu()
    {
        yield return new WaitForSeconds(_timeToWait);
        SceneManager.LoadScene(CurrentScreenIndex + 1);
    }
}
