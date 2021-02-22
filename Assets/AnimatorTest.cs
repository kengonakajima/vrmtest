using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorTest : MonoBehaviour
{
    private Animator anim;
    private AnimatorStateInfo currentState;


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        currentState = anim.GetCurrentAnimatorStateInfo(0);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("up")) {
            anim.SetBool("Next", true);
        }

        //前へ
        if (Input.GetKeyDown("down")) {
            anim.SetBool("Back", true);
        }

        //状態遷移時に初期化
        AnimatorStateInfo state = anim.GetCurrentAnimatorStateInfo(0);
        if (currentState.nameHash != state.nameHash) {
            currentState = state;
            anim.SetBool("Next", false);
            anim.SetBool("Back", false);
        }

    }
}
