using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] Transform barellPosition;
    [SerializeField] GameObject bulletPrefab;
    
    public void Shoot(Vector2 direction){        
        GameObject _projectile = Instantiate(bulletPrefab, barellPosition.position, Quaternion.identity); 
        _projectile.GetComponent<Bullet>().Init(direction);
    }

}
