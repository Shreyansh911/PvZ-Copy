using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{
    [SerializeField] int _health = 50;
    [SerializeField] ParticleSystem _deathEffects;

    float _currentSpeed = 1;


    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * Time.deltaTime * _currentSpeed);
        if(_health <= 0)
        {
            TriggerDeathEffects();
            Destroy(this.gameObject);
        }
    }

    private void TriggerDeathEffects()
    {
        ParticleSystem DeathEffect = Instantiate(_deathEffects, transform.position, Quaternion.identity);
        Destroy(DeathEffect.gameObject, 2);
    }

    public void SetMovementSpeed(float Speed)
    {
        _currentSpeed = Speed;
    }

    public void Damage(int Amount)
    {
        _health -= Amount;
    }
}
