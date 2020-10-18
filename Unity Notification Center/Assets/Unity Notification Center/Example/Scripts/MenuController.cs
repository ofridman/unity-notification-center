using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace AxlPlay
{
    public class MenuController : MonoBehaviour
    {


        #region UI Events
        public void Click_StartGame()
        {
            NotificationCenter.DefaultCenter.PostNotification(this, "GameStarted");


        }
        public void Click_PauseGame()
        {
            NotificationCenter.DefaultCenter.PostNotification(this, "GamePaused");

        }

        public void Click_ResumeGame()
        {
            NotificationCenter.DefaultCenter.PostNotification(this, "GameResumed");

        }
        #endregion
    }
}