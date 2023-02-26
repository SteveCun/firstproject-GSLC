using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gantiscene : MonoBehaviour
{
    public void gantiscene(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }
}
