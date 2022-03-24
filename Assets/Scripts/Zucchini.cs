using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zucchini : MonoBehaviour
{
    [SerializeField] float _moveSpeed = 3;
    [SerializeField] int Damage = 50;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * _moveSpeed);
    }

    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Attacker")
        {
            FindObjectOfType<Attacker>().Damage(Damage);
            Destroy(this.gameObject);
        }
    }

}
