using UnityEngine;

[CreateAssetMenu(fileName = "ShipTemplate", menuName = "Scriptable Objects/ShipTemplate")]
public class ShipTemplate : ScriptableObject
{
    public string shipName;
    public float moveSpeed;
    public int health;
    public Sprite shipSprite;
    public float ShootSpeed;

}
