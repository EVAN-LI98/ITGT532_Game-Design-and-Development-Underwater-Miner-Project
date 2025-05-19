using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Searcher.SearcherWindow.Alignment;

public class AnimationController : MonoBehaviour
{
    [SerializeField] Animator animator; // ���� Animator

    private bool isCKeyPressed = false; // �ж��Ƿ��¼�λ

    public float moveSpeed = 5f; // ��ɫ�ƶ��ٶ�

    public float runSpeed = 10f; // �����ٶ�

    //public float rotationSpeed = 360f; // ��ת�ٶ�

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // �ƶ�����
        // ��ȡWASD��������
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // ����Ƿ�����Shift��
        bool ToRun = Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift);

        // ���ݱ���״̬ѡ���ƶ��ٶ�
        float speed = runSpeed ;


        // �������뷽������ƶ�����
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        movement = movement.normalized * speed * Time.deltaTime;

        /*if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.Play("Jump");
        }*/

        if (Input.GetKeyDown(KeyCode.Space)) // ��Ծ
        {
            animator.SetTrigger("ToJump");
        }

        if (Input.GetKeyDown(KeyCode.O)) // ����
        {
            animator.SetTrigger("Death");
        }

        if (Input.GetKeyDown(KeyCode.P)) // ����
        {
            animator.SetTrigger("Reborn");
        }

        if (Input.GetKeyDown(KeyCode.Q)) // ������
        {
            animator.SetTrigger("LeftDodge");
        }

        if (Input.GetKeyDown(KeyCode.X)) // ������
        {
            animator.SetTrigger("BackDodge");
        }

        if (Input.GetKeyDown(KeyCode.F)) // ��Я��
        {
            animator.SetTrigger("F!");
        }

        if (Input.GetKeyDown(KeyCode.Alpha2)) // ����2
        {
            animator.SetTrigger("Skill2");
        }

        if (Input.GetKeyDown(KeyCode.Alpha3)) // ����3
        {
            animator.SetTrigger("Skill3");
        }

        if (Input.GetKeyDown(KeyCode.Alpha4)) // ����4
        {
            animator.SetTrigger("Skill4");
        }

        if (Input.GetKeyDown(KeyCode.Alpha5)) // ����5
        {
            animator.SetTrigger("Skill5");
        }

        if (Input.GetKeyDown(KeyCode.Alpha6)) // ����6
        {
            animator.SetTrigger("Skill6");
        }

        if (Input.GetKeyDown(KeyCode.Alpha7)) // ����7
        {
            animator.SetTrigger("Skill7");
        }

        if (Input.GetKeyDown(KeyCode.Alpha8)) // ����8
        {
            animator.SetTrigger("Skill8");
        }

        if (Input.GetKeyDown(KeyCode.E)) // ������
        {
            animator.SetTrigger("RightDodge");
        }

        if (Input.GetMouseButtonDown(0))
        //if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            // ���������������
            animator.SetTrigger("AttackLeft");
        }

        if (Input.GetMouseButtonDown(1))
        {
            // �����Ҽ���������
            animator.SetTrigger("AttackRight");
        }

        // ��ⰴ��C��
        if (Input.GetKeyDown(KeyCode.C))
        {
            isCKeyPressed = true;
            // ����Animator�еĲ�������Ϊtrue
            animator.SetBool("ToCrawl", isCKeyPressed);
        }

        // ����ɿ�C��
        if (Input.GetKeyUp(KeyCode.C))
        {
            isCKeyPressed = false;
            // ����Animator�еĲ�������Ϊfalse
            animator.SetBool("ToCrawl", isCKeyPressed);
        }

        // ��ⰴ��Z��
        if (Input.GetKeyDown(KeyCode.Z))
        {
            isCKeyPressed = true;
            // ����Animator�еĲ�������Ϊtrue
            animator.SetBool("ToSet", isCKeyPressed);
        }

        // ����ɿ�Z��
        if (Input.GetKeyUp(KeyCode.Z))
        {
            isCKeyPressed = false;
            // ����Animator�еĲ�������Ϊfalse
            animator.SetBool("ToSet", isCKeyPressed);
        }

        // ��ⰴ��V��
        if (Input.GetKeyDown(KeyCode.V))
        {
            isCKeyPressed = true;
            // ����Animator�еĲ�������Ϊtrue
            animator.SetBool("ToDance", isCKeyPressed);
        }

        // ����ɿ�V��
        if (Input.GetKeyUp(KeyCode.V))
        {
            isCKeyPressed = false;
            // ����Animator�еĲ�������Ϊfalse
            animator.SetBool("ToDance", isCKeyPressed);
        }

        // ��ⰴ��1��
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            isCKeyPressed = true;
            // ����Animator�еĲ�������Ϊtrue
            animator.SetBool("Definse", isCKeyPressed);
        }

        // ����ɿ�1��
        if (Input.GetKeyUp(KeyCode.Alpha1))
        {
            isCKeyPressed = false;
            // ����Animator�еĲ�������Ϊfalse
            animator.SetBool("Definse", isCKeyPressed);
        }

        // ��ⰴ��Tab��
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            isCKeyPressed = true;
            // ����Animator�еĲ�������Ϊtrue
            animator.SetBool("Change", isCKeyPressed);
        }

        // ����ɿ�Tab��
        if (Input.GetKeyUp(KeyCode.Tab))
        {
            isCKeyPressed = false;
            // ����Animator�еĲ�������Ϊfalse
            animator.SetBool("Change", isCKeyPressed);
        }

        // ��ⰴ��R��
        if (Input.GetKeyDown(KeyCode.R))
        {
            isCKeyPressed = true;
            // ����Animator�еĲ�������Ϊtrue
            animator.SetBool("Skill7-2", isCKeyPressed);
        }

        // ����ɿ�R��
        if (Input.GetKeyUp(KeyCode.R))
        {
            isCKeyPressed = false;
            // ����Animator�еĲ�������Ϊfalse
            animator.SetBool("Skill7-2", isCKeyPressed);
        }

        // ���ƶ�����Ӧ�õ���ɫλ����
        transform.Translate(movement);

        // ����������ƶ����򲥷�walk����
        if (movement.magnitude > 0)
        {
            animator.SetBool("ToWalk", true);

            // ���㲢���ý�ɫ����
            // Quaternion targetRotation = Quaternion.LookRotation(movement); // ����ᷴ
            // Quaternion targetRotation = Quaternion.LookRotation(-movement);
            // transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, 0.15f);

            // �����µ�ǰ����
            // Quaternion newDirection = Quaternion.LookRotation(movement);
            // ƽ����ת���·���
            // transform.rotation = Quaternion.Slerp(transform.rotation, newDirection, Time.deltaTime * moveSpeed);

        }
        else
        {
            animator.SetBool("ToWalk", false);
        }

        //��ⰴסShift��
        if (Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.RightShift))
        {
            isCKeyPressed = true;
            // ����Animator�еĲ�������Ϊtrue
            animator.SetBool("ToRun", isCKeyPressed);
        }

        // ����ɿ�Shift��
        if (Input.GetKeyUp(KeyCode.LeftShift) || Input.GetKeyUp(KeyCode.RightShift))
        {
            isCKeyPressed = false;
            // ����Animator�еĲ�������Ϊfalse
            animator.SetBool("ToRun", isCKeyPressed);
        }

    }
    /*
    private void FixedUpdate()
    {
        //��ȡ�ƶ�����
        Vector3 movementDirection = rb.velocity.normalized;
        if (movementDirection != Vector3.zero)
        {
            //��ת�ƶ�����
            Quaternion newroatation = Quaternion.LookRotation(movementDirection);   
            rb.MoveRotation(Quaternion.RotateTowards(transform.rotation,newroatation,rotationSpeed * Time.deltaTime));
        }
    }*/
   

}
