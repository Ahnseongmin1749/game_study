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
        //Vector3 : 클래스에서 제공하는 이동 함수

        //1. MoveTowards : 등속이동
        // 매개변수는 (현재위치, 목표위치, 속도)로 구성
        // 마지막 속도에 비례
        transform.position =
            Vector3.MoveTowards(transform.position,
            target, 0.5f);

        //2. SmoothDamp
        // 매개변수는 (현재위치, 목표위치, 참조속도, 속도)로 구성
        // 마지막 속도에 반비례
        Vector3 velo = Vector3.zero;

        transform.position =
            Vector3.SmoothDamp(transform.position,
            target, ref velo, 0.1f);

        //3. Lerp : 선형보간, SmoothDamp보다 감속시간이 김
        transform.position =
            Vector3.Lerp(transform.position, target, 0.05f);

        //4. SLerp : 구면선형보간, 호를 그리며 이동
        transform.position =
            Vector3.Slerp(transform.position, target, 0.05f);

        //5. DeltaTime
        // 이전 프레임의 완료까지 걸린 시간
        //프레임이 적으면 크고, 프레임이 많으면 작음
        Vector3 vec = new Vector3(
            Input.GetAxisRaw("Horizontal") * Time.deltaTime,
            Input.GetAxisRaw("Vertical") * Time.deltaTime, 0);

        transform.Translate(vec);
    }
}
