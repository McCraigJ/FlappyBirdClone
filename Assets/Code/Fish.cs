using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fish : MonoBehaviour
{
    [SerializeField]
    private float _upwardForceMultiplier = 100f;

    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.AddForce(Vector3.up * _upwardForceMultiplier);
    }

    // Update is called once per frame
    void Update()
    {
        bool pressFireButton = Input.GetButtonDown("Fire1");
        if (pressFireButton)
        {
            Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();
            rigidbody.velocity = Vector3.zero;
            rigidbody.AddForce(Vector3.up * _upwardForceMultiplier);
        }

        if (transform.position.y > 6f || transform.position.y < -6f)
        {
            SceneManager.LoadScene(0);
        }

    }
}
