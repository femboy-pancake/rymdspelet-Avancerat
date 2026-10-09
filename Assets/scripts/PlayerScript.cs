using UnityEngine;

public class PlayerScript : MonoBehaviour
{

    public ShipTemplate playership;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
  




    public void Update()
    {

        if (Input.GetKey(KeyCode.D))
        {

            transform.Translate(Vector2.right * playership.moveSpeed * Time.deltaTime);

        }



        if (Input.GetKey(KeyCode.A))
        {

            transform.Translate(Vector2.left * playership.moveSpeed * Time.deltaTime);

        }



        if (Input.GetKey(KeyCode.W))
        {

            transform.Translate(Vector2.up * playership.moveSpeed * Time.deltaTime);

        }




        if (Input.GetKey(KeyCode.S))
        {

            transform.Translate(Vector2.down * playership.moveSpeed * Time.deltaTime);

        }

    }
}
