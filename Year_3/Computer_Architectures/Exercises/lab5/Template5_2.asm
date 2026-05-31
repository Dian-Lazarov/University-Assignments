TITLE Task5_2     (Task5_2.asm)

; This program adds 32-bit integers.

INCLUDE Irvine32.inc
INCLUDE Macros.inc

.data
x     DWORD  20000h
y     DWORD  789ABh
z     DWORD  ?

.code
main PROC
    ; TODO:
    
    
    call DumpRegs   ; display the registers
    exit            ; exit to operating system
main ENDP

END main