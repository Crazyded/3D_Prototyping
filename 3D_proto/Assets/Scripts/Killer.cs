using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Killer : MonoBehaviour
{
    [SerializeField] private LayerMask playerMask;
    [SerializeField] private LayerMask groundMask;
    private bool _isgrounded;

    private void OnCollisionEnter(Collision collision)
    {
        if (LayerMaskUtil.ContainsLayer(groundMask, collision.gameObject.layer))
        {
            _isgrounded = true;
        }

        if (LayerMaskUtil.ContainsLayer(playerMask, collision.gameObject.layer))
        {
            if (!_isgrounded)
            {
                SceneManager.LoadScene("SampleScene");
            }
        }
    }
}
