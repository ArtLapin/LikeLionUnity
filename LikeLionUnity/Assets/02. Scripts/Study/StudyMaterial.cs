using UnityEngine;

public class StudyMaterial : MonoBehaviour
{
    public Material mat;
    public string hexCode;

    void Start()
    {
        //this.GetComponent<Material>() = mat; // Material�� �ٲٴ� ��� X

        //this.GetComponent<MeshRenderer>().sharedmaterial = mat; // MeshRenderer�� �����ؼ� �ٲٴ� ���

        //this.GetComponent<MeshRenderer>().material.color = Color.green;

        //this.GetComponent<MeshRenderer>().sharedMaterial.color = Color.green;

        //this.GetComponent<MeshRenderer>().materials //material�� ������ ���� ��

        //this.GetComponent<MeshRenderer>().material.color = new Color(200f, 137f, 70f, 255f);

        mat =  this.GetComponent<MeshRenderer>().material;
        Color outputcolor;

        if (ColorUtility.TryParseHtmlString(hexCode, out outputcolor))
        {
            mat.color = outputcolor; // Material�� ������ ����
        }
    }


}