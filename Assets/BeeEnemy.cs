
using UnityEngine;
using UnityEngine.SceneManagement;

public class BeeEnemy : MonoBehaviour
{
  public float _speed;
  public Vector3[] positions;

  private int _currentTarget;

  public void FixedUpdate()
  {
    transform.position = Vector3.MoveTowards(transform.position, positions[_currentTarget], _speed);
    if (transform.position == positions[_currentTarget])
    {
      if (_currentTarget < positions.Length - 1)
      {
        _currentTarget ++;
      }
      else
      {
        _currentTarget = 0;
      }
    }
  }

  private void OnCollisionEnter2D(Collision2D collision)
  {
    if (collision.gameObject.tag == "Player")
    {
      SceneManager.LoadScene(0);
    }
  }
}

