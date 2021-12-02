using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootPickup : MonoBehaviour
{
    GameObject _playerCharacter;
    float _lootSuckPower = 5.0f;
    List<GameObject> _lootInRange = new List<GameObject>();
    private void Start()
    {
        _playerCharacter = FindObjectOfType<PlayerMovement>().gameObject;
    }
    private void LateUpdate()
    {
        if(_lootInRange.Count > 0)
        {
            for(int i = 0; i < _lootInRange.Count; i++)
            {
                _lootInRange[i].transform.position = Vector3.MoveTowards(_lootInRange[i].transform.position, _playerCharacter.transform.position, _lootSuckPower * Time.deltaTime);
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Pickup")
        {
            _lootInRange.Add(other.gameObject);
            
        }
    }

    public void RemoveLootFromPool(GameObject lootToRemove)
    {
        _lootInRange.Remove(lootToRemove);
    }
}
