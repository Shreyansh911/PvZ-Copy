using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] GameObject _projectile;
    [SerializeField] Transform _gun;
    SpawnManager _myLaneSpawner;
    Animator _animator;

    void Start()
    {
        SetLaneSpawner();
        _animator = GetComponent<Animator>();
    }

    void Update()
    {
        if(IsAttackerInLane())
        {
            _animator.SetBool("IsAttacking", true);
        }
        else
        {
            _animator.SetBool("IsAttacking", false);
        }
    }

    void SetLaneSpawner()
    {
        SpawnManager[] Spawner = FindObjectsOfType<SpawnManager>();

        foreach(SpawnManager spawner in Spawner)
        {
            bool isCloseEnough = (Mathf.Abs(spawner.transform.position.y - transform.position.y) <= Mathf.Epsilon);

            if(isCloseEnough)
            {
                _myLaneSpawner = spawner;
            }
        }    
    }

    bool IsAttackerInLane()
    {
        if(_myLaneSpawner.transform.childCount <= 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public void Fire()
    {
        Instantiate(_projectile, _gun.position, transform.rotation);
    }
}
