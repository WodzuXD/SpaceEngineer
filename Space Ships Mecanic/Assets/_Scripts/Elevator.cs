using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Elevator : MonoBehaviour
{

    public int sceneNumber;

    private void OnMouseDown()
    {
        SceneManager.LoadScene(sceneNumber);
    }
}
