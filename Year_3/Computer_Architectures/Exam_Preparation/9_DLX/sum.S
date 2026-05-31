; ================================
; Задача 9.3
; Събиране на масив, съдържащ 32-битови целочислени числа 
; чрез използване на относителна регистрова адресация за достъп до елементите на масива
;---------------------------------
;   С-спецификация:
;---------------------------------
;   int size = 6;
;   int array[] = {100,200,300,400,500,600};
;   int sum = 0;  
;   void main(void) {
;       for(i=0; i<size; i++) {  
;           sum = sum + array[i];  
;       }
;       printf("Result=%d\n", sum);
;   }
;---------------------------------

;======= СЕГМЕНТ ДАННИ =============
    .data

    ; Масив
Array:  .word 100,200,300,400,500,600 
Size:   .word 6 

    ; Форматиращ стринг
FrmStr: .asciiz "Result=%d\n"   
    .align 2
    ; Параметрична област ------
Par:    .word FrmStr
    ; Резултат ------
Result: .space      4

;======= КОДОВ СЕГМЕНТ ==============
    .text

    	; TODO:
	; R1 - index i
	; R2 - sum
	; R3 - size

	ADDI R2, R0, 0		; int sum = 0
	ADDI R1, R0, 0		; i = 0
	LW R3, Size		; R3 = size
Loop:
	SRLI R5, R1, 2		; R5 = R1 / 4 (деление на 4 = изместване надясно с 2 бита)
	SLT R4, R1, R3		; i < size
	BEQZ R4, Finish		; изход от цикъла
	LW R4, Array(R1)	; R4 = array[i]
	ADD R2, R2, R4		; sum = sum + array[i]
	ADDI R1, R1, 4		; i++
	J Loop
Finish:
	SW Result, R2

;------------------------------------
    lhi r14, Par >> 16      ; старша полудума
    addui r14, r14, Par & 0xFFFF    ; младша полудума
    trap 5              ; printf()

    trap 0              ; т.пр.