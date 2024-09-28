
using UnityEngine;

public class ChessController : MonoBehaviour
{
    private ChessPiece selectedPiece = null; // Quan co dc chon

    [SerializeField] private LayerMask pieceLayer; // Layer quan co
    [SerializeField] private LayerMask boardLayer; // Layer ban co 
    [SerializeField] private ChessPiece[,] board = new ChessPiece[8,8] ;

    private void Update() {
        if (Input.GetMouseButtonDown(0)){ // Kien tra chot trai dc bam k

        // Lay vi tri cua chuot tren man hinh 
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        // Neu chua co quan nao dc chon , kiem tra viec chon quan co 
        if (selectedPiece == null){

            if (Physics.Raycast(ray , out hit , Mathf.Infinity , pieceLayer)){

                ChessPiece piece = hit.collider.GetComponent<ChessPiece>();

                // Neu la quan co hop le
                if (piece != null && piece.isWhite ) { // Kiem tra mau quan co (trang or den)
                    selectedPiece = piece;
                    Debug.Log ("Quan co dc chon " + selectedPiece.name);
                }
                else {
                    Debug.Log ("K co quan co nao dc chon");
                }
            }
        }

        // Neu da co quan co dc chon , kiem tra viec chon o co de di chuyen 
        else{
            if (Physics.Raycast(ray,out hit , Mathf.Infinity , boardLayer)){

                // Lay vi tri cua o da dc chon
                Vector3 targetPos = hit.point;
                Vector2Int boardPos = new Vector2Int (Mathf.RoundToInt (targetPos.x ) , Mathf.RoundToInt (targetPos.z)); // Sd truc x ,z tren ban co 

                // Kiem tra xem nc di hop le k 
                if (selectedPiece.isMoveValid(boardPos , board)){
                    MovePiece(selectedPiece , boardPos); // di chuyen quan co neu hop le 
                }
                selectedPiece = null ; // Bo chon quan co sau khi di chuyen 
            }
        }

    }
}

    // Ham di chuyen quan co 
    private void MovePiece (ChessPiece piece , Vector2Int targetPos){
        // Cap nhat vi tri cua quan co trong mang co 
        board[piece.currentPos.x , piece.currentPos.y] = null; // xoa vi tri cu 
        board[targetPos.x , targetPos.y] = piece; // Dat quan co vi tri moi 

        // Cap nhat vi tri tren ban co 
        piece.transform.position = new Vector3 (targetPos.x , 0 , targetPos.y); // di chuyen quan co trong khong gian 3D
        piece.currentPos = targetPos; // cap nhat toa do ban co 

    }

}
