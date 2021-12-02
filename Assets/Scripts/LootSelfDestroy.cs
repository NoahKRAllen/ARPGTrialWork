using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootSelfDestroy : MonoBehaviour
{
    GameObject _player;
    LootPickup _pickupManager;
    ScoreCounter _scoreCounter;

    public int _scoreAmount;
    private void OnEnable()
    {
        _player = FindObjectOfType<PlayerMovement>().gameObject;
        _pickupManager = _player.GetComponentInChildren<LootPickup>();
        _scoreCounter = FindObjectOfType<ScoreCounter>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(gameObject.transform.position, _player.transform.position) < 1.0f)
        {
            Debug.Log("Got the loot");
            _scoreCounter.IncreaseScore(_scoreAmount);
            _pickupManager.RemoveLootFromPool(this.gameObject);
            Destroy(this.gameObject);
        }
    }
}
