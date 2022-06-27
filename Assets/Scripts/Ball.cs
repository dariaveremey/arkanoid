using UnityEngine;

public class Ball : MonoBehaviour
{
    #region Variables

    [SerializeField] private Rigidbody2D _rb;
    [SerializeField] private Pad _pad;

    private Vector2 _startDirection;

    #endregion


    //private float _speed = 15f;

    //private Vector2 _startDirection;


    #region Private methods

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.magenta;
        Gizmos.DrawLine(transform.position, transform.position + (Vector3) _startDirection);

        Gizmos.color = Color.green;
        Gizmos.DrawLine(transform.position, transform.position + (Vector3) _rb.velocity);
    }

    public void StartMove()

    {
        //_rb.velocity = _startDirection * _speed;
        _startDirection = new Vector2(Random.Range(-4f, 5f), Random.Range(2f, 5f)); //.normalized;
        _rb.velocity = _startDirection;


        Debug.Log($"{_rb.velocity.x},{_rb.velocity.y}");
        Debug.Log($"{_rb.velocity}");
    }

    public void MoveWithPad()
    {
        Vector3 padPosition = _pad.transform.position;
        Vector3 currentPosition = transform.position;
        currentPosition.x = padPosition.x;
        transform.position = currentPosition;
    }

    #endregion
}