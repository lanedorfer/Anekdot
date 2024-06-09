using System;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform Player;
    private Vector3 _target;
    [SerializeField] private float _smoothSpeed = 2f;

    private void Update()
    {
        if (Player)
        {
            Vector3 currentPosition = Vector3.Lerp(transform.position, _target, _smoothSpeed * Time.deltaTime);
            transform.position = currentPosition;

            _target = new Vector3(Player.transform.position.x, Player.transform.position.y, transform.position.z);
        }
    }
}  
