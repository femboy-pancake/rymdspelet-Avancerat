using UnityEngine;

public class ChooseFIghter : MonoBehaviour
{
    public GameObject Playership;

    public void OnButtonClick(ShipTemplate ShipType)
    {

        Playership.GetComponent<PlayerScript>().playership = ShipType;




    }

}
