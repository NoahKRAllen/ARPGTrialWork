using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    Transform _playerCharacter;

    Vector3 _offset;

    public float _smoothSpeed = 0.125f;

    

    // Start is called before the first frame update
    void Start()
    {
        _playerCharacter = GameObject.FindGameObjectWithTag("Player").transform;
        _offset = transform.position - _playerCharacter.transform.position;
    }

    void LateUpdate()
    {
        Vector3 desiredPos = _playerCharacter.position + _offset;
        Vector3 smoothedPos = Vector3.Lerp(transform.position, desiredPos, _smoothSpeed * Time.deltaTime);
        transform.position = smoothedPos; 
    }
}
