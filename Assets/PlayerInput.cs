using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] Transform weaponRotationPoint;
    Mover mover;
    Shooter shooter;
    private void Awake() {
        mover = GetComponent<Mover>();
        shooter = GetComponent<Shooter>();
        
    }
    void Update()
    {
        Vector3 _mouseWorldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 _direction = (_mouseWorldPosition - weaponRotationPoint.position).normalized;
         float _weaponRotation = Mathf.Atan2(_direction.y, _direction.x) * Mathf.Rad2Deg;
         weaponRotationPoint.rotation = Quaternion.Euler(0, 0, _weaponRotation);

        Vector3 _newDirection = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0);
        mover.Move(_newDirection);

        if(Input.GetMouseButtonDown(0)){
            shooter.Shoot(_direction);
        }
    }
}
