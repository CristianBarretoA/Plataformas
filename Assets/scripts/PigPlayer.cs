using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PigPlayer : MonoBehaviour
{

    Rigidbody2D pig;
    public float maxVel;
    Animation pigAnim;

    //Girar personaje
    bool girarPig = true;
    SpriteRenderer pigRender;

    bool puedeMover = true;

    //Saltar
    bool enSuelo = false;
    float chequearRadioSuelo = 0.2f;
    public LayerMask capaSuelo;
    public Transform chequearSuelo;
    public float poderSalto;

    public GameObject gameOver;

    // Start is called before the first frame update
    void Start()
    {
        pig = GetComponent<Rigidbody2D>();
        pigRender = GetComponent<SpriteRenderer>();
        pigAnim = GetComponent<Animation>();
        Debug.Log("Hello");
    }

    // Update is called once per frame
    void Update()
    {

        if (puedeMover && enSuelo && Input.GetAxis("Jump") > 0)
        {
            pig.velocity = new Vector2(pig.velocity.x, 0);
            pig.AddForce(new Vector2(0, poderSalto), ForceMode2D.Impulse);
            enSuelo = false;
        }

        enSuelo = Physics2D.OverlapCircle(chequearSuelo.position, chequearRadioSuelo, capaSuelo);

        float mover = Input.GetAxis("Horizontal");

        if (puedeMover)
        {
            if (mover > 0 && !girarPig)
            {
                girar();
            }
            else if (mover < 0 && girarPig)
            {
                girar();
            }

            pig.velocity = new Vector2(mover * maxVel, pig.velocity.y);

        }
        else
        {
            pig.velocity = new Vector2(0, pig.velocity.y);
        }
    }

    void girar()
    {
        girarPig = !girarPig;
        pigRender.flipX = !pigRender.flipX;
    }

    public void togglePuedeMover()
    {
        puedeMover = !puedeMover;
    }

    //private void OnCollisionEnter(Collision collision)
    //{
    //    Debug.Log("Collided" + collision.gameObject.name);
    //    //if (collision.gameObject.name == "Cube")
    //    //{
    //    //    Debug.Log("Collition Detected");
    //    //    Destroy(collision.gameObject);
    //    //}
    //}




}
