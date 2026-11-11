using UnityEngine;

public class Trap : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public GameObject Surprise;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Surprise.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            playerHealth.health -= 10;
            Surprise.SetActive(true);
        }
    }
}
