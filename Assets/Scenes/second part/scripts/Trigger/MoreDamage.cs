using UnityEngine;

public class MoreDamage : MonoBehaviour
{
    public long damage = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            damage += 1;
        }
    }
}
