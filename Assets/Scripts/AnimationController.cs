using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Searcher.SearcherWindow.Alignment;

public class AnimationController : MonoBehaviour
{
    [SerializeField] Animator animator; // 引用 Animator

    private bool isCKeyPressed = false; // 判断是否按下键位

    public float moveSpeed = 5f; // 角色移动速度

    public float runSpeed = 10f; // 奔跑速度

    //public float rotationSpeed = 360f; // 旋转速度

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // 移动部分
        // 获取WASD键的输入
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // 检查是否按下了Shift键
        bool ToRun = Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift);

        // 根据奔跑状态选择移动速度
        float speed = runSpeed ;


        // 根据输入方向计算移动向量
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        movement = movement.normalized * speed * Time.deltaTime;

        /*if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.Play("Jump");
        }*/

        if (Input.GetKeyDown(KeyCode.Space)) // 跳跃
        {
            animator.SetTrigger("ToJump");
        }

        if (Input.GetKeyDown(KeyCode.O)) // 死亡
        {
            animator.SetTrigger("Death");
        }

        if (Input.GetKeyDown(KeyCode.P)) // 复活
        {
            animator.SetTrigger("Reborn");
        }

        if (Input.GetKeyDown(KeyCode.Q)) // 左闪避
        {
            animator.SetTrigger("LeftDodge");
        }

        if (Input.GetKeyDown(KeyCode.X)) // 后闪避
        {
            animator.SetTrigger("BackDodge");
        }

        if (Input.GetKeyDown(KeyCode.F)) // 连携技
        {
            animator.SetTrigger("F!");
        }

        if (Input.GetKeyDown(KeyCode.Alpha2)) // 技能2
        {
            animator.SetTrigger("Skill2");
        }

        if (Input.GetKeyDown(KeyCode.Alpha3)) // 技能3
        {
            animator.SetTrigger("Skill3");
        }

        if (Input.GetKeyDown(KeyCode.Alpha4)) // 技能4
        {
            animator.SetTrigger("Skill4");
        }

        if (Input.GetKeyDown(KeyCode.Alpha5)) // 技能5
        {
            animator.SetTrigger("Skill5");
        }

        if (Input.GetKeyDown(KeyCode.Alpha6)) // 技能6
        {
            animator.SetTrigger("Skill6");
        }

        if (Input.GetKeyDown(KeyCode.Alpha7)) // 技能7
        {
            animator.SetTrigger("Skill7");
        }

        if (Input.GetKeyDown(KeyCode.Alpha8)) // 技能8
        {
            animator.SetTrigger("Skill8");
        }

        if (Input.GetKeyDown(KeyCode.E)) // 右闪避
        {
            animator.SetTrigger("RightDodge");
        }

        if (Input.GetMouseButtonDown(0))
        //if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            // 播放左键攻击动画
            animator.SetTrigger("AttackLeft");
        }

        if (Input.GetMouseButtonDown(1))
        {
            // 播放右键攻击动画
            animator.SetTrigger("AttackRight");
        }

        // 检测按下C键
        if (Input.GetKeyDown(KeyCode.C))
        {
            isCKeyPressed = true;
            // 设置Animator中的布尔参数为true
            animator.SetBool("ToCrawl", isCKeyPressed);
        }

        // 检测松开C键
        if (Input.GetKeyUp(KeyCode.C))
        {
            isCKeyPressed = false;
            // 设置Animator中的布尔参数为false
            animator.SetBool("ToCrawl", isCKeyPressed);
        }

        // 检测按下Z键
        if (Input.GetKeyDown(KeyCode.Z))
        {
            isCKeyPressed = true;
            // 设置Animator中的布尔参数为true
            animator.SetBool("ToSet", isCKeyPressed);
        }

        // 检测松开Z键
        if (Input.GetKeyUp(KeyCode.Z))
        {
            isCKeyPressed = false;
            // 设置Animator中的布尔参数为false
            animator.SetBool("ToSet", isCKeyPressed);
        }

        // 检测按下V键
        if (Input.GetKeyDown(KeyCode.V))
        {
            isCKeyPressed = true;
            // 设置Animator中的布尔参数为true
            animator.SetBool("ToDance", isCKeyPressed);
        }

        // 检测松开V键
        if (Input.GetKeyUp(KeyCode.V))
        {
            isCKeyPressed = false;
            // 设置Animator中的布尔参数为false
            animator.SetBool("ToDance", isCKeyPressed);
        }

        // 检测按下1键
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            isCKeyPressed = true;
            // 设置Animator中的布尔参数为true
            animator.SetBool("Definse", isCKeyPressed);
        }

        // 检测松开1键
        if (Input.GetKeyUp(KeyCode.Alpha1))
        {
            isCKeyPressed = false;
            // 设置Animator中的布尔参数为false
            animator.SetBool("Definse", isCKeyPressed);
        }

        // 检测按下Tab键
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            isCKeyPressed = true;
            // 设置Animator中的布尔参数为true
            animator.SetBool("Change", isCKeyPressed);
        }

        // 检测松开Tab键
        if (Input.GetKeyUp(KeyCode.Tab))
        {
            isCKeyPressed = false;
            // 设置Animator中的布尔参数为false
            animator.SetBool("Change", isCKeyPressed);
        }

        // 检测按下R键
        if (Input.GetKeyDown(KeyCode.R))
        {
            isCKeyPressed = true;
            // 设置Animator中的布尔参数为true
            animator.SetBool("Skill7-2", isCKeyPressed);
        }

        // 检测松开R键
        if (Input.GetKeyUp(KeyCode.R))
        {
            isCKeyPressed = false;
            // 设置Animator中的布尔参数为false
            animator.SetBool("Skill7-2", isCKeyPressed);
        }

        // 将移动向量应用到角色位置上
        transform.Translate(movement);

        // 如果有输入移动，则播放walk动画
        if (movement.magnitude > 0)
        {
            animator.SetBool("ToWalk", true);

            // 计算并设置角色朝向
            // Quaternion targetRotation = Quaternion.LookRotation(movement); // 朝向会反
            // Quaternion targetRotation = Quaternion.LookRotation(-movement);
            // transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, 0.15f);

            // 计算新的前向方向
            // Quaternion newDirection = Quaternion.LookRotation(movement);
            // 平滑旋转到新方向
            // transform.rotation = Quaternion.Slerp(transform.rotation, newDirection, Time.deltaTime * moveSpeed);

        }
        else
        {
            animator.SetBool("ToWalk", false);
        }

        //检测按住Shift键
        if (Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.RightShift))
        {
            isCKeyPressed = true;
            // 设置Animator中的布尔参数为true
            animator.SetBool("ToRun", isCKeyPressed);
        }

        // 检测松开Shift键
        if (Input.GetKeyUp(KeyCode.LeftShift) || Input.GetKeyUp(KeyCode.RightShift))
        {
            isCKeyPressed = false;
            // 设置Animator中的布尔参数为false
            animator.SetBool("ToRun", isCKeyPressed);
        }

    }
    /*
    private void FixedUpdate()
    {
        //获取移动方向
        Vector3 movementDirection = rb.velocity.normalized;
        if (movementDirection != Vector3.zero)
        {
            //旋转移动方向
            Quaternion newroatation = Quaternion.LookRotation(movementDirection);   
            rb.MoveRotation(Quaternion.RotateTowards(transform.rotation,newroatation,rotationSpeed * Time.deltaTime));
        }
    }*/
   

}
