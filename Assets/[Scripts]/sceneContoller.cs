/*
 *                    CRIMINAL CATS
 *                    Author: Negar Saeidi
 *                    Student number : 101261396
 *                    Date last modified: 9/25/2021
 *                    Rivision history: 1st version : 5 functions added for listening to the action of pressing each button
 *                        --**onGameOverButton function added to test the transition from main game scene to the game over scene**--            
 *                                      
 *                    Name of this Script: sceneController: transition between scenes
 *                    
 *                    
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class sceneContoller : MonoBehaviour
{

    public void onStartButton()
    {
        SceneManager.LoadScene("Main");
    }
    public void onTutorialButton()
    {
        SceneManager.LoadScene("Tutorial");
    }
    public void onBackButton()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void onPlayAgainButton()
    {
        SceneManager.LoadScene("Main");
    }
    public void onMainMenuButton()
    {
        SceneManager.LoadScene("MainMenu");
    }
    //Test
    public void onGameOverButton()
    {
        SceneManager.LoadScene("GameOver");
    }
}






