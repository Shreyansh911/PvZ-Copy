using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] Attacker _Attackter;
    [SerializeField] float _minDelayInSpawn = 1, _maxDelayInSpawn = 5;
    [SerializeField] bool _spawn = true;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        while (_spawn)
        {
            yield return new WaitForSeconds(Random.Range(_minDelayInSpawn, _maxDelayInSpawn));
            EnemySpawner();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void EnemySpawner()
    {
        Attacker newAttacker = Instantiate(_Attackter, transform.position, Quaternion.identity) as Attacker;

        newAttacker.transform.parent = transform;
    }
}
