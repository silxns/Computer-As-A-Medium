using UnityEngine;

public class HealthPack : MonoBehaviour
{
    public PlayerHealth playerHealth;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && playerHealth.health < 100)
        {
            playerHealth.health = playerHealth.health + 10;
            Destroy(gameObject);
        }
        else if (playerHealth.health == 100)
        {
            playerHealth.healthText.text = "Health: 100";
        }
    }
}

