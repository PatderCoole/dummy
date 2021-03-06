using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disapear : MonoBehaviour
{

    public float duration = 3f;
    public float respawn_duration = 3f;
    float counter = 0;
    float re_counter = 0;
    public Color healthy;
    public Color green;
    public Color yellow;
    public Color red;
    public GameObject plattform;
    
    public void PlatformOnEnable()
    {
        //plattform.GetComponent<MeshRenderer>().material.color = healthy;
        plattform.GetComponent<MeshRenderer>().material.SetColor("MyColor", healthy);
        plattform.GetComponent<MeshRenderer>().material.EnableKeyword("ENUM_STATE_DEFAULT");
        plattform.GetComponent<MeshRenderer>().material.DisableKeyword("ENUM_STATE_A");
        plattform.GetComponent<MeshRenderer>().material.DisableKeyword("ENUM_STATE_B");
        plattform.GetComponent<MeshRenderer>().material.DisableKeyword("ENUM_STATE_C");
    }

    // Start is called before the first frame update
    void Start()
    {
        plattform.GetComponent<GameObjectEventHandler>()._CollEnter += OnPlatformCollsionEnter;
        plattform.GetComponent<GameObjectEventHandler>()._Enable += PlatformOnEnable;
        plattform.GetComponent<GameObjectEventHandler>()._Start += PlatformOnEnable;

        plattform.SetActive(true);
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
            //plattform.GetComponent<MeshRenderer>().material.color = yellow;
            plattform.GetComponent<MeshRenderer>().material.SetColor("MyColor", yellow);
            plattform.GetComponent<MeshRenderer>().material.EnableKeyword("ENUM_STATE_B");
            plattform.GetComponent<MeshRenderer>().material.DisableKeyword("ENUM_STATE_A");
            plattform.GetComponent<MeshRenderer>().material.DisableKeyword("ENUM_STATE_C");
            plattform.GetComponent<MeshRenderer>().material.DisableKeyword("ENUM_STATE_DEFAULT");
        }

        if (counter >= duration * 0.8 )
        {
            //plattform.GetComponent<MeshRenderer>().material.color = red;
            plattform.GetComponent<MeshRenderer>().material.SetColor("MyColor", red);
            plattform.GetComponent<MeshRenderer>().material.EnableKeyword("ENUM_STATE_C");
            plattform.GetComponent<MeshRenderer>().material.DisableKeyword("ENUM_STATE_A");
            plattform.GetComponent<MeshRenderer>().material.DisableKeyword("ENUM_STATE_B");
            plattform.GetComponent<MeshRenderer>().material.DisableKeyword("ENUM_STATE_DEFAULT");
        }

        if (counter >= duration)
        {
            //Destroy(this.gameObject);
            re_counter += Time.deltaTime;
            counter = 0;
            plattform.SetActive(false);
            
        }

        if(re_counter > 0)
        {
           re_counter = re_counter + Time.deltaTime;
        }

        if(re_counter >= respawn_duration)
        {
            plattform.SetActive(true);
            re_counter = 0;
        }
               
    }

    void OnPlatformCollsionEnter(Collision collision)
    {
        Player_Movement temp = collision.gameObject.GetComponent<Player_Movement>();

        if (temp != null)
        {
            verschwinden();
            //plattform.GetComponent<MeshRenderer>().material.color = green;
            plattform.GetComponent<MeshRenderer>().material.SetColor("MyColor", green);
            plattform.GetComponent<MeshRenderer>().material.EnableKeyword("ENUM_STATE_A");
            plattform.GetComponent<MeshRenderer>().material.DisableKeyword("ENUM_STATE_C");
            plattform.GetComponent<MeshRenderer>().material.DisableKeyword("ENUM_STATE_B");
            plattform.GetComponent<MeshRenderer>().material.DisableKeyword("ENUM_STATE_DEFAULT");
        }
    }

    void verschwinden()
    {
        counter += Time.deltaTime;
    }

    

}
