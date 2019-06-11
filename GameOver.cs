using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameOver : MonoBehaviour
{

  public static bool Dead = false;
  public GameObject gameOverUI;
  public float status;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    { GameObject g = GameObject.Find("PlayerState");
      PlayerState script = g.GetComponent<PlayerState>();
      status = script.PlayerHealth;
      if (status <= 0)
      {
        Over();

      } else
      {
        Alive();
      }



  }
  public void Over()
  {
    gameOverUI.SetActive(true);
    Time.timeScale = 0f;
    Dead = true;

  }
  void Alive()
  {
    gameOverUI.SetActive(false);
    Dead = false;
  }
  public void Restart()
{
  SceneManager.LoadScene(SceneManager.GetActiveScene().name);
  Time.timeScale = 1f;

}
  public void LoadMenu()
  {
    Time.timeScale = 1f;
    SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);

  }
  public void Quit(){
  Application.Quit();
}
}
