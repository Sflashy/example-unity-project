using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillPlayer : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("collieded");
        SceneManager.LoadScene("Main");
    }
}
