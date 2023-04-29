using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    private Touch _touch;
    private Rigidbody2D _rigidbody;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }
    
    void FixedUpdate()
    {
        if (Input.touchCount > 0)
        {
            _touch = Input.GetTouch(0);

            if (_touch.phase == TouchPhase.Moved)
            {
                _rigidbody.velocity = new Vector2(_rigidbody.velocity.x + _touch.deltaPosition.x * _moveSpeed,
                    _rigidbody.velocity.y + _touch.deltaPosition.y * _moveSpeed);
            }
            else
            {
                _rigidbody.velocity = Vector2.zero;
            }
        }
    }
}
