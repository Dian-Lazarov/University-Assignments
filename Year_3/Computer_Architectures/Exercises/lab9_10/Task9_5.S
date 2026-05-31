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
	; R1 - index i
	; R3 - size

	ADDI R1, R0, 0		; i = 0
	LW R3, Size		; R3 = size
Loop:
	SRLI R5, R1, 2		; R5 = R1 / 4 (деление на 4 = изместване надясно с 2 бита)
	SLT R4, R1, R3		; i < size
	BEQZ R4, Finish		; изход от цикъла

	LW R2, Array(R1)
	SNEI R5, R2, 0
	BNEZ R5, Found

	ADDI R1, R1, 4		; i++
	J Loop
Finish:
	J NotFound
    
;------------------------------------
Found:
    SW Result, R2
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
    
    