using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float playerSpeed;
    private Rigidbody2D rb;
    private Vector2 playerDirection;

    bool Skin1Selected;
    bool Skin2Selected;
    bool Skin3Selected;
    bool Skin4Selected;

    public GameObject Skin1;
    public GameObject Skin2;
    public GameObject Skin3;
    public GameObject Skin4;

    // Start is called before the first frame update
    void Start()
    {
        Skin1Selected = SelectedSkin.Skin1Selected;
        Skin2Selected = SelectedSkin.Skin2Selected;
        Skin3Selected = SelectedSkin.Skin3Selected;
        Skin4Selected = SelectedSkin.Skin4Selected;
        if (Skin1Selected == true)
        {
            Skin1.SetActive(true);
            Skin2.SetActive(false);
            Skin3.SetActive(false);
            Skin4.SetActive(false);
        }
        if (Skin2Selected == true)
        {
            Skin1.SetActive(false);
            Skin2.SetActive(true);
            Skin3.SetActive(false);
            Skin4.SetActive(false);
        }
        if (Skin3Selected == true)
        {
            Skin1.SetActive(false);
            Skin2.SetActive(false);
            Skin3.SetActive(true);
            Skin4.SetActive(false);
        }
        if (Skin4Selected == true)
        {
            Skin1.SetActive(false);
            Skin2.SetActive(false);
            Skin3.SetActive(false);
            Skin4.SetActive(true);
        }

        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float directionY = Input.GetAxisRaw("Vertical");
        playerDirection = new Vector2(0, directionY).normalized;
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(0, playerDirection.y * playerSpeed);
    }
}
