using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    float _bulletSpeed = 10.0f;
    float _timeActive = 0.0f;
    float _maxTimeActive = 10.0f;
    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position += gameObject.transform.forward * _bulletSpeed * Time.deltaTime;
        _timeActive += Time.deltaTime;
        if(_timeActive > _maxTimeActive)
        {
            transform.position = new Vector3(0, 0, 0);
            gameObject.SetActive(false);
            _timeActive = 0.0f;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<HealthManager>() != null)
        {
            other.GetComponent<HealthManager>().TakeDamage();
        }
        transform.position = new Vector3(0, 0, 0);
        gameObject.SetActive(false);
    }
}
