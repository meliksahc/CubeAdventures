using UnityEngine;

public class FreezeXPosition : MonoBehaviour
{
    public Transform targetObject; // Takip edilecek obje

    void Update()
    {
        
            // Takip edilecek objenin Y pozisyonunu al
            float targetY = targetObject.position.y;

            // Objeyi yeni pozisyon ile g�ncelle
            transform.position = new Vector3(transform.position.x, targetY, transform.position.z);

            // Sadece X ekseni �zerinde d�nd�rme
            transform.rotation = Quaternion.Euler(0f, transform.rotation.eulerAngles.y, transform.rotation.eulerAngles.z);
        
    }
}