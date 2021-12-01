using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    GameObject _playerCharacter;

    Vector3 _distFromPlayer;

    public float _smoothSpeed = 0.125f;

    // Start is called before the first frame update
    void Start()
    {
        _playerCharacter = GameObject.FindGameObjectWithTag("Player");
        _distFromPlayer = transform.position - _playerCharacter.transform.position;
    }

    void LateUpdate()
    {
        
    }
}
