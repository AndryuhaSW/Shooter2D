using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] private Weapon _weapon;
    
    
    private Vector2 _pointerPosition;
    private bool _IsReadyToShoot = true;
    

    private void SetWeapon(Weapon weapon)
    {
        if (_weapon == weapon || weapon == null)
            return;
        _weapon = weapon;
    }
    
    private void OnPointerPosition(InputValue value)
    {
        _pointerPosition = value.Get<Vector2>();
    }
    
    private void OnAttack(InputValue value)
    {
        if (_IsReadyToShoot)
            StartCoroutine(Attack());
    }

    private IEnumerator Attack()
    {
        _IsReadyToShoot = false;
        
        StartCoroutine(_weapon.DoShoot(_pointerPosition));

        yield return new WaitForSeconds(_weapon.PrepareTime);
        
        _IsReadyToShoot = true;
        
        if (Mouse.current.leftButton.isPressed)
            StartCoroutine(Attack());
    }

}
