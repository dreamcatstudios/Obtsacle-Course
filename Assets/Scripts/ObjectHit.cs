using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private MeshRenderer meshRenderer;

    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.CompareTag("Player")) return;

        if (CompareTag("Hit"))
        {
            HandleHitCollision();
        }
        else if (CompareTag("End"))
        {
            HandleEndCollision();
        }
    }

    private void HandleHitCollision()
    {
        GameManager.Instance.LoseLife();
        ChangeColor(Color.red);
    }

    private void HandleEndCollision()
    {
        GameManager.Instance.WinGame();
        ChangeColor(Color.green);
    }

    private void ChangeColor(Color newColor)
    {
        meshRenderer.material.color = newColor;
    }
}