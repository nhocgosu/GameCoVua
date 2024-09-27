
using Unity.VisualScripting;
using UnityEngine;

public class ChessBoardManager : MonoBehaviour
{
    [SerializeField] private GameObject[] kingPrefab;
   [SerializeField] private GameObject[] queenPrefab;
   [SerializeField] private GameObject[] rookPrefab;
  [SerializeField] private GameObject[] knightPrefab;
  [SerializeField] private GameObject[] bishopPrefab;
   [SerializeField] private GameObject[] pawnPrefab;
   private void Start(){
    SetupChessBoard();
   }

   private void SetupChessBoard (){
     PlacePiece(rookPrefab[0], new Vector3(0, 0, 0));   // Rook A1
        PlacePiece(knightPrefab[0], new Vector3(1, 0, 0));  // Knight B1
        PlacePiece(bishopPrefab[0], new Vector3(2, 0, 0));  // Bishop C1
        PlacePiece(queenPrefab[0], new Vector3(3, 0, 0));   // Queen D1
        PlacePiece(kingPrefab[0], new Vector3(4, 0, 0));    // King E1
        PlacePiece(bishopPrefab[0], new Vector3(5, 0, 0));  // Bishop F1
        PlacePiece(knightPrefab[0], new Vector3(6, 0, 0));  // Knight G1
        PlacePiece(rookPrefab[0], new Vector3(7, 0, 0));    // Rook H1

        PlacePiece(rookPrefab[1], new Vector3(0, 7, 0));   // Rook A8
        PlacePiece(knightPrefab[1], new Vector3(1, 7, 0));  // Knight B8
        PlacePiece(bishopPrefab[1], new Vector3(2, 7, 0));  // Bishop C8
        PlacePiece(queenPrefab[1], new Vector3(3, 7, 0));   // Queen D8
        PlacePiece(kingPrefab[1], new Vector3(4, 7, 0));    // King E8
        PlacePiece(bishopPrefab[1], new Vector3(5, 7, 0));  // Bishop F8
        PlacePiece(knightPrefab[1], new Vector3(6, 7, 0));  // Knight G8
        PlacePiece(rookPrefab[1], new Vector3(7, 7, 0));    // Rook H8

        for (int i = 0 ; i < 8 ; i++){
            PlacePiece(pawnPrefab[0] , new Vector3 (i,1,0));
            PlacePiece (pawnPrefab[1], new Vector3 (i ,6 ,0));
        }
   }

   private void PlacePiece (GameObject piecePrefab , Vector3 pos){
 GameObject piece =   Instantiate(piecePrefab , pos , Quaternion.identity);
 piece.transform.parent = transform;
    
   }

}
