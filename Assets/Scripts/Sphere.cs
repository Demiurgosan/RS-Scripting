using UnityEngine;

public class Sphere : MonoBehaviour
{

    [SerializeField] private float _speed;
    [SerializeField] private int _directionX;
    [SerializeField] private int _directionY;
    [SerializeField] private int _directionZ;

    void Update()
    {
        transform.position += new Vector3(_directionX * _speed * Time.deltaTime,
            _directionY * _speed * Time.deltaTime, _directionZ * _speed * Time.deltaTime);
    }
}
