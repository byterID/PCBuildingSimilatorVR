using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Progress : MonoBehaviour//год обджект хули
{
    public static Progress Instance;

    //Железки
    [SerializeField] private GameObject[] _ram;

    //Сокеты для железяк
    [SerializeField] private GameObject _coolerSocket, _motherboardSocket, _gpuSocket, _diskSocket, _powerSuplySocket;
    [SerializeField] private GameObject[] _ramSocket;

    //Для оперативы
    public int _ramCount = 0;

    //Для телека
    [SerializeField] private string[] _stringList;
    [SerializeField] private GameObject _taskPrefab;
    [SerializeField] private Color _color, _activeColor;
    [SerializeField] private Transform _content;
    private List<GameObject> _tasksList = new List<GameObject>();
    private int _progressIndex = 0;

    private void Awake()
    {
        if(Instance == null)
            Instance = this;
    }

    private void Start()
    {
        for (int i = 0; i < _stringList.Length; i++)
        {
            InstantiateTasks(i);
        }
        _tasksList[_progressIndex].GetComponent<Image>().color = _activeColor;
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
        _tasksList[_progressIndex].GetComponent<Image>().color = _color;
        _progressIndex++;
        _tasksList[_progressIndex].GetComponent<Image>().color = _activeColor;
    }
    
    public void RevialRamSocket()
    {
        for (int i = 0; i < _ramSocket.Length; i++)
        {
            _ramSocket[i].SetActive(true);
        }
        ChangeTask();
    }
    public void RevialCoolerSocket()
    {
        ChangeTask();
        _coolerSocket.SetActive(true);
        _ramCount = 0;
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
        SceneManager.LoadScene(0);
    }
}
