using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FruitManager : MonoBehaviour
{
    public Text levelCleared;

    private void Update()
    {
        AllFruitsCollected();
    }

    public void AllFruitsCollected()
    {
        if (transform.childCount==1)
        {
            Debug.Log("nO QUEDAN MAS FRUTAS AS GANADO");
            levelCleared.gameObject.SetActive(true);
           Invoke("ChangeScene", 1);
        }
    }

    void ChangeScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
