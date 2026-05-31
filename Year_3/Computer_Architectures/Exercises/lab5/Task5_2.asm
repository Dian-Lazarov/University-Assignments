TITLE Task5_2     (Task5_2.asm)

; This program adds 32-bit integers.

INCLUDE Irvine32.inc
INCLUDE Macros.inc

.data
x     DWORD  20000h ; 32-bit values (DWORD)
y     DWORD  789ABh
z     DWORD  ?

.code
main PROC
    ; TODO:
    MOV EAX, x
    ADD EAX, y
    MOV z, EAX
    
    
    call DumpRegs   ; display the registers
    
    mDumpMem OFFSET z, 1, 4
    
    exit            ; exit to operating system
main ENDP

END main