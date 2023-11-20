using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    [SerializeField] private GameObject _learningTab;
    [SerializeField] private GameObject _practicingTab;
    [SerializeField] private GameObject _examTab;
    [SerializeField] private GameObject _settingsTab;

    public void ActiveLearning()
    {
        _learningTab.SetActive(true);
        _practicingTab.SetActive(false);
        _examTab.SetActive(false);
        _settingsTab.SetActive(false);  
    }
    public void ActivePractice()
    {
        _learningTab.SetActive(false);
        _practicingTab.SetActive(true);
        _examTab.SetActive(false);
        _settingsTab.SetActive(false);
    }
    public void ActiveExam()
    {
        _learningTab.SetActive(false);
        _practicingTab.SetActive(false);
        _examTab.SetActive(true);
        _settingsTab.SetActive(false);
    }
    public void ActiveSettings()
    {
        _learningTab.SetActive(false);
        _practicingTab.SetActive(false);
        _examTab.SetActive(false);
        _settingsTab.SetActive(true);
    }
}
