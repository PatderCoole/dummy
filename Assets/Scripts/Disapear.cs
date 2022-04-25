using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disapear : MonoBehaviour
{

    public float duration = 3f;
    float counter = 0;
    public Color green;
    public Color yellow;
    public Color red;
    

    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(true);
        //CubeMaterial = Resources.Load<Material>("TestMat");
        //MeshRenderer meshRenderer = GetComponent<MeshRenderer>();
        //Material oldMaterial = meshRenderer.material;
        //Debug.Log("Applied Material: " + oldMaterial.name);
        //meshRenderer.material = CubeMaterial;
    }

    // Update is called once per frame
    void Update()
    {

        if(counter > 0)
        {
            verschwinden();
        }

        if(counter >= duration * 0.5)
        {
            GetComponent<MeshRenderer>().material.color = yellow;
        }

        if (counter >= duration * 0.8 )
        {
            GetComponent<MeshRenderer>().material.color = red;
        }

        if (counter >= duration)
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
            GetComponent<MeshRenderer>().material.color = green;
        }
    }

    void verschwinden()
    {
        counter += Time.deltaTime;
    }
}
