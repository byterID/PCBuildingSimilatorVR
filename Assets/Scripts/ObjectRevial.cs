using UnityEngine;

public class ObjectRevial : MonoBehaviour
{
    [SerializeField] private GameObject[] _socket;

    public void ActivateSocket()
    {
        for (int i = 0; i < _socket.Length; i++)
        {
            _socket[i].SetActive(true);
        }
    }
}
