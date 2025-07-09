using UnityEngine;

public class Move : MonoBehaviour
{
    void Update()
    {
        if (Input.anyKeyDown)
        {
            Debug.Log("�÷��̾ �ƹ� Ű�� �������ϴ�.");
        }

        if (Input.anyKey)
        {
            Debug.Log("�÷��̾ �ƹ� Ű�� ������ �ֽ��ϴ�.");
        }


        //Ű����
        //GetKey : Ű���� ��ư �Է��� ������ true
        // GetKeyDown - ��������
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("�������� �����Ͽ����ϴ�.");
        }
        // GetKey - ������������
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("�������� �̵� ��");
        }
        // GetKeyUp - ������
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            Debug.Log("������ �̵��� ���߾����ϴ�");
        }

        //���콺
        //GetMouse : ���콺 ��ư �Է� ������ true
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("�̻��� �߻�!");
        }
        if (Input.GetMouseButton(0))
        {
            Debug.Log("�̻��� ������ ��...");
        }
        if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("���۹̻��� �߻�!");
        }

        // Input Manager
        // GetButton : Input ��ư �Է� ������ true
        if (Input.GetButtonDown("Jump"))
        {
            Debug.Log("����!");
        }
        if (Input.GetButton("Jump"))
        {
            Debug.Log("���� ������ ��...");
        }
        if (Input.GetButtonUp("Jump"))
        {
            Debug.Log("���� ����!");
        }

        //GetAxis: ����, ���� ��ư �Է��� ������ float
        //GetAxisRaw: ����ġ ���� �ٷ� -1 or 1
        if (Input.GetButton("Horizontal"))
        {
            Debug.Log("Ⱦ �̵� ��..." + Input.GetAxisRaw("Horizontal"));
        }
        if (Input.GetButton("Vertical"))
        {
            Debug.Log("�� �̵� ��..." + Input.GetAxisRaw("Vertical"));
        }


        //Transform : ������Ʈ ���¿� ���� �⺻ ������Ʈ
        //������Ʈ�� ���� transform�� �׻� ������ ����
        Vector3 vec = new Vector3(Input.GetAxis("Horizontal")
            , Input.GetAxis("Vertical"), 0); //���� ��
        //Translate : ���� ���� ���� ��ġ�� ���ϴ� �Լ�
        transform.Translate(vec);


    }


    void Start()
    {
        
    }
    
}
