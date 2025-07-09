using UnityEngine;

public class Move2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    Vector3 target = new Vector3(8, 0, 0);
    // Update is called once per frame
    void Update()
    {
        //Vector3 : Ŭ�������� �����ϴ� �̵� �Լ�

        //1. MoveTowards : ����̵�
        // �Ű������� (������ġ, ��ǥ��ġ, �ӵ�)�� ����
        // ������ �ӵ��� ���
        transform.position =
            Vector3.MoveTowards(transform.position,
            target, 0.5f);

        //2. SmoothDamp
        // �Ű������� (������ġ, ��ǥ��ġ, �����ӵ�, �ӵ�)�� ����
        // ������ �ӵ��� �ݺ��
        Vector3 velo = Vector3.zero;

        transform.position =
            Vector3.SmoothDamp(transform.position,
            target, ref velo, 0.1f);

        //3. Lerp : ��������, SmoothDamp���� ���ӽð��� ��
        transform.position =
            Vector3.Lerp(transform.position, target, 0.05f);

        //4. SLerp : ���鼱������, ȣ�� �׸��� �̵�
        transform.position =
            Vector3.Slerp(transform.position, target, 0.05f);

        //5. DeltaTime
        // ���� �������� �Ϸ���� �ɸ� �ð�
        //�������� ������ ũ��, �������� ������ ����
        Vector3 vec = new Vector3(
            Input.GetAxisRaw("Horizontal") * Time.deltaTime,
            Input.GetAxisRaw("Vertical") * Time.deltaTime, 0);

        transform.Translate(vec);
    }
}
