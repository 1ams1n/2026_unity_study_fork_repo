using UnityEngine;

// 원소의 레벨별 데이터 정보를 저장하는 클래스
// MergeManager, Spawner에서 원소 정보를 찾을 때 사용한다.
[System.Serializable]
public class ElementData
{
    // 원소 타입
    public ElementType elementType;

    // 원소 레벨
    public int level;

    // 생성할 원소 프리팹
    public GameObject prefab;

    // 원소 이미지
    public Sprite sprite;

    // 원소 질량
    public float mass = 1f;

    // 원소 크기
    public float scale = 1f;

    // 원소 점수
    public int score = 0;
}
