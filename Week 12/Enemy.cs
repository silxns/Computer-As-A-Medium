using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{
    public int enemyHealth = 10;
    public GameObject EnemyDeathText;
    private bool isDead = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Death();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Weapon"))
        {
            enemyHealth -= 10;
        }
    }

    void Death()
    {
        if (enemyHealth <= 0 && isDead == false)
        {
            isDead = true;
            StartCoroutine(BeforeDeath());
        }
    }
    IEnumerator BeforeDeath()
    {
        EnemyDeathText.SetActive(true);
        yield return new WaitForSeconds(1f);
        EnemyDeathText.SetActive(false);
        Destroy(gameObject);
    }
}