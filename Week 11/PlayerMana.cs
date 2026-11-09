using UnityEngine;
using TMPro;
using UnityEngine.InputSystem;

public class PlayerMana : MonoBehaviour
{
    public int mana = 50;
    public TMP_Text manaText;
    public GameObject Sword;
    public GameObject Wand;
    public Animator animator;
    public PlayerMana playerMana;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        manaText.text = "Mana: " + mana;
        Wand.SetActive(false);
        Sword.SetActive(false);
       
    }

    // Update is called once per frame
    void Update()
    {
        manaText.text = "Mana: " + mana;

        Cast();
    }

    void Cast()
    {
        if (Keyboard.current.cKey.isPressed && mana > 0)
        {
            animator.SetBool("cast", true);
        }
        else
        {
            animator.SetBool("cast", false);
        }
        if (Keyboard.current.cKey.wasPressedThisFrame && mana > 0)
        {
            playerMana.mana -= 10;
            Sword.SetActive(false);
            Wand.SetActive(true);
        }
        else if (Keyboard.current.fKey.wasPressedThisFrame)
        {
            Wand.SetActive(false);
            Sword.SetActive(true);
        }
    }
}
