TITLE Task5_5     (Task5_5.asm)

; This program scans an array of words for the first nonzero value.
INCLUDE Irvine32.inc
INCLUDE Macros.inc

.data
wArray WORD  0,0,0,0,0,20,35,12,66,4,0
;wArray WORD  1,0,0,0
;wArray WORD  0,0,0,0
notFoundMsg  BYTE "A non-zero value was not found",0

.code
main PROC
    ; TODO:
    XOR EAX, EAX

found:
    ShowRegister eax, eax
    jmp   quit

notFound:
    mov   edx,OFFSET notFoundMsg    ; display "not found" message
    call  WriteString

quit:
    exit
main ENDP
END main