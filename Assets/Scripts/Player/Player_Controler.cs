using UnityEngine;

public class Player_Controler : MonoBehaviour
{
    public void Button1()
    {
        transform.position = new Vector3(0, 3.3f, 0);
        transform.rotation = Quaternion.Euler(-20, 0, 0);
    }
    public void Button2()
    {
        transform.position = new Vector3(-1.2f, 3.3f, 0);
        transform.rotation = Quaternion.Euler(-20, 0, 0);
    }
    public void Button3()
    {
        transform.position = new Vector3(1.13f, 3.3f, 0);
        transform.rotation = Quaternion.Euler(-20, 0, 0);
    }
    public void Button4()
    {
        transform.position = new Vector3(0,0.7f, 0);
        transform.rotation = Quaternion.Euler(0, 0, 0);
    }
    public void Button5()
    {
        transform.position = new Vector3(-1.4f, 0.7f, 0);
        transform.rotation = Quaternion.Euler(0, 0, 0);
    }
    public void Button6()
    {
        transform.position = new Vector3(1.35f, 0.7f, 0);
        transform.rotation = Quaternion.Euler(0, 0, 0);
    }
    public void Button7()
    {
        transform.position = new Vector3(0, -3.3f, 0);
        transform.rotation = Quaternion.Euler(0, 0, 0);
    }
    public void Button8()
    {
        transform.position = new Vector3(-1.6f, -3.3f, 0);
        transform.rotation = Quaternion.Euler(0, 0, 0);
    }
    public void Button9()
    {
        transform.rotation = Quaternion.Euler(0, 0, 0);
        transform.position = new Vector3(1.6f, -3.3f, 0);
    }
}
