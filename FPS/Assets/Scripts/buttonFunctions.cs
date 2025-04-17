using System.ComponentModel;
using UnityEngine;
using UnityEngine.SceneManagement;


public class buttonFunctions : MonoBehaviour
{
    public void resume()
    {
        gamemanager.instance.stateUnpause();
    }

    public void restart() //this is lazy and you should never do this when creating a game
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        gamemanager.instance.stateUnpause();
    }

    public void quit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

    public void increaseHP(int cost)
    {
        if (gamemanager.instance.currency >=cost)
        {
            gamemanager.instance.playerScript.HP += 1;
            gamemanager.instance.currency -= cost;
        }
        
    }

} 