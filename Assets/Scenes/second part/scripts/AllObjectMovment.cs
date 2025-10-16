using UnityEngine;

public class AllObjectMovment : MonoBehaviour
{
    public float force = 10;
    private GameObject[] allObjects;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        allObjects = GameObject.FindGameObjectsWithTag("Force"); 
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.X))
        {
            foreach (GameObject obj in allObjects)
            {
                Rigidbody rb = obj.GetComponent<Rigidbody>();
                if (obj.name == "Bouncing")
                {
                    rb?.AddForce(Vector3.up * force);
                }
                rb?.AddForce(Vector3.right * force);
            }
        }
    }
}
