; ================================
; Задача 9.5
; Намиране на индекса на първия ненулев елемент в масив, 
; съдържащ 32-битови целочислени числа.
;---------------------------------
;   С-спецификация:
;---------------------------------
;   int size = 6;
;   int array[] = {100,200,300,400,500,600};
;   void main(void) {   
;       for(i=0; i<size; i++) {  
;           if (array[i] != 0) {
;               break;
;           }
;       }
;       if (i == size) {
;           printf("Not found\n");
;       } else {
;           printf("Result=%d\n", i);
;       }
;   }
;---------------------------------


;======= СЕГМЕНТ ДАННИ =============
    .data

    ; Масив
;Array:  .word 100,200,300,400,500,600 
;Array:  .word 0,0,300,400,500,600 
;Array:  .word 0,0,0,0,0,600 
Array:  .word 0,0,0,0,0,0 
Size:   .word 6 

    ; Параметрична област ------
Par:    .space  4
    ; Резултат ------
Result: .space  4

    ; Форматиращ стринг
FrmStr: .asciiz "Result=%d\n"   
    ; Стринг за ненамерен елемент
StrNotFound: .asciiz "Not found\n"   

;======= КОДОВ СЕГМЕНТ ==============
    .text

    ; TODO:
    
;------------------------------------
Found:
    addi r14, r0, FrmStr
    sw  Par(r0), r14
    j Display
    
NotFound:
    addi r14, r0, StrNotFound
    sw  Par(r0), r14 
    
Display:    
    lhi r14, Par >> 16      ; старша полудума
    addui r14, r14, Par & 0xFFFF    ; младша полудума
    trap 5              ; printf()
    trap 0              ; т.пр.
    
    