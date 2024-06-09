/*
using PlayerSpace;
using UnityEngine;

public class Enemy1 : MonoBehaviour
{
    [SerializeField] private int _lives = 1;
    private float Vector3 _dir;
    private SpriteRenderer _sprite;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == Player.Instance.gameObject);
        {
            Player.Instance.GetDamage()
            _lives--;
            Debug.Log("У врага осталось " + _lives);
        }
        if (_lives < 1)
        {
            Die();
        }
    }
}
*/