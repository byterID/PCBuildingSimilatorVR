using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Progress : MonoBehaviour
{
    //чтоб рестартать
    [SerializeField] Transform _instantiateTransform;
    [SerializeField] private GameObject _pcLearningPrefab;

    //Железки
    [SerializeField] private GameObject[] _ram;

    //Сокеты для железяк
    [SerializeField] private GameObject _coolerSocket, _motherboardSocket, _gpuSocket, _diskSocket, _powerSuplySocket;
    [SerializeField] private GameObject[] _ramSocket;

    //Для оперативы
    public int _ramCount = 0;

    //Для телека
    [SerializeField] private GameObject _taskPrefab;
    [SerializeField] private string[] _stringList;
    [SerializeField] private Transform _content;
    private List<GameObject> _tasksList = new List<GameObject>();
    private int _progress = 0;
    [SerializeField] private Color _color, _activeColor;

    private void Start()
    {
        for (int i = 0; i < _stringList.Length; i++)
        {
            InstantiateTasks(i);
        }
        _tasksList[_progress].GetComponent<Image>().color = _activeColor;
    }

    private void Update()
    {
        RevialCoolerSocket();
    }

    private void InstantiateTasks(int i)
    {
        GameObject task = Instantiate(_taskPrefab, transform.position,transform.rotation);
        task.transform.SetParent(_content);
        task.transform.localScale = new Vector3(1, 1, 1);
        task.GetComponentInChildren<TMP_Text>().text = _stringList[i];
        _tasksList.Add(task);
    }

    private void ChangeTask()
    {
        _tasksList[_progress].GetComponent<Image>().color = _color;
        _progress++;
        _tasksList[_progress].GetComponent<Image>().color = _activeColor;
    }
    
    public void RevialRamSocket()
    {
        for (int i = 0; i < _ramSocket.Length; i++)
        {
            _ramSocket[i].SetActive(true);
        }
        ChangeTask();
    }
    private void RevialCoolerSocket()
    {
        if (_ramCount == 4)
        {
            ChangeTask();
            _coolerSocket.SetActive(true);
            _ramCount = 0;
        }
    }
    public void RevialPowerSuplySocket()
    {
        _powerSuplySocket.SetActive(true);
        ChangeTask();
    }
    public void RevialDiskSocket()
    {
        _diskSocket.SetActive(true);
        ChangeTask();
    }
    public void RevialMotherboardSocket()
    {
        _motherboardSocket.SetActive(true);
        ChangeTask();
    }

    public void RevialGPUSocket()
    {
        _gpuSocket.SetActive(true);
        ChangeTask();
    }

    public void Restart()
    {
        _progress = 0;
    }
}
