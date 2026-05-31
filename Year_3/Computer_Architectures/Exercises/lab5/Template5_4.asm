TITLE Task5_4     (Task5_4.asm)

; This program sums an array of double words
INCLUDE Irvine32.inc
INCLUDE Macros.inc

.data
dwArray DWORD 10000h,20000h,30000h,40000h

.code
main PROC
    ; TODO: 

    call DumpRegs       ; display the registers
    exit
main ENDP
END main