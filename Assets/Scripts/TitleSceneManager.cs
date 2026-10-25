using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;


public class TitleSceneManager : MonoBehaviour

{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Title");
    }
    public void Play()
    {
        SceneManager.LoadScene("asdasdas");
    }
    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void Exit()
    {
        Application.Quit();
    }




  



}
