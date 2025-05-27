using UnityEngine;

public class StudyMaterial : MonoBehaviour
{
    public Material mat;
    public string hexCode;

    void Start()
    {
        //this.GetComponent<Material>() = mat; // Material을 바꾸는 방식 X

        //this.GetComponent<MeshRenderer>().sharedmaterial = mat; // MeshRenderer에 접근해서 바꾸는 방식

        //this.GetComponent<MeshRenderer>().material.color = Color.green;

        //this.GetComponent<MeshRenderer>().sharedMaterial.color = Color.green;

        //this.GetComponent<MeshRenderer>().materials //material이 여러개 있을 때

        //this.GetComponent<MeshRenderer>().material.color = new Color(200f, 137f, 70f, 255f);

        mat =  this.GetComponent<MeshRenderer>().material;
        Color outputcolor;

        if (ColorUtility.TryParseHtmlString(hexCode, out outputcolor))
        {
            mat.color = outputcolor; // Material의 색상을 변경
        }
    }


}