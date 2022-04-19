using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Winning : MonoBehaviour
{

    public string nextLevel;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        The_Death_Situation plr = collision.gameObject.GetComponent<The_Death_Situation>();
        if (plr != null)
        {
            SceneManager.LoadScene(nextLevel);
        }
    }
}
