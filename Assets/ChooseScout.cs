using UnityEngine;

public class ChooseScout : MonoBehaviour
{
    public GameObject Playership;

    public void OnButtonClick(ShipTemplate Scout)
    {

        Playership.GetComponent<PlayerScript>().playership = Scout;




    }
}
