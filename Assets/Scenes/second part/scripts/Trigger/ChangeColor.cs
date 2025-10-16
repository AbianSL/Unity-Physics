using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    private Renderer objectRenderer;
    private Color olderColor;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        objectRenderer = GetComponent<Renderer>();
        olderColor = objectRenderer.material.color; 
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ColorChanger"))
        {
            objectRenderer.material.color = new Color(Random.value, Random.value, Random.value); 
        }
    }
    
    private void OnTriggerExit(Collider other)
    {
        Debug.Log(other.tag);
        if (other.CompareTag("ColorChanger"))
        {
            Debug.Log(other.tag);
            objectRenderer.material.color = olderColor;
        }
    }
}
