

using UnityEngine;


public abstract class ChessPiece : MonoBehaviour
{
   public bool isWhite; // Xac dinh mau sac quan co (trang hoac den)
   public Vector2Int currentPos; // Vi tri hien tai cua tren ban co (hang va cot)

   // Ham truu tuong de xac dinh cach di chuyen cua quan co , moi loai se co cach di chuyen rieng
   public abstract bool isMoveValid (Vector2Int targetPos , ChessPiece[,] boradState); // Kiem tra tinh hop le cua nc di

// Ham kiem tra xem co phai bat quan doi phuong k 
   public bool IsOpponentPiece (ChessPiece piece){

    return piece != null && piece.isWhite != this.isWhite;
   }
}
