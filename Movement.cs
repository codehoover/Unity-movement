using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    private Animator _animator;

    public float MaxSpeed = 0;


    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>(); // on startup get the animator
    }

    // Update is called once per frame
    void Update()
    {
        if (_animator == null) return; // if animator isn't loaded return

        var x = Input.GetAxis("Horizontal");
        var y = Input.GetAxis("Vertical");

        Move(x,y); //calling move subroutine  
    }

    private void Move(float x, float y)
    {
        _animator.SetFloat("Input x", x);
        _animator.SetFloat("Input y", y);

        transform.position += (Vector3.forward * MaxSpeed) * y * Time.deltaTime; // for y position
        transform.position += (Vector3.right * MaxSpeed) * x * Time.deltaTime; // for x position
        //continously added to our position
    }
}
