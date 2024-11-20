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
    //[SerializeField] private LayerMask coinMask;
    //[SerializeField] private Score playerScore;

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
        if (Input.GetKeyDown(jumpKey))
        {
            Jump();
        }

    }

    private void Move(float value)
    {
        //_rb.velocity = new Vector3(0, _rb.velocity.y, value * moveSpeed);

        Vector3 direction = transform.forward * moveSpeed * value;
        Vector3 combinedDirection = new Vector3(direction.x, _rb.velocity.y, direction.z);

        _rb.velocity = combinedDirection;   
    }

    private void Jump()
    {
        _rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }

    private void Rotate(float value)
    {
        transform.Rotate(Vector3.up, value * rotationSpeed * Time.deltaTime);
    }

    /*private void OnTriggerEnter(Collider other)
    {
        if (LayerMaskUtil.ContainsLayer(coinMask, other.gameObject.layer))
        {
            if (other.TryGetComponent(out Coin coin))
            {
                playerScore.AddScore(coin.price);
                other.gameObject.SetActive(false);
            }
        }
    }*/
}
