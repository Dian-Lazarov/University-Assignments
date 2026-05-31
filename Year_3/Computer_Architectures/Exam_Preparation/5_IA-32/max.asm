;TITLE Task5_6     (Task5_6.asm)

;INCLUDE Irvine32.inc
;INCLUDE Macros.inc

.data
wArray WORD  0,0,20,35,12,66,4,0
;wArray WORD  0,0,20,35,12,66,4,99
;wArray WORD  100,0,20,35,12,66,4,0

.code
main PROC
    ; TODO:
    ; BX - max
    ; ESI - index
    
    MOV ESI, 0
    MOV ECX, LENGTHOF wArray
    MOV BX, wArray[ESI]
next:
    DEC ECX
    JZ finish
    ADD ESI, TYPE wArray
    MOV AX, wArray[ESI]
    CMP BX, AX
    JNC skip ; !!!
    MOV BX, AX
skip:
    JMP next
finish:
;---------------------------
    AND EBX, 0000FFFFh
    ShowRegister RESULT, EBX
    exit
main ENDP

END main