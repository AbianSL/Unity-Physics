using System.Linq;
using UnityEngine;

public class CollisionDetecter : MonoBehaviour
{

    private GameObject[] cubeArray;
    private GameObject[] sphereArray;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cubeArray = GameObject.FindGameObjectsWithTag("Cube");
        sphereArray = GameObject.FindGameObjectsWithTag("Sphere");
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if (cubeArray.Contains(collision.gameObject) || sphereArray.Contains(collision.gameObject))
        {
            Debug.Log("Collision detected between " + this.gameObject.name + " and " + collision.gameObject.name);
            Renderer rendererComponent = collision.gameObject.GetComponent<Renderer>();
            rendererComponent.material.color = new Color(Random.value, Random.value, Random.value); 
        }
    }
}
