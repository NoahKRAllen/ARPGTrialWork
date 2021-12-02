using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float _moveSpeed = 5;
    public float _gravity = -5;

    float _fallingSpeed;

    CharacterController _playerCharacterController;
    // Start is called before the first frame update
    void Start()
    {
        _playerCharacterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        HandleMovement();
    }

    void HandleMovement()
    {

        Vector3 _playerInput = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        

        Vector3 _unmoddedMovement = Vector3.zero;
        if(_playerInput.z > 0)
        {
            _unmoddedMovement += transform.forward;
        }
        if(_playerInput.z < 0)
        {
            _unmoddedMovement += transform.forward * -1;
        }

        if(_playerInput.x > 0)
        {
            _unmoddedMovement += transform.right;
        }
        if(_playerInput.x < 0)
        {
            _unmoddedMovement += transform.right * -1;
        }


        Vector3 _playerMovement = _unmoddedMovement * _moveSpeed;
        if(!_playerCharacterController.isGrounded)
        {
            _fallingSpeed += _gravity * Time.deltaTime;

            _playerMovement.y = _fallingSpeed;
        }

        _playerCharacterController.Move(_playerMovement * Time.deltaTime);

    }
}
