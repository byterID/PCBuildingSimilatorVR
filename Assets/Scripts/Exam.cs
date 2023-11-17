using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Exam : MonoBehaviour
{
    [SerializeField] private string _name;

    [SerializeField] private float _time;
    [SerializeField] private float _bestTime;
    [SerializeField] private bool _examStarted = false;
    [SerializeField] private TMP_Text _timerText;

    private void Start()
    {
        _timerText.text = _time.ToString();
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
