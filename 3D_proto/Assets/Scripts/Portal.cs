using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Portal : MonoBehaviour
{
    [SerializeField] private LayerMask triggerLayerMask;
    [SerializeField] private Transform endPoint;

    private void OnTriggerEnter(Collider other)
    {
        if (LayerMaskUtil.ContainsLayer(triggerLayerMask, other.gameObject.layer))
        {
            other.transform.position = endPoint.position;
        }
    }
}
