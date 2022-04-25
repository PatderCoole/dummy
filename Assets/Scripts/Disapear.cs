using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disapear : MonoBehaviour
{

    public float duration = 3f;
    float counter = 0;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

        if(counter > 0)
        {
            verschwinden();
        }

        if(counter >= duration)
        {
            //Destroy(this.gameObject);
            gameObject.SetActive(false);
        }
               
    }

    private void OnCollisionEnter(Collision collision)
    {

        Player_Movement temp = collision.gameObject.GetComponent<Player_Movement>();

        if (temp != null)
        {
            verschwinden();
        }
    }

    void verschwinden()
    {
        counter += Time.deltaTime;
    }
}
