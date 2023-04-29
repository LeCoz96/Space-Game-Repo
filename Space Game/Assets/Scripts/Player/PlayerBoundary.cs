using UnityEngine;

public class PlayerBoundary : MonoBehaviour
{
    [SerializeField] private float _playerWidth, _playerHeight;

    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -_playerWidth, _playerWidth), 
            Mathf.Clamp(transform.position.y, -_playerHeight, _playerHeight), transform.position.z);
    }
}
