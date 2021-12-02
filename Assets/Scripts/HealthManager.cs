using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    LootManager _lootTime;
    int _healthPool = 3;

    private void Start()
    {
        _lootTime = FindObjectOfType<LootManager>();
    }

    public void TakeDamage()
    {
        _healthPool--;
        if(_healthPool <= 0)
        {

            GameObject lootToSpawn = _lootTime.RollForLoot();
            int lootAmount = Random.Range(1, 5);
            for(int i = 0; i < lootAmount; i++)
            {
                Vector3 randomSpawnPos = Random.insideUnitSphere * 5 + gameObject.transform.position;
                randomSpawnPos.y = .5f;
                
                Instantiate(lootToSpawn, randomSpawnPos, _lootTime.transform.rotation, _lootTime.transform);
            }


            Destroy(this.gameObject);
        }
    }
}
