TITLE Task5_3     (Task5_3.asm)

; This program copies a string.
INCLUDE Irvine32.inc
INCLUDE Macros.inc

.data
source  BYTE  "This is the source string",0
target  BYTE  SIZEOF source DUP(0),0

.code
main PROC
    ; TODO:
	
    exit
main ENDP
END main