using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuUIHandler : MonoBehaviour
{
    public TMP_Text InputField;
    
    public void Start()
    {
        LoadName();
    }

    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }

    public void SaveName()
    {
        PersistentData.Instance.Name = InputField.text;
        PersistentData.Instance.SaveName();
    }

    public void LoadName()
    {
        InputField.text = PersistentData.Instance.Name;
    }
}
