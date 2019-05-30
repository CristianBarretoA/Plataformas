using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class over : MonoBehaviour
{

    public GameObject gameOvertext;
    public static GameObject gameOverStatic;

    // Start is called before the first frame update
    void Start()
    {
        over.gameOverStatic = gameOvertext;
        over.gameOverStatic.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void show()
    {
        over.gameOverStatic.gameObject.SetActive(true);
    }
}
