using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Registration : MonoBehaviour
{
    public string _name;
    [SerializeField] private TMP_InputField _inputField;
    [SerializeField] private TMP_Text _text;

    public void SaveName()
    {
        _name = _inputField.text;
        _text.text = _name;
        PlayerPrefs.SetString("username", _name);
        PlayerPrefs.Save();
    }
    public void LoadMain()
    {
        SceneManager.LoadScene(0);
    }
}
