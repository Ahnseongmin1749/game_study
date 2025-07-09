using UnityEngine;

public class Move : MonoBehaviour
{
    void Update()
    {
        if (Input.anyKeyDown)
        {
            Debug.Log("플레이어가 아무 키를 눌렀습니다.");
        }

        if (Input.anyKey)
        {
            Debug.Log("플레이어가 아무 키를 누르고 있습니다.");
        }


        //키보드
        //GetKey : 키보드 버튼 입력을 받으면 true
        // GetKeyDown - 눌렀을때
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("아이템을 구입하였습니다.");
        }
        // GetKey - 누르고있을때
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("왼쪽으로 이동 중");
        }
        // GetKeyUp - 뗐을때
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            Debug.Log("오른쪽 이동을 멈추었습니다");
        }

        //마우스
        //GetMouse : 마우스 버튼 입력 받으면 true
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("미사일 발사!");
        }
        if (Input.GetMouseButton(0))
        {
            Debug.Log("미사일 모으는 중...");
        }
        if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("슈퍼미사일 발사!");
        }

        // Input Manager
        // GetButton : Input 버튼 입력 받으면 true
        if (Input.GetButtonDown("Jump"))
        {
            Debug.Log("점프!");
        }
        if (Input.GetButton("Jump"))
        {
            Debug.Log("점프 모으는 중...");
        }
        if (Input.GetButtonUp("Jump"))
        {
            Debug.Log("슈퍼 점프!");
        }

        //GetAxis: 수평, 수직 버튼 입력을 받으면 float
        //GetAxisRaw: 가중치 없이 바로 -1 or 1
        if (Input.GetButton("Horizontal"))
        {
            Debug.Log("횡 이동 중..." + Input.GetAxisRaw("Horizontal"));
        }
        if (Input.GetButton("Vertical"))
        {
            Debug.Log("종 이동 중..." + Input.GetAxisRaw("Vertical"));
        }


        //Transform : 오브젝트 형태에 대한 기본 컴포넌트
        //오브젝트는 변수 transform을 항상 가지고 있음
        Vector3 vec = new Vector3(Input.GetAxis("Horizontal")
            , Input.GetAxis("Vertical"), 0); //벡터 값
        //Translate : 벡터 값을 현재 위치에 더하는 함수
        transform.Translate(vec);


    }


    void Start()
    {
        
    }
    
}
