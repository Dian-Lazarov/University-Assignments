TITLE FPU Stack Engine Test		(Task8_2.asm)

; Програма за тестване на стека на FPU
; z = sqrt(x*x + y*y)

;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;
; РЕД НА РАБОТА
; 1. Асемблира се през меню Tools\Make32 на TextPad
; 2. Изпълнява се стъпково през меню Tools\WinDbg на TextPad
; 3. Съставя се стековата диаграма

INCLUDE \MASM615\INCLUDE\Irvine32.inc
INCLUDELIB \MASM615\LIB\Irvine32.lib

.data
floatX	REAL4	0.5
floatY	REAL4	1.2
floatZ	REAL4	?

.code
Main PROC
    ; TODO:



	mov		esi, OFFSET floatZ
	mov		ecx, LENGTHOF floatZ	; 1 item
	mov		ebx, TYPE floatZ	    ; 4 bytes/item
	call		DumpMem

	INVOKE Sleep, 3000

	INVOKE ExitProcess, NULL

Main ENDP
END Main