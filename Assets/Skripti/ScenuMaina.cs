using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenuMaina : MonoBehaviour
{ 
    //sak speli
    public void SaktSpeli() {
        SceneManager.LoadScene("Pilseta", LoadSceneMode.Single);
    }
    //restarte speli
    public void restartetSpeli()
    {
        SceneManager.LoadScene("Pilseta", LoadSceneMode.Single);
    }

}
