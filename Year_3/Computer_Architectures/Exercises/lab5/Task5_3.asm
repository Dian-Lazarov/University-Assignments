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
   MOV ECX, SIZEOF source	; Ѕро€ч на циклите
   MOV ESI, OFFSET source
   MOV EDI, OFFSET target
next:   
   MOV AL, [ESI]
   MOV [EDI], AL
   INC ESI
   INC EDI
   LOOP next
   
   ;DEC ECX
   ;JNZ next
   
   mWriteStr OFFSET target	
   exit
main ENDP
END main