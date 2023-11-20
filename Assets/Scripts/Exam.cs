using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Exam : MonoBehaviour
{
    public string _name;
    [SerializeField] private TMP_InputField _inputField;
    [SerializeField] private TMP_Text _nameText;

    [SerializeField] private float _time;
    [SerializeField] private float _bestTime;
    [SerializeField] private bool _examStarted = false;
    [SerializeField] private TMP_Text _timerText;

    private void Start()
    {
        _name = _inputField.text;
        _timerText.text = _time.ToString();
        _nameText.text = _name;
        _name = PlayerPrefs.GetString("username");
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

    public void SaveName()
    {
        PlayerPrefs.SetString("username", _name);
    }

    public void LoadMain()
    {
        SceneManager.LoadScene(0);
    }
}
