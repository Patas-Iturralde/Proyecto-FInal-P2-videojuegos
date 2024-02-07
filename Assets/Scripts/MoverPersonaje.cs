using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoverPersonaje : MonoBehaviour
{
    public float velocidadMov = 5.0f;
    public float velocidadRot = 200.0f;
    public float x, y;
    private Animator animator;
    public GameObject canvasGameOver;
    public GameObject camaraPrincipal;
    public GameObject camaraIntro;
    public GameObject intro;
    public GameObject Muerte;
    // Start is called before the first frame update
    void Start()
    {
        camaraPrincipal.SetActive(false);
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");
        transform.Rotate(0, x * Time.deltaTime * velocidadRot, 0);
        transform.Translate(0, 0, y * Time.deltaTime * velocidadMov);

        animator.SetFloat("VelX", x);
        animator.SetFloat("VelY", y);

        if (Input.GetKeyDown(KeyCode.X))
        {
            

            intro.SetActive(false);
            animator.SetBool("Levantarse", true);
            animator.SetBool("Movimiento", true);
            camaraIntro.SetActive(false);
            camaraPrincipal.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            // Reiniciar el juego
            Time.timeScale = 1;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        


    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemigo")
        {
            Debug.Log("Colision enemigo");
            Muerte.SetActive(true);
        }
    }

    }
