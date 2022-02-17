using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    [SerializeField] public int speed;
    [SerializeField] public int health = 50;
    [SerializeField] public float jumpIntensity = 10f; 
    public int timer = 30;
    public int gameOverTimer;
    public int level = 1;
    [SerializeField] private Text timerText;
    [SerializeField] private Text levelText;
    [SerializeField] private Text winText;
    [SerializeField] private GameObject healthBar;
    public GameObject pauseMenuUI;
    public GameObject resumeMenuUI;
    public GameObject mainMenuUI;
    public static bool MainMenuIsOn = true;

    // Start is called before the first frame update
    void Start()
    {
        speed = PlayerPrefs.GetInt("PlayerSpeed", 10);
        health = PlayerPrefs.GetInt("PlayerHealth", 50);
        level = PlayerPrefs.GetInt("level", 1);
        if(MainMenuIsOn == true)
            GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>().enabled = false;
        else
            GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>().enabled = true;

        if (level > 1)
        {
            mainMenuUI.SetActive(false);
            resumeMenuUI.SetActive(true);
            GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>().enabled = true;
            levelText.text = "Level: " + level;
            StartCoroutine("CountDown");
        }
    }

    IEnumerator CountDown()
    {
        while(timer > 0)
        {
            timerText.text = "Timer: " + timer;
            // wait for 1 second
            yield return new WaitForSeconds(1);
            timer--;
        }
        //pause the player, load the UI message
        
        GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody>().isKinematic = true;
        GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>().enabled = false;
        winText.text = "Level " + level + " completed!";
        yield return new WaitForSeconds(2);
        ChangeLevel();
    }

        private void ChangeLevel()
    {
        PlayerPrefs.SetInt("PlayerSpeed", speed + 5);
        PlayerPrefs.SetInt("PlayerHealth", health);
        PlayerPrefs.SetInt("level", level + 1);
        SceneManager.LoadScene((SceneManager.GetActiveScene().buildIndex + 1) % 3);
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.transform.localScale = new Vector3(health / 50f, healthBar.transform.localScale.y, healthBar.transform.localScale.z);
        if (health <= 0)
            GameOver();
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
        GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>().enabled = false;
        resumeMenuUI.SetActive(false);
        pauseMenuUI.SetActive(true);

    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>().enabled = true;
        resumeMenuUI.SetActive(true);
        pauseMenuUI.SetActive(false);

    }

    public void StartGame()
    {
        mainMenuUI.SetActive(false);
        MainMenuIsOn = false;
        resumeMenuUI.SetActive(true);
        GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>().enabled = true;
        levelText.text = "Level: " + level;
        winText.text = "";
        StartCoroutine("CountDown");
    }

    public void QuitGame()
    {
        Debug.Log("GAME OVER!!");
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }

    public void GameOver()
    {
        MainMenuIsOn = true;
        GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>().enabled = false;
        Invoke("Restart", 3);
        Restart();
    }

    public void Restart()
    {
        SceneManager.LoadScene("GameClass 3");
    }

    private void OnApplicationQuit()
    {
        PlayerPrefs.DeleteKey("PlayerHealth");
        PlayerPrefs.DeleteKey("PlayerSpeed");
        PlayerPrefs.DeleteKey("level");

    }
}
