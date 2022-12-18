using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HealthBar : MonoBehaviour
{
    public Image healthBarImage;
    public Player player;

    public void UpdateHealthBar()
    {
        healthBarImage.fillAmount = Mathf.Clamp(player.health / player.maxHealth, 0, 1f);
    }


    public class Player : MonoBehaviour
    {
        public float health, maxHealth;
        public HealthBar healthBar;
        public void TakeDamage()
        {
            // Use your own damage handling code, or this example one.
            health -= Mathf.Min(Random.value, health / 4f);
            healthBar.UpdateHealthBar();
        }
        void Update()
        {
            // Example so we can test the Health Bar functionality
            if (Input.GetKeyDown(KeyCode.Space))
            {
                TakeDamage();
            }
        }
    }
}