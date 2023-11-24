using TMPro;
using UnityEngine;

public class Exam : MonoBehaviour
{

    [SerializeField] private TMP_Text _nameText;

    [SerializeField] private float _time;
    [SerializeField] private float _bestTime;
    private bool _examStarted = false;
    [SerializeField] private TMP_Text _timerText;

    private void Start()
    {
        if (PlayerPrefs.HasKey("username"))
        {
            _nameText.text = PlayerPrefs.GetString("username");
            Debug.Log("There is save data!");
        }
        else
            Debug.LogError("There is no save data!");

        
    }

    private void Update()
    {
        TimerCount();
        _timerText.text = _time.ToString("0.0") + " сек";
    }

    private void TimerCount()
    {
        if (_examStarted)
            _time += Time.deltaTime;
    }

    public void StartExam()
    {
        _examStarted = true;
    }
}
