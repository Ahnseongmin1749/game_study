using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    //���� ������Ʈ ���� ��, ���� ����
    void Awake()
    {
        Debug.Log("�÷��̾� �����Ͱ� �غ�Ǿ����ϴ�");
    }

    //���� ������Ʈ�� Ȱ��ȭ �Ǿ��� ��
    void OnEnable()
    {
        Debug.Log("�÷��̾ �α����߽��ϴ�.");    
    }

    //������Ʈ ���� ����, ���� ����
    void Start()
    {
        Debug.Log("��� ��� ì����ϴ�.");  
    }

    //���� ���� ������Ʈ - ������ ���� �ֱ�� CPU ���� ���
    void FixedUpdate()
    {
        Debug.Log("�̵�~");
    }

    //���� ���� ������Ʈ
    void Update()
    {
        Debug.Log("���� ���!!");
    }

    //��� ������Ʈ ���� ��
    void LateUpdate()
    {
        Debug.Log("����ġ ȹ��.");
    }

    //���� ������Ʈ�� ��Ȱ��ȭ �Ǿ��� ��
    void OnDisable()
    {
        Debug.Log("�÷��̾ �α׾ƿ��߽��ϴ�.");
    }

    //���� ������Ʈ�� ������ ��
    void OnDestroy()
    {
        Debug.Log("�÷��̾� �����͸� ��ü�Ͽ����ϴ�");
    }
}
