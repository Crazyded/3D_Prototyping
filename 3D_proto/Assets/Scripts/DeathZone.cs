using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathZone : MonoBehaviour
{
    [SerializeField] private LayerMask playerMask;

    private void OnTriggerEnter(Collider other)
    {
      if (LayerMaskUtil.ContainsLayer(playerMask, other.gameObject.layer))
      {
                SceneManager.LoadScene("SampleScene");
      }
    }
}
