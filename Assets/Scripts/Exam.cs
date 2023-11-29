using TMPro;
using UnityEngine;

public class Exam : MonoBehaviour
{

    [SerializeField] private TMP_Text _nameText;

    [SerializeField] private float _time;
    [SerializeField] private float _bestTime;
    private bool _examStarted = false;
    [SerializeField] private TMP_Text _timerText;
    [SerializeField] private TMP_Text _bestTimerText;

    [SerializeField] private GameObject _endExamPanel;

    private void Start()
    {
        if (PlayerPrefs.HasKey("username"))
        {
            _nameText.text = PlayerPrefs.GetString("username");
        }
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

    public void ExamEnd()
    {   
        _examStarted = false;
        _bestTimerText.text = _time.ToString();

    }
}
