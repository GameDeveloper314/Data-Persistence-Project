using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuUIHandler : MonoBehaviour
{
    public TMP_Text InputField, NameAndScoreText;

    void Start()
    {
        UpdateNameAndScore();
    }
    
    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }

    public void PersistentName()
    {
        PersistentData.Instance.Name = InputField.text;
    }

    public void UpdateNameAndScore()
    {
        NameAndScoreText.text = "Name: " + PersistentData.Instance.Name + ", High Score: " + PersistentData.Instance.HighScore;
    }
}
