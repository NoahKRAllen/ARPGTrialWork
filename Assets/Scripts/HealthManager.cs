using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{

    int _healthPool = 3;

    public void TakeDamage()
    {
        _healthPool--;
        if(_healthPool <= 0)
        {
            //Do spawning of loot here



            Destroy(this.gameObject);
        }
    }
}
