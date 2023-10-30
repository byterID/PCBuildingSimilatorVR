using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRevial : MonoBehaviour
{
    [SerializeField] private GameObject _socket;
    [SerializeField] private GameObject _item;

    private void Start()
    {
        _item = this.gameObject;
    }

    public void ActivateSocket()
    {
        _socket.SetActive(true);
    }
}
