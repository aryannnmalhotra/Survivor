﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public HealthSystem playerHealth;
    public bool isZombie;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (isZombie)
            {
                if (Enemy.isHAttack == true)
                {
                    //Debug.Log("HeavyAttack");
                    playerHealth.DecreaseHealth(8);
                }
                else if (Enemy.isLAttack == true)
                {
                    playerHealth.DecreaseHealth(3);
                }
            }
            else
            {
                if (Enemy.isAttack == true)
                {
                    playerHealth.DecreaseHealth(1);
                }
            }
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}