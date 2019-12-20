using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneCtrl : MonoBehaviour
{


    public void ChangeScene(int SceneIndex)

    {
        SceneManager.LoadScene(SceneIndex);
    }



}
