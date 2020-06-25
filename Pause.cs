using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool GameIsPaused = false;
    public Button buts;
    public GameObject pauseMenuUI;

    // Update is called once per frame
    void Update()
    {
    	Button but =buts.GetComponent<Button>();
    	
    	 but.onClick.AddListener(yes);
        
    }

    public void yes()
    {
    	if(GameIsPaused)
    	{
    		resume();
    	}
    	else
    	{
    		pause();
    	}
    }

   public void resume()
    {
    	pauseMenuUI.SetActive(false);
    	Time.timeScale=1;
    	GameIsPaused=false;

    }
    public void pause()
    {
    	pauseMenuUI.SetActive(true);
    	Time.timeScale=0f;
    	GameIsPaused=true;

    }


}
