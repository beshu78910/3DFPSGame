using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    // Start is called before the first frame update
    PlayerHealth target;
    [SerializeField] private float damage = 40f;
    private AudioSource attackSound;

 void Start()
 {
     target = FindObjectOfType<PlayerHealth>();
     attackSound = GetComponent<AudioSource>();
 }
 public void OnDamageTaken()
 {
     Debug.Log(name + "I also know what we took damage");
 }
 public void AttackHitEvent()
 {
     if (target == null) return;
     target.TakeDamage(damage);
     target.GetComponent<DisplayDamage>().ShowDamageImpact();
     attackSound.Play();
 }
 
}
