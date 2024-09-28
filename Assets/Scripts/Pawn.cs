


using UnityEngine;

public class Pawn : ChessPiece
{
    [SerializeField] private bool isFirstMove = true; // Bien kiem tra nc di dau tien

    // Ham kiem tra nc di hop le cho Tot

    public override bool isMoveValid(Vector2Int targetPos, ChessPiece[,] boradState)
    {
        int direction = isWhite ? 1 : -1 ; // Tot trang di len , tot den di xuong 
        int startRow = isWhite ? 1 : 6  ; // Hang bat dau cua tot trang va den 
        int endRow = isWhite ? 7 : 0 ; // Hang cuoi cung phong cap 

        // Di chuyen 1 o len phia trc 
        if (targetPos.y == currentPos.y  + direction && targetPos.x == currentPos.x){
            // Kiem tra neu o den k co quan can 
            if (boradState[targetPos.x , targetPos.y ] == null){
                isFirstMove = false ; // Cap nhat trang thai sau nc di dau 
                return true ;
            }
        }
        // Di chuyen 2 o nc dau tien
        if (isFirstMove && targetPos.y == currentPos.y + (2 * direction ) && targetPos.x == currentPos.x){

            // Kiem tra neu ca 2 o deu k co quan can 
            if (boradState[targetPos.x , targetPos.y ] == null && boradState [targetPos.x , currentPos.y + direction] == null){
                isFirstMove = false ;
                return true;
            }
        }

        // Bat quan theo duong cheo n
        if (targetPos.y == currentPos.y + direction && Mathf.Abs (targetPos.x - currentPos.x) == 1){
            if (boradState[targetPos.x , targetPos.y] != null && IsOpponentPiece (boradState[targetPos.x , targetPos.y])){
                return true ;
            }
        }

        // Phong cap neu tot den hang cuoi
        if (targetPos.y == endRow ){
            PromotePawn( targetPos , boradState);
            return true ;

        }
        return false ;


    }
    private void PromotePawn (Vector2Int targetPos , ChessPiece[,] pieces){
        // Chon loai co de phong cap 
        Debug.Log ("Da phong Hau");
    }

}
