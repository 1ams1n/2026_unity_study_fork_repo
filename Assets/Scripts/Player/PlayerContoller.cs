using System.Security.Permissions;
using UnityEngine;

// 플레이어 입력을 처리하는 클래스
// 키보드 입력 -> Spawner / TrapDoor로 전달
public class PlayerContoller : MonoBehaviour
{
    private bool isInputEnabled = true; // 입력 가능 여부 변수

    public Spawner spawner;         // 연결된 스포너
    public TrapDoor trapDoor;       // 트랩 도어

    public KeyCode leftKey;             // 좌 이동
    public KeyCode rightKey;            // 우 이동
    public KeyCode dropKey;             // 드롭 키
    public KeyCode trapDoorKey;         // 트랩도어 키

    float dir = 0f;

    // 이동 입력 처리
    public void HandleMoveInput() 
    {
        dir = 0f; // 변수 초기화

        if (Input.GetKey(leftKey) == true) // 왼쪽 키 입력 시 방향 지정
        {
            dir = -1f;
        }
        else if (Input.GetKey(rightKey) == true) // 오른쪽 키 입력 시 방향 지정
        {
            dir = 1f;
        }

        spawner.Move(dir);
    }

    // 드롭 입력 처리
    public void HandleDropInput() // 드롭 키 입력 시 오브젝트 드롭
    {
        if (Input.GetKeyDown(dropKey) == true)
        {
            spawner.Drop();
        }
    }

    public void HandleTrapDoorInput() 
    {
        if (Input.GetKeyDown(trapDoorKey) == true) // 트랩도어 키 입력 시 트랩도어 여닫기
        {
            trapDoor.Toggle();
        }
    }

    // 입력 비활성화 ( 게임오버 시 )
    public void DisableInput() 
    {
        isInputEnabled = false;
    }

    void Update() // isInputEnabled가 true인 동안에는 위의 세 함수들이 돌아가며 게임 진행
    {
        if (isInputEnabled == false)
        {
            return;
        }

        HandleMoveInput();
        HandleDropInput();
        HandleTrapDoorInput();
    }
}