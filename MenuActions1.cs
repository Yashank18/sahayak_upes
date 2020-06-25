

using System.Collections;

using UnityEngine;

public class MenuActions1 : MonoBehaviour
{
    public void MENU_ACTION_gotopage(string sceneName)
    {
        Application.LoadLevel(sceneName);
    }
}
