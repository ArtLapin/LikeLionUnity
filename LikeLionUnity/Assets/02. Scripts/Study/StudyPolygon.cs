using UnityEngine;

public class StudyPolygon : MonoBehaviour
{
    
    void Start()
    {
        Mesh mesh = new Mesh();

        Vector3[] vetices = new Vector3[]
        {
            new Vector3(0, 0, 0),
            new Vector3(1, 0, 0),
            new Vector3(0, 1, 0),
            new Vector3(1, 1, 0)
        };

        int[] triangles = new int[]
        {
            0, 2, 1, 
            2, 3, 1  
        };

        Vector2[] uv = new Vector2[]
        {
            new Vector2(0, 0),
            new Vector2(1, 0),
            new Vector2(0, 1),
            new Vector2(1, 1)
        };
        // Mesh에 점, 삼각형 순서, UV 데이터를 적용
        mesh.vertices = vetices;
        mesh.triangles = triangles;
        mesh.uv = uv;
        //MeshFilter에 Mesh 데이터를 적용
        MeshFilter meshfilter = gameObject.AddComponent<MeshFilter>();
        meshfilter.mesh = mesh;
        // MeshRenderer에 Material을 적용
        MeshRenderer meshRenderer = gameObject.AddComponent<MeshRenderer>();
        meshRenderer.material = new Material(Shader.Find("Sprites/Default"));
    }
}
