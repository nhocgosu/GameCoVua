

using UnityEngine;


public abstract class ChessPiece : MonoBehaviour
{
   public bool isWhite; // Xac dinh mau sac quan co 

   public abstract bool isMoveValid (Vector3 targetPos , ChessPiece[,] boradState); // Kiem tra tinh hop le cua nc di

   public virtual void MoveTo (Vector3 targetPos ){
    // Di chuyen  quan co 
    transform.position = targetPos;
   }

   private void OnMouseDown() {
    ChessGameManager gameManager = FindObjectOfType<ChessGameManager>();
    if (gameManager != null) {
        gameManager.SelectedPiece(this);
    }
   }

}
