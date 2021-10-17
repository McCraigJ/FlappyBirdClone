using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    [SerializeField]
    public float _speed = 5f;

    [SerializeField]
    public float _randomiseMin = -3f;

    [SerializeField]
    public float _randomiseMax = 3f;

    [SerializeField]
    public int _z = 0;

    [SerializeField]
    public bool _randomiseX = false;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * _speed);
        if (transform.position.x < -15)
        {            
            float x = _randomiseX ? Random.Range(15, 20) : 15;

            if (_randomiseMin != _randomiseMax)
            {
                float randomYPosition = Random.Range(_randomiseMin, _randomiseMax);
                transform.position = new Vector3(x, randomYPosition, _z);
            }
            else
            {
                float randomYPosition = Random.Range(-3, 3);
                transform.position = new Vector3(x, transform.position.y, _z);
            }
        }
    }
}
