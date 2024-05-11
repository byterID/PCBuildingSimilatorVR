using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Registration : MonoBehaviour
{
    public string Name;
    [SerializeField] private TMP_InputField _inputField;
    [SerializeField] private TMP_Text _text;

    public void SaveName()
    {
        Name = _inputField.text;
        _text.text = Name;
        PlayerPrefs.SetString("username", Name);
        PlayerPrefs.Save();
    }
    public void LoadMain()
    {
        SceneManager.LoadScene(0);
    }
}
