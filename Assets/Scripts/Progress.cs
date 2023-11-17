using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Threading.Tasks;
using Unity.VisualScripting;

public class Progress : MonoBehaviour
{
    [SerializeField] private GameObject _taskPrefab;
    [SerializeField] private GameObject[] _socketPlaces;
    [SerializeField] private string[] _stringList;
    [SerializeField] private Transform _content;
    [SerializeField] private List<GameObject> _tasksList = new List<GameObject>();

    private TMP_Text _text;
    private Image _image;

    public int _progress = 0;
    [SerializeField] private Color _color, _activeColor;
    private void Start()
    {
        _text = GetComponent<TMP_Text>();
        _image = GetComponent<Image>();

        for (int i = 0; i < _stringList.Length; i++)
        {
            InstantiateTasks(i);
        }
        _tasksList[_progress].GetComponent<Image>().color = _activeColor;
    }


    private void InstantiateTasks(int i)
    {
        GameObject task = Instantiate(_taskPrefab, transform.position,transform.rotation);
        task.transform.SetParent(_content);
        task.transform.localScale = new Vector3(1, 1, 1);
        task.GetComponentInChildren<TMP_Text>().text = _stringList[i];
        _tasksList.Add(task);
    }

    public void ChangeTask()
    {
        _tasksList[_progress].GetComponent<Image>().color = _color;
        _progress++;
        _tasksList[_progress].GetComponent<Image>().color = _activeColor;
    }
}
