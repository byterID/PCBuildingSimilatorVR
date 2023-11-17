using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakGlass : MonoBehaviour
{
    [SerializeField] private GameObject _brokenGlass;

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(this.gameObject);
        _brokenGlass.SetActive(true);
    }
}
