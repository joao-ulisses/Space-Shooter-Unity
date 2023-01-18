using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float _speed = 3.5f;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        CalculateMovement();
    }

    void CalculateMovement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(horizontalInput, verticalInput);

        transform.Translate(direction * _speed * Time.deltaTime);

        float actualX = transform.position.x;

        if (actualX > 11.3f)
        {
            actualX = -11.3f;
        }
        else if (actualX < -11.3f)
        {
            actualX = 11.3f;
        }
        transform.position = new Vector3(actualX, Mathf.Clamp(transform.position.y, -3.8f, 0), 0);
    }


}
