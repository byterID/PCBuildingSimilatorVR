using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Progress : MonoBehaviour
{
    [SerializeField] private GameObject _taskPrefab;
    [SerializeField] private string[] _taskList;

    private TMP_Text _text;
    private Image _image;

    private void Start()
    {
        _text = GetComponent<TMP_Text>();
        _image = GetComponent<Image>();
    }


}
