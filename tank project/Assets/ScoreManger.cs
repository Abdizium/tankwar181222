using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class ScoreManger : MonoBehaviour
{

    public TextMeshProUGUI scoretext;
    // Start is called before the first frame update
    int dificulty;
    public GameObject buttons;
    private void Start()
    {
        
        Time.timeScale = 1;
        PlayerPrefs.SetInt("Score",0);
        PlayerPrefs.SetInt("DIF", 0);
    }
    // Update is called once per frame
    void Update()
    {
        int score = PlayerPrefs.GetInt("Score");// getting the scored value 
        scoretext.text = score.ToString();// displaying value on
       
        
    }

    public void Restart()
    {
        
        SceneManager.LoadScene("1");

    }
    public void easy()
    {
        PlayerPrefs.SetInt("DIF", 0);
        buttons.SetActive(false);
    }
    public void medium()
    {
        PlayerPrefs.SetInt("DIF", 1);
        buttons.SetActive(false);
    }

    public void difi()
    {
        PlayerPrefs.SetInt("DIF", 2);
        buttons.SetActive(false);
    }

    




}
