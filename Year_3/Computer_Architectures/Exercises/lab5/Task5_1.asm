TITLE Task5_1     (Task5_1.asm)

; This program adds 32-bit integers.

INCLUDE Irvine32.inc
INCLUDE Macros.inc

.data

.code
main PROC
    ; TODO: Add 20000h and 789ABh
    	MOV EAX, 20000h
    	ADD EAX,789ABh
    	
    	showRegister EAX, eax

    ;call DumpRegs   ; display the registers
    exit            ; exit to operating system
main ENDP

END main