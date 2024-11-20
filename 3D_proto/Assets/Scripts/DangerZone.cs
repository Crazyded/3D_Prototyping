using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DangerZone : MonoBehaviour
{
    [SerializeField] private LayerMask playerMask;
    [SerializeField] private GameObject killerPrefab;
    [SerializeField] private Transform killerSpawnPoint;
    [SerializeField] private bool isOneShot;
    private int _shotCount;
    private int _maxShotCount = 1;
    private void OnTriggerEnter(Collider other)
    {
        if (LayerMaskUtil.ContainsLayer(playerMask, other.gameObject.layer))
        {
            if (isOneShot && _shotCount < _maxShotCount || !isOneShot)
            Instantiate(killerPrefab, killerSpawnPoint);
            _shotCount++;
        }
    }
}
