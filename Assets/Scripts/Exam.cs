using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Exam : Registration
{

    [SerializeField] private TMP_Text _nameText;

    [SerializeField] private float _time;
    [SerializeField] private float _bestTime;
    [SerializeField] private bool _examStarted = false;
    [SerializeField] private TMP_Text _timerText;

    private void Start()
    {
        if (PlayerPrefs.HasKey("username"))
        {
            _nameText.text = PlayerPrefs.GetString("username");
            Debug.LogError("There is save data!");
        }
        else
            Debug.LogError("There is no save data!");

        _timerText.text = _time.ToString();
        //_nameText.text = _name;
    }

    private void Update()
    {
        StartTimer();
    }

    private void StartTimer()
    {
        if (_examStarted)
            _time += Time.deltaTime;
        _examStarted = true;
    }
}
