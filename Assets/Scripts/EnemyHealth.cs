using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{

    [SerializeField] int maxHealth =5;
    [SerializeField] private int currentHealth;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;  //set your current health equal to your variable of max health at start
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnParticleCollision(GameObject other)
    {
        ProcessHit();
    }

    void ProcessHit()
    {
        currentHealth--; //minus 1 from current health on particle collision
        if(currentHealth <=0)
        {
            Destroy(gameObject);
        }
    }

}
