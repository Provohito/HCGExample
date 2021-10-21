using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Transform _player;
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _horizontalSpeed;
    void Start()
    {
        _player = GetComponent<Transform>();
    }

    void Update()
    {
        float _horizontalAxis = Input.GetAxis("Horizontal");
        _player.Translate(new Vector3(_moveSpeed, 0f, -_horizontalAxis * _horizontalSpeed) * Time.deltaTime, Space.World);
    }
}
