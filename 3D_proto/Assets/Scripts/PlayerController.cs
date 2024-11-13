using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private float rotationSpeed;
    [SerializeField] private float jumpForce;
    [SerializeField] private KeyCode jumpKey;

    private Rigidbody _rb;
    void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void Update()
    {
        float moveForward = Input.GetAxis("Vertical");
        float rotate = Input.GetAxis("Horizontal");

        Move(moveForward);
        Rotate(rotate);
        if (Input.GetKey(jumpKey))
        {
            Jump();
        }

    }

    private void Move(float value)
    {
        //_rb.velocity = new Vector3(0, _rb.velocity.y, value * moveSpeed);

        _rb.velocity = transform.forward * moveSpeed * value;   
    }

    private void Jump()
    {
        _rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }

    private void Rotate(float value)
    {
        transform.Rotate(Vector3.up, value * rotationSpeed * Time.deltaTime);
    }
}
